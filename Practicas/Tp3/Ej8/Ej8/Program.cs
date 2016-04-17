/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 16/4/2016
 * Time: 16:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej8
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				metodo1();
			} catch
			{
				Console.WriteLine("Metodo 1 propago una excepcion no tratada");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void metodo1()
		{
			byte b=255;
			try
			{
				b++;
			} finally {
				Console.WriteLine("Bloque finally");
			}
		}
	}
}