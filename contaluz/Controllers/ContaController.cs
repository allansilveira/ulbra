using System.Collections.Generic;
using System.Linq;
using contaluz.Models;
using Microsoft.AspNetCore.Mvc;

namespace contaluz.Controllers
{
    public class ContaController : Controller
    {
        LightRepository _repository = new LightRepository();
        
        public IActionResult Index(string sortField, string currentSortField, string currentSortOrder)  
        {  
            var conta = _repository.GetAll();
            return View(this.Order(conta, sortField, currentSortField, currentSortOrder));
        }  
  
        private List<Light> Order(List<Light> conta, string sortField, string currentSortField, string currentSortOrder)  
        {  
            if (string.IsNullOrEmpty(sortField))  
            {  
                ViewBag.SortField = "id";  
                ViewBag.SortOrder = "Asc";
            }  
            else  
            {  
                if (currentSortField == sortField)  
                {  
                    ViewBag.SortOrder = currentSortOrder == "Asc" ? "Desc" : "Asc";  
                }  
                else  
                {  
                    ViewBag.SortOrder = "Asc";  
                }  
                ViewBag.SortField = sortField;  
            }  
            
            var propertyInfo = typeof(Light).GetProperty(ViewBag.SortField);  
            if (ViewBag.SortOrder == "Asc")  
            {  
                conta = conta.OrderBy(s => propertyInfo.GetValue(s, null)).ToList();  
            }  
            else  
            {  
                conta = conta.OrderByDescending(s => propertyInfo.GetValue(s, null)).ToList();  
            }  
            return conta;  
        }  
        
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Light conta)
        {            
            _repository.Create(conta);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {            
            var conta = _repository.GetById(id);
            return View(conta);
        }

        [HttpPost]
        public RedirectToActionResult Edit(Light light)
        {            
            _repository.Update(light);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}