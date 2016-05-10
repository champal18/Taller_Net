/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 09/05/2016
 * Time: 10:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio9
{
	
	
	class Program{ 
		static void Main(){ 
			Taxi t=new Taxi(3); 
			Console.WriteLine(t.marca+ t.pasajeros); 
			Console.ReadKey();
		} 
	} 
	
	class Auto{
		public string marca="Ford"; 
		public Auto(string marca){ 
			this.marca=marca; 
		} 
		public Auto(){ } 
	} 
	
	class Taxi:Auto{
		public int pasajeros; 
		public Taxi(int pasajeros){ 
			this.pasajeros=pasajeros; 
		} 
	}

	
	
	
}