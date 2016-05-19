/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 19/5/2016
 * Time: 16:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej12
{
	delegate int tipoDelegado();
	class Program
	{
		public static void Main()
		{
			tipoDelegado delegado,aux;
			bool ok = true;
			
			aux = new tipoDelegado(devuelveUno);
			delegado=new tipoDelegado(devuelveUno);
			delegado+=new tipoDelegado(devuelveDos);
			System.Delegate[] listaDelegados=delegado.GetInvocationList();
			foreach(tipoDelegado del in listaDelegados)
			{
				if(ok)
				{
					aux = del;
					ok = false;					
				}
				int i=del();
				Console.WriteLine(i);
			}
			
			Console.WriteLine("Prueba: \n");
			int j = aux();
			Console.WriteLine(j);
			
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