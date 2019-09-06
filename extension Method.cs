using System;


public class class1
{
	  public string Display()  
        {  
            return ("I m in Display");  
        }  
  
        public string Print()  
        {  
            return ("I m in Print");  
        }  
}

public static class extentionClass
{
	public static void addMethod(this class1 obj)
	{
		Console.WriteLine("Hello I m extended method"); 
	}
}
	

public class Program
{
	public static void Main()
	{
		class1 a = new class1();
		Console.WriteLine(a.Display());
		Console.WriteLine(a.Print());
		a.addMethod();
	}
}
