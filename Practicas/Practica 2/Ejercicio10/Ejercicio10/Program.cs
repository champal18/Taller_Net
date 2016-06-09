/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 06:19 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;

namespace Ejercicio10
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			string string1;
			string string2;
			
			DateTime startTime;
			DateTime endTime;
			TimeSpan totalTime;
			
			DateTime startTime2;
			DateTime endTime2;
			TimeSpan totalTime2;
			
			// Clase String
			startTime = DateTime.Now;	// Hora antes de ejecutar
			string1=ejemploStrings1();
			endTime = DateTime.Now;		// Hora después de ejecutar
			totalTime = endTime.Subtract(startTime);	// Tiempo neto de ejecución
			//Console.WriteLine("String 1: {0}",string1);
			Console.WriteLine("Tiempo ejecución con String: {0}",totalTime.ToString());	
			
			// Clase StringBuilder
			startTime2 = DateTime.Now;	// Hora antes de ejecutar
			string2=ejemploStringBuilder1();
			endTime2 = DateTime.Now;		// Hora después de ejecutar
			totalTime2= endTime2.Subtract(startTime2);	// Tiempo neto de ejecución
			//Console.WriteLine("StringBuilder1: {0}",string2);
			Console.WriteLine("Tiempo ejecución con StringBuilder: {0}",totalTime2.ToString());
			
		
			
			Console.ReadKey(true);
		}
		
		
		// Concatena strings con el signo +
		public static string ejemploStrings1()
		{
			string test = string.Empty;
            for (int i = 0; i < 1000; i++)
            {
                test += i;
            }
            return test;
		}


		// Usa la clase StringBuilder para concatenar
		public static string ejemploStringBuilder1()
		{
			StringBuilder test1 = new StringBuilder();
            for (int i = 0; i < 1000; i++)
            {
                test1.Append(i);
            }
            return test1.ToString();
		}
	}
}