/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 15:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej4
{
	class Program
	{
		static void Main()
		{
			Auto a=new Auto();
			a.Marca = "Ford";
			Console.WriteLine(a.Marca);
			System.Console.ReadKey();
		}
	}

	class Auto
	{
		private string marca;
		
		public string Marca
		{
			set
			{
				marca=value ;	// CORRECCION M por m en "Marca" -> "marca"
			}
			get
			{
				return marca;
			}
		}
	}
}