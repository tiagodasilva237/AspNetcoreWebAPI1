using System.Collections.Generic;

namespace SmartSchool.webAPI.Models
{
    public class Professor
    {
        public Professor(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;

        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public IEnumerable<Diciplina> Diciplinas { get; set; }



    }



}