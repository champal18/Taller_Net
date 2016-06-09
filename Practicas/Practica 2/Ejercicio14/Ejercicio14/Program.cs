/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 05/06/2016
 * Time: 06:55 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio14
{
	class Program
	{
		private static void Main(string[] args)
		{
			int[] v1 = new int[] {10,20,30};
			int[] v2 = v1;
			Console.WriteLine(v1==v2);
			v2[0]=15;
			Console.WriteLine(v1==v2);
			v2= new int[] {15,20,30};
			Console.WriteLine(v1==v2);
			Console.ReadLine();
		}
	}
}