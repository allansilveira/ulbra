using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.Entities;
using ToDoList.Repository.Interfaces;

namespace ToDoList.Web.Controllers
{
    public class ToDoController : Controller
    {
        private ILightRepository repositoryLight;
        private IHouseRepository repositoryHouse;
        public ToDoController(ILightRepository repositoryLight, IHouseRepository repositoryHouse)
        {
            this.repositoryLight = repositoryLight;
            this.repositoryHouse = repositoryHouse;
        }
        public IActionResult Index()
        {
            var lights = repositoryLight.GetAll();
            
            return View(lights);
        }

        public IActionResult Create()
        {
            ViewBag.Houses = repositoryHouse.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Light light)
        {
            light.house = repositoryHouse.GetById(light.house.id);
            repositoryLight.Create(light);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            ViewBag.Houses = repositoryHouse.GetAll();
            var light = repositoryLight.GetById(id);
            return View(light);
        }

        [HttpPost]
        public IActionResult Edit(Light light)
        {
            light.house = repositoryHouse.GetById(light.house.id);
            repositoryLight.Update(light);
            return RedirectToAction("Index");
        }
    }
}