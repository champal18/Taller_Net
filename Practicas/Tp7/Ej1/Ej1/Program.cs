/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 9/5/2016
 * Time: 15:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej1
{
	delegate void TrabajandoEventHandler();
	
	class Program
	{
		public static void Main()
		{
			Trabajador o=new Trabajador();
			//o.Trabajando = new TrabajandoEventHandler(F);
			
			//Ej3
			//o.Trabajando += new TrabajandoEventHandler(G);
			
			//Ej4
			//o.Trabajando += new TrabajandoEventHandler(G);
			//o.Trabajando += new TrabajandoEventHandler(G);
			
			//Ej5
			//o.Trabajando = o.Trabajando + new TrabajandoEventHandler(G);
			//o.Trabajando = new TrabajandoEventHandler(G);
			
			//Ej6
			//o.Trabajar();
			//Console.WriteLine("-------------------------");
			
			//Console.WriteLine("Todo listo para comenzar");
			//o.Trabajando -= new TrabajandoEventHandler(F);
			//o.Trabajando += new TrabajandoEventHandler(G);
			//o.Trabajando-=G;
			
			//Ej7
			o.Trabajando -= new TrabajandoEventHandler(F);
			
			o.Trabajar();
			Console.ReadKey(true);
		}
	
		private static void F()
		{
			Console.WriteLine("El trabajo se ha iniciado");
		}
		
		private static void G()
		{
			Console.WriteLine("Ejecutando el metodo G");
		}
	}
	
	class Trabajador
	{
		public TrabajandoEventHandler Trabajando;
		
		public void Trabajar()
		{
			//Ej2
			if(Trabajando != null)
				Trabajando();
			//realiza algún trabajo
			Console.WriteLine("Trabajo concluido");
		}
	}
}