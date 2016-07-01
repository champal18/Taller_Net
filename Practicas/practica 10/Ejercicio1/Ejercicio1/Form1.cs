/*
 * Created by SharpDevelop.
 * User: Labrune-Fuentes
 * Date: 28/06/2016
 * Time: 10:35 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		int cantidad;
		public int eliminar;
		
		public Form1(int cantFilas)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			cantidad=cantFilas;
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			for(int i=0;i<cantidad;i++) // cargo el combo box
				comboBox1.Items.Add("Fila"+ i);
		
			comboBox1.SelectedIndex = 0;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			eliminar=comboBox1.SelectedIndex;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			
		}
	}
}
