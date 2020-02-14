using System;
using EFAssignment1;
using EFAssignment1.Models;
using EFAssignment1.Context;


namespace ItemClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db = new MyContext())
            {
                Item p = new Item() { ItemName = "Electronics" };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}
