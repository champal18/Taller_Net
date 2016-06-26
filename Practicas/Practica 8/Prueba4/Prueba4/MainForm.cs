/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 26/06/2016
 * Time: 05:31 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba4
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
		
		void NuevaVentanaToolStripMenuItemClick(object sender, EventArgs e)
		{
			(new MainForm()).ShowDialog();
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
