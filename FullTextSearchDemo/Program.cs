using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullTextSearchDemo.Model;

namespace FullTextSearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new WorldwideContext())
            {
                Console.WriteLine("Press 1 run without Interceptor \n or 2 to run with interceptor : ");
                var option = Console.Read();
                var watch = new Stopwatch();
                watch.Start();
                string s = string.Empty;
                s = option == '1' ? "NIPPON" : FtsInterceptor.Fts("NIPPON");
                //s = FtsInterceptor.Fts("NIPPON");
                var query = db.Shipments.Where(n => n.FromName.Contains(s) || n.ToName.Contains(s));
                var x1=   query.Count();
                watch.Stop();
                Console.WriteLine("Completed in {0} seconds. Total records {1} Press any key to exit...", watch.Elapsed.Seconds, x1);
                Console.ReadKey();
            }
        }
    }
}