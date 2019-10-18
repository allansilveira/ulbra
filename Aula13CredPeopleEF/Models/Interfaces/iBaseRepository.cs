using System.Collections.Generic;

namespace Aula13CredPeopleEF.Models
{
    public interface iBaseRepository<Entity> where Entity : class
    {
         void Create(Entity entity);
         void Update(Entity entity);
         void Delete(int id);
         Entity GetById(int id);
         List<Entity> GetAll();
    }
}