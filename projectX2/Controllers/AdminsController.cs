using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Data;
using System.Text;
using Newtonsoft.Json;
using projectX2.Helpers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using BLL.Repositories;
using projectX2.Models;

namespace projectX2.Controllers
{
    public class AdminsController : Controller
    {
        private readonly IAdminsRepository _adminsRepository;
        private readonly IRefRolesRepository _refRolesRepository;

        public AdminsController(IAdminsRepository adminsRepository, IRefRolesRepository refRolesRepository)
        {
            _adminsRepository = adminsRepository;
            _refRolesRepository = refRolesRepository;
        }

        // GET: Admins
        [AuthorizedAction]
        public async Task<IActionResult> Index()
        {
            int roleId = (int)HttpContext.Session.GetInt32("role_id");
            return View(await _adminsRepository.ListAsync(roleId));
        }

        // GET: Admins/Create
        [AuthorizedAction]
        public async Task<IActionResult> Create()
        {
            int roleId = (int)HttpContext.Session.GetInt32("role_id");
            SelectList rolesIdsList = new SelectList(await _refRolesRepository.ListAsync(roleId), "Id", "Title");

            ViewBag.RolesId = rolesIdsList;
            return View();
        }

        // POST: Admins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Username,Name,Email,Password,ConfirmPassword,RolesId")] AdminsViewModel admins)
        {
            int roleId = (int)HttpContext.Session.GetInt32("role_id");

            if (ModelState.IsValid)
            {
                Admins adm =  new Admins
                { 
                    Username = admins.Username,
                    Name = admins.Name,
                    Email = admins.Email,
                    Password = PasswordHasher.Hash(admins.Password),
                    RolesId = admins.RolesId
                };

                await _adminsRepository.AddAsync(adm);
                return RedirectToAction(nameof(Index));
            }
            ViewData["RolesId"] = new SelectList(await _refRolesRepository.ListAsync(roleId), "Id", "Title", admins.RolesId);
            return View(admins);
        }

        // GET: Admins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _adminsRepository.GetAdminAsync(id.Value);
            if (admins == null)
            {
                return NotFound();
            }

            var model = new AdminsViewModel
            {
                Id = admins.Id,
                Name = admins.Name,
                Username = admins.Username,
                Email = admins.Email
            };

            int roleId = (int)HttpContext.Session.GetInt32("role_id");
            SelectList rolesIdsList = new SelectList(await _refRolesRepository.ListAsync(roleId), "Id", "Title", admins.RolesId);

            ViewData["RolesId"] = rolesIdsList;
            return View(model);
        }

        // POST: Admins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Name,Email,Password,ConfirmPassword,RolesId")] AdminsViewModel admins)
        {
            if (id != admins.Id)
            {
                return NotFound();
            }

            var passwordChanged = true;
            Admins admin = await _adminsRepository.GetAdminAsync(admins.Id);
            if (String.IsNullOrEmpty(admins.Password) && String.IsNullOrEmpty(admins.ConfirmPassword))
            {
                //ModelState.FirstOrDefault(x => x.Key == nameof(admins.Password)).Value.RawValue = "changed";
                ModelState.SetModelValue("Password", new ValueProviderResult("changed"));
                ModelState["Password"].ValidationState = ModelValidationState.Valid;
                //ModelState.FirstOrDefault(x => x.Key == nameof(admins.ConfirmPassword)).Value.RawValue = "changed";
                ModelState.SetModelValue("ConfirmPassword", new ValueProviderResult("changed"));
                ModelState["ConfirmPassword"].ValidationState = ModelValidationState.Valid;
                /*
                if (ModelState.ContainsKey("Password"))
                    ModelState["Password"].Errors.Clear();
                */
                passwordChanged = false;
            }

            if (ModelState.IsValid)
            {
                admin.Name = admins.Name;
                admin.Username = admins.Username;
                admin.Email = admins.Email;
                if (passwordChanged)
                    admin.Password = PasswordHasher.Hash(admins.Password);
                admin.RolesId = admins.RolesId;

                await _adminsRepository.UpdateAsync(admin);
  
                return RedirectToAction(nameof(Index));
            }

            int roleId = (int)HttpContext.Session.GetInt32("role_id");
            SelectList rolesIdsList = new SelectList(await _refRolesRepository.ListAsync(roleId), "Id", "Title", admins.RolesId);

            ViewData["RolesId"] = rolesIdsList;

            return View(admins);

        }

        // GET: Admins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var admins = await _adminsRepository.GetAdminWithRolesAsync(id.Value);
            if (admins == null)
            {
                return NotFound();
            }

            return View(admins);
        }


        // POST: Admins/DeleteConfirmed/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var admins = await _adminsRepository.GetAdminAsync(id);
            await _adminsRepository.Remove(admins);
            return RedirectToAction(nameof(Index));
        }

        private async Task<bool> AdminsExists(int id)
        {
            return await _adminsRepository.AdminsExists(id);
        }



    }
}