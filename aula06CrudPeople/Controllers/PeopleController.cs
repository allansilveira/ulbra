using aula06CrudPeople.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula06CrudPeople.Controllers
{
    public class PeopleController : Controller
    {
        PersonRepository _repository = new PersonRepository();
        public IActionResult Index()
        {
            var people = _repository.GetAll();
            return View(people);
        }
        
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Person person)
        {            
            _repository.Create(person);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {            
            var pessoa = _repository.GetById(id);
            return View(pessoa);
        }

        [HttpPost]
        public RedirectToActionResult Edit(Person person)
        {            
            _repository.Update(person);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
        
    }
}