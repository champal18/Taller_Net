/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 09/05/2016
 * Time: 04:37 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
class Program
	{
		public static void Main(string[] args)
		{
			/*
 			A clase1= new A();
			B clase2= new B();
			C clase3= new C();
			D clase4= new D();
			
			clase1.Imprimir();
			clase2.Imprimir();
			clase3.Imprimir();
			clase4.Imprimir();
			*/
			A[] arregloA=new A[4];
			arregloA[0] = new D();
			arregloA[1] = new C();
			arregloA[2] = new D();
			arregloA[3] = new C();
			
			
			for(int i=0;i<arregloA.Length;i++)
			{
				if ((arregloA[i] is D)){}
				else
					arregloA[i].Imprimir();
				
			}

			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	class A
	{
		
		public virtual void Imprimir(){
			Console.WriteLine("Clase A");}
	}
	class B:A
	{
		
		public override void Imprimir(){
			Console.WriteLine("Clase B");
			Console.WriteLine("Clase A");
		}
	}
	class C:B
	{
		public override void Imprimir(){
			Console.WriteLine("Clase C");
			Console.WriteLine("Clase B");
			Console.WriteLine("Clase A");
		}
	}
	class D:C
	{
		public override void Imprimir(){
			Console.WriteLine("Clase D");
			Console.WriteLine("Clase C");
			Console.WriteLine("Clase B");
			Console.WriteLine("Clase A");
		}
	}
}