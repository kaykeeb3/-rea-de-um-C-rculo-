using System;

namespace desafio1 
{
  
   class Program
   {
     static vold Main(string[] args);
   }
    double raio;
    double area;
    
    Console.WriteLine("Informe o raio do Círculo, no formato 0.0");
    raio = double.Parse(Console.ReadLine());
    
    area = Math.Pow(raio.2)*3,14;
    
    Console.WriteLine("A área do círculo é: {0}",area);
}