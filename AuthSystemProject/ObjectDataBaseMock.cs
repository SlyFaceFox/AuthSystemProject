using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthSystemProject
{
    public class ObjectDataBaseMock
    {
        private Object_Client[] Object_Clients;

        public ObjectDataBaseMock(int length)
        {
            Object_Clients = new Object_Client[length];
            Init();
        }

        public Object_Client[] GetAll()
        {
            return Object_Clients;
        }

        public Object_Client? Get(string name, int num)
        {
            foreach (Object_Client c in Object_Clients)
            {
                if (c.Name.Equals(name) && c.AccountNum.Equals(num))
                {
                    return c;
                }
            }

            return null;
        }

        public Object_Client? GetById(int id)
        {
            foreach (Object_Client c in Object_Clients)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }

            return null;
        }
        public Object_Client? AddById(int id, string name, int num)
        {
            {
                foreach (Object_Client c in Object_Clients)
                {
                    if (c.Id == id)
                    {
                        c.Name = name;
                        c.AccountNum = num;
                        Console.WriteLine("Данные о клиенте были успешно перезаписаны");
                        return c;
                    }
                    else if (id >= Object_Clients.Length)
                    {
                        Console.WriteLine("Введённый вышел за пределы БД");
                        return null;
                    }
                }
            }
            return null;
        }

        private void Init()
        {
            for (int i = 0; i < Object_Clients.Length; i++)
            {
                Object_Clients[i] = new Object_Client(
                    "Name" + i,
                    0 + i
                    );
                Object_Clients[i].Id = i;
            }
        }
    }
}
