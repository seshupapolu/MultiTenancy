using Multitenancy.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multitenancy.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var transaction = new System.Transactions.TransactionScope())
            {

                PhysicianRepository repo1 = new PhysicianRepository();
                repo1.Create();

                OrderRepository repo2 = new OrderRepository();
                repo2.Create();

                transaction.Complete();
            }
        }
    }
}
