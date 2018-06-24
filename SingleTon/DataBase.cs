using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTon
{
    public class DataBase
    {
        private static DataBase SingleObject;
        private int record;
        private string name;
        private DataBase(string n)
        {
            name = n;
            record = 0;
        }

        public static DataBase GetInstance(string n)
        {
            if (SingleObject == null)
            {
                SingleObject = new DataBase(n);
            }
            return SingleObject;
        }

        public void EditRecord(string operation)
        {
            Console.WriteLine("Performing a " + operation + " operation on record " + record + " in databse " + name);
        }

        public string GetName()
        {
            return name;
        }
    }
}
