using InstituicaoDeEnsinoSuperior.Modelo.Cadastros;
using Modelos.Docente;
using System.Collections.Generic;

namespace Modelo.Cadastros
{
    public class Curso
    {
        public long? CursoID { get; set; }
        public string Nome { get; set; }

        public long? DepartamentoID { get; set; }
        public Departamento Departamento { get; set; }
        public virtual ICollection<CursoDisciplina> CursoDisciplinas { get; set; }

        public virtual ICollection<CursosProfessor> CursosProfessores { get; set; }
    }
}
