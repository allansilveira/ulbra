using System.Collections.Generic;
using System.Linq;
using ToDoList.Domain.Entities;
using ToDoList.Repository.Interfaces;

namespace ToDoList.Repository.Repositories
{
    public class HouseRepository : IHouseRepository
    {
        private DataContext context;
        public HouseRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(House type)
        {
            context.Imovel.Add(type);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.Imovel.Remove(GetById(id));
            context.SaveChanges();
        }
        public List<House> GetAll()
        {
            return context.Imovel.ToList();
        }
        public House GetById(int id)
        {
            return context.Imovel.SingleOrDefault(x=>x.id==id);
        }
        public void Update(House house)
        {
            throw new System.NotImplementedException();
        }
    }
}