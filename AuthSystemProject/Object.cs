using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AuthSystemProject.User;

namespace AuthSystemProject
{
    public class Object_Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountNum { get; set; } 
        

      

        public Object_Client(string name , int accountNum )
        {
            Name = name;
            AccountNum = accountNum;
         
            
        }

    }
}
