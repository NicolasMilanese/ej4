using System;
namespace ejercicio
{
class Program
{
static void Main (string[] args)
{
Console.Clear ();
int num1,num2,resultado;

Console.WriteLine ("ingrese primer numero para sumar");
string numero1 = Console.ReadLine();
num1 = Convert.ToInt32(numero1);
Console.WriteLine ("ingrese segundo numero a sumar");
string numero2= Console.ReadLine();
num2= Convert.ToInt32(numero2);
resultado=num1+num2;
Console.WriteLine ("el resultado es " + resultado);
}

}

}
