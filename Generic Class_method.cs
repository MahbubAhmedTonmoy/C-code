using System;
using System.Collections;
using System.Collections.Generic;
namespace cs
{
    class Program
    {

        //Gnerics class
        class calculator<T>{
            public void Add(T a, T b){
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x + y);
            }
            public void Sub(T a, T b){
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x - y);
            }
            public void Mul(T a, T b){
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x * y);
            }
            public void div(T a, T b){
                dynamic x = a;
                dynamic y = b;
                if(y != 0){
                    Console.WriteLine(x / y);
                }
                
            }
        }


        //Gneric method
        class calculate{
            public void Add<T>(T a, T b){
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x + y);
            }
            public void Sub<T>(T a, T b){
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x - y);
            }
            public void Mul<T>(T a, T b){
                dynamic x = a;
                dynamic y = b;
                Console.WriteLine(x * y);
            }
            public void div<T>(T a, T b){
                dynamic x = a;
                dynamic y = b;
                if(y != 0){
                    Console.WriteLine(x / y);
                }
                
            }
        }
        class test{

              static void Main(string[] args)
        {
          
           calculator <int> c = new calculator<int>();
           c.Add(2,4);
             calculator <float> ca = new calculator<float>();
            ca.Add(2.90f,4f);
             c.Sub(2,4);
        }
        }
      
    }
}
