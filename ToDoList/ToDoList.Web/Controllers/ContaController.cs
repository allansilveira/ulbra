using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.Entities;
using ToDoList.Repository.Interfaces;

namespace ToDoList.Web.Controllers
{
    public class ContaController : Controller
    {
        private ILightRepository repository;
        public ContaController(ILightRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {  
            var listaConta = repository.GetAll();
            return View(listaConta);
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