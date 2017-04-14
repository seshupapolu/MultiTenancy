using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitenancy.Repository
{
    public class PhysicianRepository
    {

        private string _physicianConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["physicianConnection"].ConnectionString;
        public bool Create()
        {
            DataAccess.DataAccess db = new DataAccess.DataAccess(_physicianConnectionString);
            return db.Execute("insert into physician values(2,'prod1')");

        }
    }
}
