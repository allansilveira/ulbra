using System.Collections.Generic;

namespace ToDoList.Domain.Entities
{
    public class House
    {
        public House(){}
        public House(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
        public int id { get; set; }
        public string nome { get; set; }
    }
}