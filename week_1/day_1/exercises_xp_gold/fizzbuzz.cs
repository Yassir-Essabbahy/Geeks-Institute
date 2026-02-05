using System;

class Exercise1
{
    public static void Run()
    {
        Console.WriteLine("Enter A Number Between 0 and 100 : ");
        int num = int.Parse(Console.ReadLine());
                    if(number %3 == 0 && number %5 == 0){
                Console.WriteLine("FizzBuzz");
            }
            else if(number %3 == 0 && number%5 != 0){
                Console.WriteLine("Fizz");
            }
            else if(number %3 != 0 && number%5 == 0){
                Console.WriteLine("Buzz");
            
        }
    }
}
