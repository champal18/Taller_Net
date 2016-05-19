/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 17/5/2016
 * Time: 15:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej9
{
	delegate void TrabajandoEventHandler();
	class Program
	{
		private static TrabajandoEventHandler delegado1,delegado2,delegado3;
		public static void Main()
		{
			// Inciso A
			Console.WriteLine("Inciso A: (ABC-BCD)");
			delegado1 += new TrabajandoEventHandler(A);
			delegado1 += new TrabajandoEventHandler(B);
			delegado1 += new TrabajandoEventHandler(C);
			
			delegado2 += new TrabajandoEventHandler(B);
			delegado2 += new TrabajandoEventHandler(C);
			delegado2 += new TrabajandoEventHandler(D);
			
			delegado3 = delegado1-delegado2;
			
			Trabajador o=new Trabajador();
			o.Trabajando = delegado3;
			o.Trabajar();
			
			// Inciso B
			Console.WriteLine("\nInciso B: (ABCD-AC)");
			delegado1 += new TrabajandoEventHandler(D);
			
			delegado2 = delegado2-delegado2;
			delegado2 += new TrabajandoEventHandler(A);
			delegado2 += new TrabajandoEventHandler(C);
			
			delegado3 = delegado1-delegado2;
			
			o=new Trabajador();
			o.Trabajando = delegado3;
			o.Trabajar();
			
			// Inciso C
			Console.WriteLine("\nInciso C: (ABCD-ABC)");
			
			delegado2 = delegado2-delegado2;
			delegado2 += new TrabajandoEventHandler(A);
			delegado2 += new TrabajandoEventHandler(B);
			delegado2 += new TrabajandoEventHandler(C);

			delegado3 = delegado1-delegado2;
			
			o=new Trabajador();
			o.Trabajando = delegado3;
			o.Trabajar();
			
			// Inciso D
			Console.WriteLine("\nInciso D: (ABCD-BC)");
			
			delegado2 = delegado2-delegado2;
			delegado2 += new TrabajandoEventHandler(B);
			delegado2 += new TrabajandoEventHandler(C);
			
			delegado3 = delegado1-delegado2;
			
			o=new Trabajador();
			o.Trabajando = delegado3;
			o.Trabajar();
			
			Console.ReadKey(true);
		}
		
		private static void A()
		{
			Console.WriteLine("Ejecutando A");
		}
	
		private static void B()
		{
			Console.WriteLine("Ejecutando B");
		}
		
		private static void C()
		{
			Console.WriteLine("Ejecutando C");
		}
		
		private static void D()
		{
			Console.WriteLine("Ejecutando D");
		}
	}
	
	class Trabajador
	{
		public TrabajandoEventHandler Trabajando;
		public void Trabajar()
		{
			if (Trabajando != null) Trabajando();
			//realiza algún trabajo
			Console.WriteLine("Trabajo concluido");
		}
	}
}