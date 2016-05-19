/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 19/5/2016
 * Time: 16:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej11
{
	delegate int tipoDelegado();
	class Program
	{
		public static void Main()
		{
			tipoDelegado delegado;
			delegado=new tipoDelegado(devuelveUno);
			delegado+=new tipoDelegado(devuelveDos);
			int i= delegado();
			Console.WriteLine(i);
			Console.ReadKey();
		}
		
		static int devuelveUno()
		{
			Console.WriteLine("Ejecutando devuelveUno()");
			return 1;
		}
		
		static int devuelveDos()
		{
			Console.WriteLine("Ejecutando devuelveDos()");
			return 2;
		}
	}
}