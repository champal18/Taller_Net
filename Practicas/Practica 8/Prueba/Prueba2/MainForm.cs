/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 26/06/2016
 * Time: 04:50 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			label1.Text=System.DateTime.Now.ToString("HH:mm:ss:fff");
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (timer1.Enabled==true)
				timer1.Enabled=false;
			else
				timer1.Enabled=true;
		}
	}
}
