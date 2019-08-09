using System;

namespace dddd
{
   class Singleindexer{
       private string[] val = new string[100];

       public string this [int index]{
           get{
               return val[index];
           }
           set{
               val[index] = value; 
           }
       }
   }
   class MultiIndexer{
       private int[,] val= new int[10,10];

       public int this [int a,int b]{
           get{
               return val[a,b];
           }
           set{
               val[a,b] = value;
           }
       }
   }

   class indexerOverload 
   {
       private string [] arr = new string[10];

       public string this[int index]{
            get { 
                return arr[index]; 
            }
            set { 
                arr[index] = value; 
            }
       }
        public string this[string index]{ //overload
             get { 
            return " C# Indexers Overloading."; // read only mode 
            } 
       }
      
   }
    
    class Program
    {
        static void Main(){
          
            Singleindexer o = new Singleindexer();
            o[0] = "c";
            o[1] = "a";
            o[2] = "b";
            o[3] = "c";
            o[4] = "a";
            o[5] = "b";

            Console.WriteLine("First value = {0}", o[0]); 
        Console.WriteLine("Second value = {0}", o[1]); 
        Console.WriteLine("Third value = {0}", o[2]); 
        Console.WriteLine("First value = {0}", o[3]); 
        Console.WriteLine("Second value = {0}", o[4]); 
        Console.WriteLine("Third value = {0}", o[5]); 

        MultiIndexer index = new MultiIndexer();
        index[0, 0] = 1; 
        index[0, 1] = 2; 
        index[0, 2] = 3; 
          
        // 2nd row 
        index[1, 0] = 4; 
        index[1, 1] = 5; 
        index[1, 2] = 6; 
          
        // 3rd row 
        index[2, 0] = 7; 
        index[2, 1] = 8; 
        index[2, 2] = 9; 
      
        // displaying the values 
        Console.WriteLine("{0}\t{1}\t{2}\n{3}\t{4}\t{5}\n{6}\t{7}\t{8}", 
                                  index[0, 0], index[0, 1], index[0, 2], 
                                  index[1, 0], index[1, 1], index[1, 2],  
                                  index[2, 0], index[2, 1], index[2, 2]); 
        }
    }
}