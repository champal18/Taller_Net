/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 08:11 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio21
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Posición de la serie de Fibonacci: ");
			int numero = int.Parse(Console.ReadLine());
			
			int resultado = fibonacci(numero);
			
			Console.Write("Resultado: {0} ",resultado);
			Console.ReadKey(true);
		}
		
		
		public static int fibonacci(int numero){
			if (numero<2){
				return numero;
			}
			else{
				return fibonacci(numero-1) + fibonacci (numero-2);
			}
		}
	}
}