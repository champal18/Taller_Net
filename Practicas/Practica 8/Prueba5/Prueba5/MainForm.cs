/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 26/06/2016
 * Time: 05:42 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba5
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
		
		void MainFormLoad(object sender, EventArgs e)
		{
			listBox1.Dock=DockStyle.Fill;
			textBox1.Dock=DockStyle.Fill;
			textBox1.Multiline=true;
			System.IO.DirectoryInfo dir= new System.IO.DirectoryInfo(@"C:\windows");
			listBox1.Items.AddRange(dir.GetFiles("*.*"));
		}
	}
}
