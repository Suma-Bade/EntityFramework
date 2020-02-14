using System;
using EFDAL;
using EFDAL.Models;
using EFDAL.Context;
namespace EMSClient
{
    class Program
    {
        static void Main(string[] args)
        {
           //add new project
           using(MyContext db=new MyContext())
            {
                Project p = new Project() { ProjectName = "DFS" };
                db.Add(p);
                 db.SaveChanges();
            }
        }
    }
}
