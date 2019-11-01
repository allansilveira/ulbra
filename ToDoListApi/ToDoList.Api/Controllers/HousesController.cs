using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.Entities;
using ToDoList.Repository.Interfaces;

namespace ToDoList.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private IHouseRepository repository;

        public HousesController(IHouseRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<House>> Get()
        {
            var types = repository.GetAll();
            return types;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<House> Get(int id)
        {
            var obj = repository.GetById(id);
            return obj;
        }

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] House house)
        {
            repository.Create(house);
            return Ok(house);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(
                new
                {
                    mensagem = "Registro removido com sucesso",
                    codigo = id
                }
            );
        }
    }
}
