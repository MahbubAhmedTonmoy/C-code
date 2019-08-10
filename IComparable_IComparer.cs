using System;
using System.Collections.Generic;

namespace dddd
{

    class customer{
        public int cusId{get;set;}
        public string Name{get;set;}

        public string City {get;set;}

        public double Balance {get;set;}
    }
    class student : IComparable<student>{
       
        public int Sid{get;set;}
        public string Name{get;set;}

        public int Class {get;set;}
        public float Marks{get;set;}

        public int CompareTo(student s)
        {
            return this.Sid.CompareTo(s.Sid);
        }
    }

    class comparer : IComparer<student>
    {
        public int Compare(student x, student y)
        {
            if(x.Marks > y.Marks) return -1;
            else if(x.Marks < y.Marks) return 1;
            else return 0;
        }
    }

    class main{

         public static void Main(){

              List <customer> Customer = new List<customer>();
              customer c1 = new customer(){cusId=101, Name="mahbub",City="Dhaka", Balance=20.99};
                customer c2 = new customer(){cusId=102, Name="ahmed",City="Dhaka", Balance=20.99};
                customer c3 = new customer(){cusId=103, Name="tonmoy",City="Dhaka", Balance=20.99};
                customer c4 = new customer(){cusId=104, Name="tonni",City="Dhaka", Balance=20.99};

             List <student> Student = new List<student>();
              student s1 = new student(){Sid=110, Name="mahbub",Class=11, Marks=10.99f};
                student s2 = new student(){Sid=105, Name="ahmed",Class=12, Marks=30.99f};
                student s3 = new student(){Sid=103, Name="tonmoy",Class=13, Marks=20.99f};
                student s4 = new student(){Sid=101, Name="tonni",Class=14, Marks=60.99f};


              Customer.Add(c1); Customer.Add(c2); Customer.Add(c3); Customer.Add(c4);

              Student.Add(s1); Student.Add(s2); Student.Add(s3); Student.Add(s4);

             /*  foreach(customer i in Customer){
                  Console.WriteLine(i.cusId+"  "+i.Name+"  "+i.City+"  "+i.Balance);
              }*/

              comparer cmp = new comparer();
              Student.Sort(cmp);

               foreach(student i in Student){
                  Console.WriteLine(i.Name+"  "+i.Marks+" "+i.Sid);
              }
         
    }
    }
}
