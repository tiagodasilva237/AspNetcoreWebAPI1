namespace SmartSchool.webAPI.Models
{
    public class AlunoDiciplina
    {
        public AlunoDiciplina() { }

        public AlunoDiciplina(int alunoId, int diciplinaId)
        {
            this.AlunoId = alunoId;
           
            this.DiciplinaId = diciplinaId;
            

        }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public int DiciplinaId { get; set; }
        public Diciplina Diciplina { get; set; }




    }
}