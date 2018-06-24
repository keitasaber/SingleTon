using System;
using System.Threading;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataBase database;
            //database = DataBase.GetInstance("product");
            //Console.WriteLine(database.GetName());

            //database = DataBase.GetInstance("Employee");
            //Console.WriteLine(database.GetName());

            DatabaseSynchronized databaseSynchronized;

            Thread t1 = new Thread(() =>
            {
                databaseSynchronized = DatabaseSynchronized.GetInstance("product");
                Console.WriteLine(databaseSynchronized.GetName());
            });
            t1.Start();
            Thread t2 = new Thread(() =>
            {
                databaseSynchronized = DatabaseSynchronized.GetInstance("asdasd");
                Console.WriteLine(databaseSynchronized.GetName());
            });
            t2.Start();

            Console.ReadKey();
        }
    }
}
