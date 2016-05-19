/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 9/5/2016
 * Time: 16:55
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ej8
{
delegate void TrabajandoEventHandler();
class Program
{
	private static TrabajandoEventHandler delegado1,delegado2;
	public static void Main()
	{
		delegado1 += new TrabajandoEventHandler(F);
		delegado1 += new TrabajandoEventHandler(G);
		delegado2 += new TrabajandoEventHandler(F);
		delegado2 += new TrabajandoEventHandler(G);
		Trabajador o=new Trabajador();
		o.Trabajando = delegado1+delegado2;
		o.Trabajar();
		Console.ReadKey(true);
	}
	
	private static void F()
	{
		Console.WriteLine("El trabajo se ha iniciado");
	}

	private static void G()
	{
		Console.WriteLine("Ejecutando el método G");
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