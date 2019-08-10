using System;
using System.Collections.Generic;

namespace dddd
{
    class student {
       
        public int Sid{get;set;}
        public string Name{get;set;}

        public int Class {get;set;}
        public float Marks{get;set;}

    }



    class main{
        public static int comName(student s1, student s2){
            if(s1.Name.Equals(s2.Name)){
                if(s1.Marks < s2.Marks) return 1;
                else if(s1.Marks > s2.Marks) return -1;
                else return 0;
            }
            else{
                return s1.Name.CompareTo(s2.Name);
            }
        }
         public static void Main(){

             List <student> Student = new List<student>();
              student s1 = new student(){Sid=110, Name="mahbub",Class=11, Marks=10.99f};
                student s2 = new student(){Sid=105, Name="ahmed",Class=12, Marks=30.99f};
                student s3 = new student(){Sid=103, Name="tonmoy",Class=13, Marks=20.99f};
                student s4 = new student(){Sid=101, Name="tonni",Class=14, Marks=610.99f};
                student s5 = new student(){Sid=102, Name="tonmoy",Class=13, Marks=220.99f};
                student s6 = new student(){Sid=107, Name="tonni",Class=14, Marks=160.99f};
                student s7 = new student(){Sid=108, Name="tonmoy",Class=13, Marks=210.99f};
                student s8 = new student(){Sid=111, Name="tonni",Class=14, Marks=10.59f};


              Student.Add(s1); Student.Add(s2); Student.Add(s3); Student.Add(s4);
              Student.Add(s5); Student.Add(s6); Student.Add(s7); Student.Add(s8);

            
              Comparison<student> s = new Comparison<student>(comName);

            
              Student.Sort(s);
			  
			  //Anonymous method
              Student.Sort(delegate(student a1, student a2)
              { if(a1.Name.Equals(a2.Name)){
                if(a1.Marks < a2.Marks) return 1;
                else if(a1.Marks > a2.Marks) return -1;
                else return 0;
            }
            else{
                return s1.Name.CompareTo(s2.Name);
            }});
			
			// lambda expresion
            Student.Sort(( a1,  a2) =>
              { if(a1.Name.Equals(a2.Name)){
                if(a1.Marks < a2.Marks) return 1;
                else if(a1.Marks > a2.Marks) return -1;
                else return 0;
            }
            else{
                return s1.Name.CompareTo(s2.Name);
            }});
               foreach(student i in Student){
                  Console.WriteLine(i.Name+"  "+i.Marks+" "+i.Sid);
              }
         
    }
    }
}