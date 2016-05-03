/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 3/5/2016
 * Time: 18:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(new Registro().Id);
			Console.WriteLine(new Registro().Id);
			Console.WriteLine(new Registro().Id);
			Console.WriteLine(new Registro().Id);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	class Registro
	{
		private int idRegistro;
		private static int nro = 0;
		
		public Registro()
		{
			Registro.nro++;
			this.idRegistro = nro;
		}
		
		public int Id
		{
			get
			{
				return this.idRegistro;
			}
		}
	}
}