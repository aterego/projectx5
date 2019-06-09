using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Linq;
using projectX2.Helpers;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Newtonsoft.Json;
using System;
using BLL.Repositories;
using System.Threading.Tasks;

namespace projectX2.Controllers
{
    public class AdminAccountController : Controller
    {
        private readonly IAdminAccountRepository _adminAccountRepository;

        public AdminAccountController(IAdminAccountRepository adminAccountRepository)
        {
            _adminAccountRepository = adminAccountRepository;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Validate(Admins admin)
        {
            var _admin = await _adminAccountRepository.GetAdminsAsync(admin);
            if (_admin != null)
            {
                if (PasswordHasher.Verify(admin.Password, _admin.Password))
                {
                    HttpContext.Session.SetString("email", _admin.Email);
                    HttpContext.Session.SetInt32("id", _admin.Id);
                    HttpContext.Session.SetInt32("role_id", (int)_admin.RolesId);
                    HttpContext.Session.SetString("name", _admin.Name);
                    HttpContext.Session.SetString("username", _admin.Username);
                    HttpContext.Session.SetString("created", _admin.Created.ToShortDateString());
                    int roleId = (int)HttpContext.Session.GetInt32("role_id");

                    //***AVA*** Gavatar
                    //  Compute the hash
                    string hash = Gavatar.HashEmailForGravatar(_admin.Email);
                    HttpContext.Session.SetString("gavatar", string.Format("http://www.gravatar.com/avatar/{0}", hash));

                    List<Menus> menus = await _adminAccountRepository.GetMenusAsync(roleId);
                    DataSet ds = new DataSet();
                    ds = DataHelper.ToDataSet(menus);
                    DataTable table = ds.Tables[0];
                    DataRow[] parentMenus = table.Select("ParentId = 0");
                    var sb = new StringBuilder();
                    string menuString = GenerateUL(parentMenus, table, sb);
                    HttpContext.Session.SetString("menuString", menuString);
                    HttpContext.Session.SetString("menus", JsonConvert.SerializeObject(menus));




                    return Json(new { status = true, message = "Login Successfull!" });
                }
                else
                {
                    return Json(new { status = false, message = "Invalid Password!" });
                }
            }
            else
            {
                return Json(new { status = false, message = "Invalid Email!" });
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/AdminAccount/Login");
        }

        private string GenerateUL(DataRow[] menu, DataTable table, StringBuilder sb)
        {
            if (menu.Length > 0)
            {
                foreach (DataRow dr in menu)
                {
                    string url = dr["Url"].ToString();
                    string menuText = dr["Name"].ToString();
                    string icon = dr["Icon"].ToString();
                    int is_visible = Convert.ToInt16(dr["IsVisible"]);
                    if (is_visible == 1)
                    {
                        if (url != "#")
                        {
                            string line = String.Format(@"<li><a href=""{0}""><i class=""{2}""></i> <span>{1}</span></a></li>", url, menuText, icon);
                            sb.Append(line);
                        }
                        string pid = dr["Id"].ToString();
                        string parentId = dr["ParentId"].ToString();
                        DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", pid));
                        if (subMenu.Length > 0 && !pid.Equals(parentId))
                        {
                            string line = String.Format(@"<li class=""treeview""><a href=""#""><i class=""{0}""></i> <span>{1}</span><span class=""pull-right-container""><i class=""fa fa-angle-left pull-right""></i></span></a><ul class=""treeview-menu"">", icon, menuText);
                            var subMenuBuilder = new StringBuilder();
                            sb.AppendLine(line);
                            sb.Append(GenerateUL(subMenu, table, subMenuBuilder));
                            sb.Append("</ul></li>");
                        }
                    }
                }
            }
            return sb.ToString();
        }


    }
}