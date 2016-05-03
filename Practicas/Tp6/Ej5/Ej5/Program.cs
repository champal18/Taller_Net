/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej5
{
	class Program
	{
		public static void Main(string[] args)
		{
			ClaseA a = new ClaseA();
			a.ej();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class ClaseA
	{
		char c;
		static string st;
		void metodo1()
		{
			st="string";
			c='A';
		}

		static void metodo2()
		{
			new ClaseA().c='a';
			st="st2";
			//c='B';
		}
		
		public void ej()
		{
			this.metodo1();
			ClaseA.metodo2();
		}
	}
}