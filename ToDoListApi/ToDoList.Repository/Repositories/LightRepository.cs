using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entities;
using ToDoList.Repository.Interfaces;

namespace ToDoList.Repository.Repositories
{
    public class LightRepository : ILightRepository
    {
        private DataContext context;
        public LightRepository(DataContext context)
        {
            this.context = context;
        }
        public void Create(Light light)
        {
            context.Conta.Add(light);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.Conta.Remove(GetById(id));
            context.SaveChanges();
        }
        public List<Light> GetAll()
        {
            return context.Conta.Include(x=>x.house).ToList();
        }
        public Light GetById(int id)
        {
            return context.Conta.Include(x=>x.house).SingleOrDefault(x=>x.id==id);
        }
        public void Update(Light light)
        {
            var objLight = GetById(light.id);
            objLight.dataLeitura = light.dataLeitura;
            objLight.numeroLeitura = light.numeroLeitura;
            objLight.kw = light.kw;
            objLight.valor = light.valor;
            objLight.dataPagamento = light.dataPagamento;
            objLight.media = light.media;
            objLight.house = light.house;
            
            context.SaveChanges();
        }
    }
}