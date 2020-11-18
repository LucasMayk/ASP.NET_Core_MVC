using System;
using System.Collections.Generic;
using System.Text;

namespace Modelos.Docente
{
    public class Professor
    {
        public long? ProfessorID { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<CursosProfessor> CursosProfessores { get; set; }
    }
}
