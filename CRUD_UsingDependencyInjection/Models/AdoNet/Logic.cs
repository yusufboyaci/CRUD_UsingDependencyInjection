using CRUD_UsingDependencyInjection.Models.Entities;

namespace CRUD_UsingDependencyInjection.Models.AdoNet
{
    public class Logic
    {
        DAL dl;
        public Logic(DAL _dl)
        {
           dl = _dl;
        }
        //public List<Detail> List()
        //{
        //    string pass = dl.GetValue("select * from Details");
        //    return List
        //}
        public bool Login(string Username, string Password)
        {
            string pass = dl.GetValue($"select Password from Details where UserName= '{Username}'");
            return pass == Password;
        }
        public String Insert(String name, String Username, String Password)
        {
            string pass = dl.InsertValue($"insert into Details (Id,Name,UserName,Password) VALUES ('{Guid.NewGuid()}','{name}','{Username}','{Password}')");
            return pass;
        }
        public string Update(Guid Id, string name, string username, string password)
        {
            string pass = dl.UpdateValues($"UPDATE Details SET Name='{name}', UserName='{username}', Password='{password}' WHERE Id='{Id}'");
            return pass;
        }
        public string Delete(Guid Id)
        {
            string pass = dl.DeleteValues($"DELETE FROM Details WHERE Id='{Id}'");
            return pass;
        }
    }
}
