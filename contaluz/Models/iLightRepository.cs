using System.Collections.Generic;

namespace contaluz.Models
{
    public interface iLightRepository
    {
         void Create(Light conta);
         void Update(Light conta);
         void Delete(int id);
         Light GetById(int id);
         List<Light> GetAll();
    }
}