using Modelo.Cadastros;

namespace Modelos.Docente
{
    public class CursosProfessor
    {
        public long? CursoID { get; set; }
        public Curso Curso { get; set; }
        public long? ProfessorID { get; set; }
        public Professor Professor { get; set; }
    }
}