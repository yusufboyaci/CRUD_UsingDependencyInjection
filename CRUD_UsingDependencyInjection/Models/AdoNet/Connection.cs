namespace CRUD_UsingDependencyInjection.Models.AdoNet
{
    public class Connection
    {
        public string ConnectionString { get; set; }
        public Connection()
        {
            this.ConnectionString = "Server=.;database=WEBdb;uid=yusuf;pwd=123";
        }
    }
}
