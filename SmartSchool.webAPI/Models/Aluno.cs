using System.Collections.Generic;
namespace SmartSchool.webAPI.Models
{
    public class Aluno
    {
        //ctor contrutor normal
        public Aluno() {}
        public Aluno(int id, string nome, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Telefone = telefone;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }


        public IEnumerable<AlunoDiciplina> AlunoDiciplinas { get; set; }






    }
}