using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Aula13CredPeopleEF.Models;

namespace Aula13CredPeopleEF.Controllers
{   
    public class PeopleController : Controller
    {
        private iPersonRepository repository;
        public PeopleController(iPersonRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index(string sortField, string currentSortField, string currentSortOrder)  
        {  
            var listPeople = repository.GetAll();
            return View(this.Order(listPeople, sortField, currentSortField, currentSortOrder));
        }  
        private List<Person> Order(List<Person> listPeople, string sortField, string currentSortField, string currentSortOrder)  
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
            
            var propertyInfo = typeof(Person).GetProperty(ViewBag.SortField);  
            if (ViewBag.SortOrder == "Asc")  
            {  
                listPeople = listPeople.OrderBy(s => propertyInfo.GetValue(s, null)).ToList();  
            }  
            else  
            {  
                listPeople = listPeople.OrderByDescending(s => propertyInfo.GetValue(s, null)).ToList();  
            }  
            return listPeople;  
        }
        public IActionResult Create()
        {            
            return View();
        } 
        [HttpPost]
        public IActionResult Create(Person person)
        {
            person.city = new City{id = 1, name = "Imbé" };
            repository.Create(person);    
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var person = repository.GetById(id);
            return View(person);
        } 
        [HttpPost]
        public IActionResult Edit(Person person)
        {        
            repository.Update(person);    
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {        
            repository.Delete(id);    
            return RedirectToAction("Index");
        } 
    }
}
