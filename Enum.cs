using System;

namespace dddd
{
    enum Days
    {
        monday, 
        tuesday, 
        wednesday, 
        thursday, 
        friday, 
        saturday, 
        sunday 
    }
    enum Month{
        jan, 
        feb, 
        mar, 
        apr, 
        may 
    }

    class  Perimeter {

    public enum shapes{
        circle, square
    }

     public void peri(int val, shapes s1) { 
        if(s1==0) {
            Console.WriteLine("Circumference of the circle is " + 2 * 3.14 * val); 
        }
        else{
            Console.WriteLine("Perimeter of the square is " +   4 * val);
        }
    }
    }
    
    class Program
    {
        static void Main(){
           Perimeter p = new Perimeter();
           p.peri(3,0);

           foreach(object i in Enum.GetValues(typeof(Days))){
               Console.WriteLine(i);
           }
            
        }
    }
}