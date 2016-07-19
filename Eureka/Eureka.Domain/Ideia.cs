using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Domain
{
    public class Ideia
    {
        public int IdeiaID { get; set; }
        public string Titulo { get; set; }
        public string Tag { get; set; }
        public string Descricao { get; set; }
        public int Avaliacao { get; set; }
        public string Usuario { get; set; } //User.Identity.Name

        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Ideia()
        {
            this.Comentarios = new List<Comentario>();
        }
    }
}
