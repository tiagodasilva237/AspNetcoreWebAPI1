using System.Collections.Generic;

namespace SmartSchool.webAPI.Models
{
    public class Diciplina
    {
        //contrutor simples
        public Diciplina() { }
        
            //construtor esse nao precisa (atributo Professor professor)
        public Diciplina(int id, string nome, int professorId)
        {
            this.Id = id;
            this.Nome = nome;
            this.ProfessorId = professorId;

        }
        //Atributos
       
        public int Id { get; set; }
        public string Nome { get; set; }
        // professorId é padrao  enty frawork     
        public int ProfessorId { get; set; }
        //propriedade segundo prof. refere a classe professor
        public Professor Professor { get; set; }


        public IEnumerable<AlunoDiciplina> AlunoDiciplinas { get; set; }

        
    }
}
