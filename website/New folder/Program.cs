// See https://aka.ms/new-console-template for more information

double num01;
double num02;
double num03;

Console.Write("Input a number: ");

num01 = Convert.ToDouble( Console.ReadLine() );

Console.Write("input a second number");

num02 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("input a third number");

num03 = Convert.ToDouble( Console.ReadLine());

double result = (num01 + num02 + num03) /3 ;

Console.WriteLine("the result is " + result);


Console.ReadKey();

