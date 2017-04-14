namespace Multitenancy.Repository
{
    public class OrderRepository
    {
        private  string _orderConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["orderConnection"].ConnectionString;
        //System.Configuration.Configuration.;
        public bool Create()
        {
            DataAccess.DataAccess db = new DataAccess.DataAccess(_orderConnectionString);
            return db.Execute("insert into [order] values(1,'prod1')");

        }
    }
}
