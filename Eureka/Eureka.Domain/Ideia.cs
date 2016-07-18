using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Domain
{
    public class Ideia
    {
        public string Tag { get; set; }
        public string Descricao { get; set; }
        public List<Comentario> Comentarios { get; set; }




    }
}
