using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eureka.Infra.Context
{
    public class MyDatabase : DbContext
    {
        public MyDatabase()
            : base("ConnectionStringName")
        {

        }
    }
}
