using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
 
using ToBeLifeBetter.Service;

namespace Test
{
    class Program
    {
        public static Dictionary<string, string> dicList = new Dictionary<string, string>();

        static void Main(string[] args)
        {
           // ToBeLifeBetter.LogEasy.LogHelper.Info("{0}");

            using (SQLDbContext db = new SQLDbContext())
            {

                db.Database.Delete();
                db.Database.Create();
            }
        }



        static void Main2(string[] args)
        {
            Thread thread = new Thread(() =>
            {
                while (true)
                {

                    dicList[DateTime.Now.ToString()] = DateTime.Now.ToString();
                }
            });
            thread.IsBackground = !thread.IsBackground;
            thread.Start();

            Thread thread1 = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(1000);
                    int i = dicList.Count();
                    string vv = dicList.Select(m => m).ToList()[i - 1].Value;
                    dicList.Clear();
                }
            });
            thread1.IsBackground = !thread1.IsBackground;
            thread1.Start();

            Console.Read();
        }
    }
}
