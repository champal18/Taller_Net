/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 07:00 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Text;
class Ejemplo
{
	private static void Main(string[] args)
	{
		object[] v = new object[10];
		v[0]=new StringBuilder("Net");
		for(int i=1;i<10;i++){
			v[i]=v[i-1];
		}
		(v[5] as StringBuilder).Insert(0,"Framework .");
		foreach(StringBuilder s in v)
			Console.WriteLine(s);
		//dibuje el estado de la pila y la mem. heap
		//en este punto de la ejecución
		v[5]=new StringBuilder("CSharp");
		foreach(StringBuilder s in v)
			Console.WriteLine(s);
		//dibuje el estado de la pila y la mem. heap
		//en este punto de la ejecución
		Console.ReadLine();
	}
}