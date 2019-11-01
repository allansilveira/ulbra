using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.Entities;
using ToDoList.Repository.Interfaces;

namespace ToDoList.Web.Controllers
{
    public class ContaController : Controller
    {
        private ILightRepository lightRepository;
        private IHouseRepository houseRepository;
        public ContaController(ILightRepository lightRepository, IHouseRepository houseRepository)
        {
            this.lightRepository = lightRepository;
            this.houseRepository = houseRepository;
        }
        public IActionResult Index()
        {  
            var listaConta = lightRepository.GetAll();
            return View(listaConta);
        }  
        public IActionResult Create()
        {
            ViewBag.Houses = houseRepository.GetAll();
            return View();
        } 
        [HttpPost]
        public IActionResult Create(Light light)
        {      
            light.house = houseRepository.GetById(light.house.id);
            lightRepository.Create(light);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Houses = houseRepository.GetAll();
            var light = lightRepository.GetById(id);
            return View(light);
        } 
        [HttpPost]
        public IActionResult Edit(Light light)
        {     
            light.house = houseRepository.GetById(light.house.id);
            lightRepository.Update(light);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {        
            lightRepository.Delete(id);    
            return RedirectToAction("Index");
        }
    }
}