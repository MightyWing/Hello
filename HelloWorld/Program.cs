﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage()); 
        }
        public static string CreateMessage()
        {
            return "Hello World!";
        }
    }
}
