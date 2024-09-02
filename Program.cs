/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
     Console.WriteLine("-Student grade application-");
    Console.WriteLine("Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("English: ");
    double eng = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Math: ");
    double mat = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Science: ");
    double sci = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Filipino: ");
    double fil = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("History: ");
    double his = Convert.ToDouble(Console.ReadLine());

    double sum = (eng + mat + sci + fil + his) / 5;
    Console.WriteLine("The general average is: " + sum);
    if (sum >= 75)
    {
        Console.WriteLine("You Passed!");
    }
    else
    {
        Console.WriteLine("You failed!");
    }

  }
}