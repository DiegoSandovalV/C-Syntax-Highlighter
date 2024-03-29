using System;


class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4, 5};
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i] + "even");
            }
            else
            {
                Console.WriteLine(numbers[i] + "odd");
            }
        }

        Console.WriteLine();
        bool boolExample = true;

        string message = "Hello, world";
        for (int i = 0; i < message.Length; i++)
        {
            Console.Write(message[i] + " ");
        }
        Console.WriteLine();

        MyClass myObject = new MyClass();
        myObject.MyMethod();
    }
}

class MyClass
{
    public void MyMethod()
    {   try
        {
            int x = 5;
            int y = 0;
            int z = x / y;
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("DivideByZeroException caught!");
        }
        finally
        {
            Console.WriteLine("This a block.");
        }

        myObject is MyClass;
    }
}

