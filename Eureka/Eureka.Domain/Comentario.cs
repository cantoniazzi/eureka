using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Domain
{
    public class Comentario
    {
        public int ComentarioID { get; set; }
        public string Usuario { get; set; } //User.Identity.Name futuramente
        public string Descricao { get; set; }
        
        public int Avaliacao { get; set; }

        
    }
}
