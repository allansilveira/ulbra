using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using contaluz.Models;

namespace contaluz.Controllers
{   
    public class ContaController : Controller
    {
        private iLightRepository repository;
        public ContaController(iLightRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index(string sortField, string currentSortField, string currentSortOrder)  
        {  
            var listaConta = repository.GetAll();
            return View(this.Order(listaConta, sortField, currentSortField, currentSortOrder));
        }  
        private List<Light> Order(List<Light> listaConta, string sortField, string currentSortField, string currentSortOrder)  
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
                listaConta = listaConta.OrderBy(s => propertyInfo.GetValue(s, null)).ToList();  
            }  
            else  
            {  
                listaConta = listaConta.OrderByDescending(s => propertyInfo.GetValue(s, null)).ToList();  
            }  
            return listaConta;  
        }
        public IActionResult Create()
        {            
            return View();
        } 
        [HttpPost]
        public IActionResult Create(Light light)
        {        
            repository.Create(light);    
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var light = repository.GetById(id);
            return View(light);
        } 
        [HttpPost]
        public IActionResult Edit(Light light)
        {        
            repository.Update(light);    
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {        
            repository.Delete(id);    
            return RedirectToAction("Index");
        } 
    }
}
