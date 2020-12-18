using Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Manager.Classes
{
    public class UsersData
    {
        public int code { get; set; }
        public meta meta { get; set; }
    }
    public class meta
    {
        public pagination pagination { get; set; }
        public IEnumerable<User> data { get; set; }
    }
    public class pagination
    {
        public int total { get; set; }
        public int pages { get; set; }
        public int page { get; set; }
        public int limit { get; set; }
    }
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string status { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
    }
}
