using System;
using System.Collections;

class Program{
    static void Main(String[] args){
        ArrayList list = new ArrayList();
        string input;
        Console.WriteLine("Input: ");
        input = Console.ReadLine();
        string[] inputs = input.Split(" ");
        foreach(string item in inputs){
            list.Add(Int32.Parse(item));
        }
        foreach(int thing in list){
            Console.Write(thing);
        }
        
        foreach(int evens in list){
            if (evens % 2 == 0){
                Console.WriteLine(evens);
            }
        }
        int sum = 0;
        foreach(int add in List){
            sum += add;
        }
        Console.WriteLine(sum);



    }
}