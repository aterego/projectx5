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
using System.Reflection;
using Newtonsoft.Json;
using projectX2.Helpers;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using BLL.Repositories;

namespace projectX2.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoriesRespository _categoriesRepository;

        public CategoriesController(ICategoriesRespository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        [AuthorizedAction]
        public async Task<IActionResult> Index()
        {
            return View(await _categoriesRepository.ListWithPricesAsync());
        }

        [AuthorizedAction]
        public IActionResult Tree()
        {
            HttpContext.Session.SetString("data", _TreeView(1));
            return View();
        }

        [AuthorizedAction]
        public IActionResult List()
        {
            HttpContext.Session.SetString("data2", _TreeView(0));
            return View();
        }


        [AuthorizedAction]
        public IActionResult Create()
        {
            SelectList parentsIdsList = new SelectList(_categoriesRepository.ListAsync().Result, "Id", "Name", 0);
            SelectListItem firstItem = new SelectListItem { Text = "[None]", Value = "0" };
            //ViewBag.Parents = selectList;
            ViewData["Parents"] = AddFirstItem(parentsIdsList, firstItem);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(Categories category)
        {
            try
            {
                category.ParentId = Convert.ToInt32(Request.Form["Parents"].ToString());

                await _categoriesRepository.AddAsync(category);

                int last_insert_id = category.Id;

                CategoriesPrices catPrices = new CategoriesPrices
                {
                    CategoryId = last_insert_id
                };

                var min = Request.Form["PriceMin"].ToString();
                var max = Request.Form["PriceMax"].ToString();

                if (!String.IsNullOrEmpty(min))
                    catPrices.PriceMin = (float)Convert.ToDouble(min);
                else
                    catPrices.PriceMin = 0;

                if (!String.IsNullOrEmpty(max))
                    catPrices.PriceMax = (float)Convert.ToDouble(max);
                else
                    catPrices.PriceMax = 0;

                catPrices.Active = 1;

                await _categoriesRepository.AddPricesAsync(catPrices);

            }
            catch(Exception ex)
            {
                Debug.WriteLine("Something went wrong :" + ex.Message);
            }

            return RedirectToAction("Tree", "Categories");
        }

        [AuthorizedAction]
        [HttpPost]
        public bool Delete(int id)
        {
            try
            {
                List<Categories> childCategories = _categoriesRepository.GetChildCategoriesAsync(id).Result.ToList();
                if (childCategories.Any())
                    return false;

                //List<CategoriesPrices> categoriesPrices = _categoriesRepository.GetCategoryPricesAsync(id).Result.ToList();
                CategoriesPrices categoriesPrices = _categoriesRepository.GetCategoryPricesAsync(id).Result;
                /*
                foreach (var cp in categoriesPrices)
                {
                    _categoriesRepository.Remove(cp);
                }
                */
                _categoriesRepository.Remove(categoriesPrices);

                Categories category = _categoriesRepository.GetCategoryAsync(id).Result;
                _categoriesRepository.Remove(category);
                return true;
            }
            catch (System.Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }
        }

        [AuthorizedAction]
        public async Task<IActionResult> Update(int id)
        {
            var model = await _categoriesRepository.GetCategoryWithPricesAsync(id);
            SelectList parentsIdsList = new SelectList(_categoriesRepository.ListAsync().Result, "Id", "Name", model.ParentId);

            SelectListItem firstItem = new SelectListItem { Text = "[None]", Value = "0" };
            //ViewBag.Parents = selectList;
            ViewData["Parents"] = AddFirstItem(parentsIdsList, firstItem);

            return View(model);
        }


        private SelectList AddFirstItem(SelectList origList, SelectListItem firstItem)
        {
            List<SelectListItem> newList = origList.ToList();
            newList.Insert(0, firstItem);

            var selectedItem = newList.FirstOrDefault(item => item.Selected);
            var selectedItemValue = String.Empty;
            if (selectedItem != null)
            {
                selectedItemValue = selectedItem.Value;
            }

            return new SelectList(newList, "Value", "Text", selectedItemValue);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateCategory(Categories category)
        {
            try
            {
                category.ParentId = Convert.ToInt32(Request.Form["Parents"].ToString());

                await _categoriesRepository.UpdateAsync(category);

                //CategoriesPrices catPrices = _categoriesRepository.GetCategoryPricesAsync(category.Id).Result.First();
                CategoriesPrices catPrices = await _categoriesRepository.GetCategoryPricesAsync(category.Id);

                var min = Request.Form["PriceMin"].ToString();
                var max = Request.Form["PriceMax"].ToString();

                if (!String.IsNullOrEmpty(min))
                    catPrices.PriceMin = (float) Convert.ToDouble(min);
                else
                    catPrices.PriceMin = 0;

                if (!String.IsNullOrEmpty(max))
                    catPrices.PriceMax = (float)Convert.ToDouble(max);
                else
                    catPrices.PriceMax = 0;

                catPrices.Active = 1;

                await _categoriesRepository.UpdatePricesAsync(catPrices);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong :" + ex.Message);
            }

            return RedirectToAction("Tree", "Categories");


        }


        #region TreeView
        public string _TreeView(int showActions)
        {
            // getting table data from database (menu is the name of table)
            var dn = _categoriesRepository.GetDN();
            //var dn = _context.Categories.Join(_context.CategoriesPrices, c => c.Id, cp => cp.CategoryId, (p, cp) => new List<dynamic> { p.Id, p.ParentId, p.Name, p.Description, cp.PriceMin, cp.PriceMin }).ToList(); ; 
            DataSet ds = new DataSet();
            ds = DataHelper.ToDataSet(dn);
            DataTable table = ds.Tables[0];
            DataRow[] parentCategories = table.Select("ParentId = 0");
            var sb = new StringBuilder();
            sb.Append("[");
            string unorderedList = GenerateUL(parentCategories, table, sb, showActions);
            return unorderedList + "]";
        }
        private string GenerateUL(DataRow[] category, DataTable table, StringBuilder sb, int showActions)
        {
            if (category.Length > 0)
            {
                foreach (DataRow dr in category)
                {
                    //var json = JsonConvert.SerializeObject(category);
                    sb.Append("{");
                    string id = dr["Id"].ToString();
                    string categoryText = "<strong>" + dr["Name"].ToString() + "</strong>";
                    string description = dr["Description"].ToString();
                    string prices = "Price: " + dr["PriceMin"].ToString() + " - " + dr["PriceMax"].ToString();
                    if (showActions == 1)
                    {
                        string updateLink = "<a href = 'Update/" + id + "'> Update </a>";
                        string deleteLink = "<a href = '#' onclick='Delete(" + id + ")'>Delete</a>";
                        sb.Append(String.Format(@" ""text"": ""{0}&nbsp;&nbsp;|&nbsp;&nbsp;{1}&nbsp;&nbsp;|&nbsp;&nbsp;{2}&nbsp;&nbsp;|&nbsp;&nbsp;{3}&nbsp;&nbsp;|&nbsp;&nbsp;{4}"",", categoryText, description, prices, updateLink, deleteLink));
                    }
                    else
                    {
                        sb.Append(String.Format(@" ""text"": ""{0}&nbsp;&nbsp;|&nbsp;&nbsp;{1}&nbsp;&nbsp;|&nbsp;&nbsp;{2}&nbsp;&nbsp;"",", categoryText, description, prices));
                    }

                    sb.Append(String.Format(@" ""href"": ""{0}""", "#"));
                    string parentId = dr["ParentId"].ToString();
                    DataRow[] subMenu = table.Select(String.Format("ParentId = '{0}'", id));
                    if (subMenu.Length > 0 && !id.Equals(parentId))
                    {
                        var subMenuBuilder = new StringBuilder();
                        sb.Append(String.Format(@", ""nodes"": ["));
                        sb.Append(GenerateUL(subMenu, table, subMenuBuilder, showActions));
                        sb.Append("]");
                    }
                    sb.Append("},");
                }
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }

        #endregion TreeView

    }
}