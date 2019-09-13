using System.Collections.Generic;

namespace contaluz.Models
{
    public class LightRepository
    {
        public static List<Light> conta = new List<Light>();
    
        public LightRepository()
        {           
        }

        public void Create(Light light)
        {
            conta.Add(light);
        }
        public List<Light> GetAll()
        {
            return conta;
        }
        
        public Light GetById(int id)
        {
            return conta.Find(i=>i.id == id);
        }
        public void Delete(int id)
        {
            conta.Remove(GetById(id));
        }

        public void Update(Light light)
        {
            var index  = conta.FindIndex(x=>x.id == light.id);
            conta[index].dataLeitura = light.dataLeitura;
            conta[index].numeroLeitura = light.numeroLeitura;
            conta[index].kw = light.kw;
            conta[index].valor = light.valor;
            conta[index].dataPagamento = light.dataPagamento;
        }
    }
}