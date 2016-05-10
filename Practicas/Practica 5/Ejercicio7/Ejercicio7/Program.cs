/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 09/05/2016
 * Time: 10:04 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		static void Main(){ 
			Auto a=new Auto(); 
			check(a); 
			a=new Taxi(); 
			check(a); 
			System.Console.ReadLine(); 
		} 
		static void check(Auto a){
				if (a is Taxi){
					Console.WriteLine("Es un taxi");
				}else{
					if (a is Auto) Console.WriteLine("Es un auto no es un taxi");
				}
			}

	}
	
	
	class Auto{ 
		protected double velocidad; 
		
		public virtual void acelerar(){
			Console.WriteLine("Velocidad = {0}", velocidad+=10); 
		} 
	} 
	class Taxi:Auto{ 
		
		public override void acelerar()
		{ 
			Console.WriteLine("Velocidad = {0}", velocidad+=5); 
		} 
	} 
	
}