/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 19/5/2016
 * Time: 16:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej10
{
	delegate void tipoDelegado();
	
	class Program
	{
		public static void Main()
		{
			tipoDelegado delegado;
			Objeto o=new Objeto();
			delegado = o.getDelegado("999");
			delegado();
			delegado = o.getDelegado("123");
			delegado();
			Console.ReadKey();
		}
	}
	
	class Objeto
	{
		private void metodoPrivado()
		{
			Console.WriteLine("método privado del objeto");
		}
		
		public void metodoPublico()
		{
			Console.WriteLine("método público del objeto");
		}
		
		public tipoDelegado getDelegado(string clave)
		{
			if (clave=="123")
				return new tipoDelegado(metodoPrivado);
			else
				return new tipoDelegado(metodoPublico);
		}
	}
}