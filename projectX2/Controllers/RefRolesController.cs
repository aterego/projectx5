using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
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

namespace projectX2.Controllers
{
    public class RefRolesController : Controller
    {
        private readonly IRefRolesRepository _refRolesRepository;

        public RefRolesController(IRefRolesRepository refRolesRepository)
        {
            _refRolesRepository = refRolesRepository;
        }

        // GET: Roles
        [AuthorizedAction]
        public async Task<IActionResult> Index()
        {
           int roleId = (int)HttpContext.Session.GetInt32("role_id");
           return View(await _refRolesRepository.ListAsync(roleId));
        }

        // GET: Roles/Create
        [AuthorizedAction]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Roles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Id,Title,Description")] RefRoles roles)
        {
            if (ModelState.IsValid)
            {
                await _refRolesRepository.AddAsync(roles);
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }

        // GET: Roles/Edit/5
        [AuthorizedAction]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _refRolesRepository.GetRolesAsync(id.Value);
            if (roles == null)
            {
                return NotFound();
            }

            DataSet ds = new DataSet();
            List<string> menus_id = await _refRolesRepository.GetMenus(id.Value);
            ds = DataHelper.ToDataSet(await _refRolesRepository.ListMenusAsync());
            DataTable table = ds.Tables[0];
            DataRow[] parentMenus = table.Select("ParentId = 0");

            var sb = new StringBuilder();
            string unorderedList = GenerateUL(parentMenus, table, sb, menus_id);
            ViewBag.menu = unorderedList;

            return View(roles);
        }

        // POST: Roles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Description")] RefRoles roles)
        {
            if (id != roles.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _refRolesRepository.UpdateAsync(roles);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await RolesExists(roles.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(roles);
        }


        // GET: Roles/Delete/5
        [AuthorizedAction]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roles = await _refRolesRepository.GetRolesAsync(id.Value);
            if (roles == null)
            {
                return NotFound();
            }

            return View(roles);
        }

        // POST: Roles/Delete/5
        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            foreach (var role in await _refRolesRepository.GetRolesMenus(id))
            {
                await _refRolesRepository.Remove(role);
            }

            var roles = await _refRolesRepository.GetRolesAsync(id);
            await _refRolesRepository.Remove(roles);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Update(int id, List<int> roles)
        {
            var temp = await _refRolesRepository.GetRolesMenus(id);
            foreach (var item in temp)
            {
                await _refRolesRepository.Remove(item);
            }

            foreach (var role in roles)
            {
               await _refRolesRepository.AddRolesMenusAsync(new RolesMenus { MenusId = role, RolesId = id });
            }


            return Json(new { status = true, message = "Successfully Updated Role!" });
        }

        private async Task<bool> RolesExists(int id)
        {
            return await _refRolesRepository.RolesExists(id);
        }


        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb, List<string> menus_id)
        {
            if (menu.Length > 0)
            {
                //***AVA*** disable Super Admin roles for non-supervisor
                int roleId = (int)HttpContext.Session.GetInt32("role_id");
                int super = 0;

                foreach (DataRow dr in menu)
                {
                    string id = dr["id"].ToString();
                    string handler = dr["url"].ToString();
                    string menuText = dr["name"].ToString();
                    string icon = dr["icon"].ToString();
                    int is_visible = Convert.ToInt16(dr["IsVisible"]);
                    if(roleId !=1)
                        super = Convert.ToInt16(dr["Super"]);

                    //if (is_visible == 1 && super == 0)
                    if (super == 0)
                    {

                        string pid = dr["id"].ToString();
                        string parentId = dr["ParentId"].ToString();

                        string status = (menus_id.Contains(id)) ? "Checked" : "";

                        DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", pid));
                        if (subMenu.Length > 0 && !pid.Equals(parentId))
                        {
                            string line = String.Format(@"<li class=""has""><input type=""checkbox"" name=""subdomain[]"" id=""{5}"" value=""{1}"" {4}><label>&nbsp;&rsaquo; {1}</label>", handler, menuText, icon, "target", status, id);
                            sb.Append(line);

                            var subMenuBuilder = new StringBuilder();
                            sb.AppendLine(String.Format(@"<ul>"));
                            sb.Append(GenerateUL(subMenu, table, subMenuBuilder, menus_id));
                            sb.Append("</ul>");
                        }
                        else
                        {
                            string line = String.Format(@"<li class=""""><input type=""checkbox"" name=""subdomain[]"" id=""{5}"" value=""{1}"" {4}><label>&nbsp;{1}</label>", handler, menuText, icon, "target", status, id);
                            sb.Append(line);
                        }
                        sb.Append("</li>");
                    }
                }
            }
            return sb.ToString();
        }

    }
}
