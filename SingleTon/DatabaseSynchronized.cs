using System;
using System.Collections.Generic;
using System.Text;

namespace SingleTon
{
    public class DatabaseSynchronized
    {
        private static DatabaseSynchronized SingleObject;
        private int record;
        private string name;
        private static Object _object = new object();
        private DatabaseSynchronized(string n)
        {
            name = n;
            record = 0;
        }

        public static DatabaseSynchronized GetInstance(string n)
        {
            lock (_object)
            {
                if (SingleObject == null)
                {
                    SingleObject = new DatabaseSynchronized(n);
                }
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
