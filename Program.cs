﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
 
var number = Convert.ToInt32(Console.ReadLine());
  var number2 = Convert.ToInt32(Console.ReadLine());
            if (number > number2)
                Console.WriteLine(number);
            else 
                Console.WriteLine(number2);