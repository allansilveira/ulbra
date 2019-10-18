using System.Collections.Generic;

namespace Aula08CredPeopleEF.Models
{
    public interface iPersonRepository
    {
         void Create(Person person);
         void Update(Person person);
         void Delete(int id);
         Person GetById(int id);
         List<Person> GetAll();
    }
}