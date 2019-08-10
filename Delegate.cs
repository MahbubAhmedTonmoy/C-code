using System;

namespace dddd
{
    public delegate bool predicte(); // predication type delegate

    public delegate void a(int a); // action delegate
    public delegate int addnum (int a,int b); // function delegate
    public delegate int subnum (int a,int b);

    public delegate int calculator (int a,int b); // use for addnum, subnum in one delegate--multicast 
    public delegate void rectDelegate(double height, double width);

  class Program
    {

        public int add(int a,int b){
            return (a+b);
        }
        public int sub(int a,int b){
            return (a-b);
        }

        public void perimeter(double height, double width) 
        { 
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height)); 
        }
        public void area(double height, double width) 
        { 
            Console.WriteLine("area is: {0} ", (width * height)); 
        } 
    }

    class main{

         public static void Main(){
            
            Program p = new Program();

            addnum ad = new addnum(p.add);
            int a = ad(10,20);  //ad.Invoke(10,20)
            //Console.WriteLine(a);

        
            subnum sb = new subnum(p.sub);
           
           // Console.WriteLine(  sb(10,20));


            calculator c = new calculator(p.add);
            int ans = c.Invoke(12,23);
            Console.WriteLine(ans);
            c = c+ p.sub;
            int ans2 = c.Invoke(1,1);
            Console.WriteLine(ans2);

            //multicast delegate
            rectDelegate rd = new rectDelegate(p.area);
            rd += p.perimeter;
            rd.Invoke(10,4);

        }
    }
       
}
