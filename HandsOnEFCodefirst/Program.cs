using System;
using HandsOnEFCodefirst.Models;
using HandsOnEFCodefirst.Context;
using System.Linq;
using System.Collections.Generic;

namespace HandsOnEFCodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using(MyContext db=new MyContext())
            {
                //insert new record
                // Student s = new Student() { Sname = "Karan", Age = 10, Std = "II" };
               // db.Students.Add(s);
               //db.SaveChanges();
                //fetch records
                // Student s = db.Students.Find(1);
                //Console.WriteLine("Welcome {0}", s.Sname);
                //fetch one record using non primary key
                 Student s1 = db.Students.SingleOrDefault(i => i.Sname == "Rohan");//lambda expr
                List<Student> list = db.Students.Where(i => i.Age == 10).ToList();
                List<Student> list1 = db.Students.Where(i => i.Age == 10 && i.Std == "II").ToList();
                //update record
                Student s2 = db.Students.Find(1);
                s2.Age = 11;//updating value
                db.Students.Update(s2);
                db.SaveChanges();
                //
                delete record
               Student s3 = db.Students.SingleOrDefault(i => i.Sname == "Rohan");
                db.Students.Remove(s3);
                db.SaveChanges();


            }
        }
    }
}
