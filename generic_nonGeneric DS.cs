using System;
using System.Collections;
using System.Collections.Generic;
namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            // non-generic
           ArrayList at = new ArrayList();
           at.Add(1); at.Add('a'); at.Add(100); at.Add("mahbub"); at.Add(1); at.Add(1); 
           foreach(object i in at){
               Console.WriteLine(i);
           }
           

           // non-generic
           Hashtable ht = new Hashtable();
            ht.Add("Eid",1001);
            ht.Add("Ename","mahbub");
            ht.Add("Department","se");
            ht.Add("email","ahmed@gmail.com");
            ht.Add("phone",01521109422);
            ht.Add("mid",5001);
            ht.Add("salart",20000);

             foreach (object i in ht.Keys)
            {
                Console.WriteLine(i +" : "+ht[i]);
            }

            foreach (object i in ht.Keys)
            {
                Console.WriteLine(i +"    :::"+i.GetHashCode());
            }
        

           
           
           // Generic type
           List <int> a = new List <int> ();
           a.Add(1);a.Add(2);a.Add(100);a.Add(3);a.Add(4);
           
           foreach(object i in a){
               Console.WriteLine(i);
           }
            

            // Generic type
             Dictionary <string,object> dt = new Dictionary<string,object>();
             dt.Add("id",20161007);
             dt.Add("name","mahbub");
              dt.Add("Department","CSE");
             dt.Add("Year","4th");

             foreach(string i in dt.Keys){
             Console.WriteLine(i +" : "+dt[i]);
           }
               
        }
    }
}
