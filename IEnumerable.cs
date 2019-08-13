using System;
using System.Collections;
using System.Collections.Generic;

namespace dddd
{
    public class student {
        public int Sid{get;set;}
        public string Name{get;set;}

        public int Class {get;set;}
        public float Marks{get;set;}
    }
    
    public class myOwnCOllection : IEnumerable {
        List <student> s = new List<student>();

        public void Add(student obj){
            s.Add(obj);
        }

        public int count{
            get{return s.Count;}
        }

        public student this [int index]{ // indexer
            get{
                return s[index];
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }
    }
    public class Enumerator : IEnumerator
    {
        myOwnCOllection myOwnC;
        int CurrentIndex;
        
        student CurrentStudent;

        public Enumerator(myOwnCOllection mC){
            myOwnC = mC;
            CurrentIndex = -1;
        }
        public object Current {
            get{
                return CurrentStudent;
            }
        }

        public bool MoveNext()
        {
            if(++CurrentIndex >= myOwnC.count)
            return false;
            else
            CurrentStudent = myOwnC[CurrentIndex];
            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
    class main{
       
         public static void Main(){

             myOwnCOllection Student = new myOwnCOllection();
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

            
              foreach(student i in Student){
                  Console.WriteLine(i.Name+"  "+i.Marks+" "+i.Sid);
              }

            
    }
    }
}