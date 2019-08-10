using System;

namespace dddd
{
    public delegate int addnum (int a,int b); // function delegate
    public delegate int subnum (int a,int b);

    class main{

         public static void Main(){
            
            addnum ad = delegate(int a, int b){
                
                return a+b;
            };
           Console.WriteLine(ad(1,2));
 
        
            subnum sb = delegate(int a,int b){
                return a-b;
            };
            Console.WriteLine(sb(10,3));
           
        }
    }
       
}
