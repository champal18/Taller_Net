/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 07:36 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio19
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese un número");
			int numero = int.Parse(Console.ReadLine());
			
			int resultado = factorial(numero);
			int resultado2 = factorial_recursivo(numero);
			
			Console.WriteLine("Factorial: {0}",resultado);
			Console.WriteLine("Factorial con algoritmo recursivo: {0}",resultado2);
			Console.ReadKey(true);
		}
		
		public static int factorial(int numero){
			int i;
			int resultado = numero;
			
			for(i=1;i<numero;i++){
				resultado = resultado*i;
			}
			
			return resultado;
		}
		
		
		public static int factorial_recursivo(int numero){
			int resultado;
			if (numero<2){
				resultado = 1;
			}
			else{
				resultado = numero * factorial_recursivo(numero-1);
			}
			
			return resultado;
		}
		
	}
}