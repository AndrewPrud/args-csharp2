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
        Console.Write("Your input was: ");
        foreach(int thing in list){
            Console.Write(thing + " ");
        }
        

    }
}