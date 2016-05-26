/*
 * Created by SharpDevelop.
 * User: Champal
 * Date: 26/5/2016
 * Time: 18:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace Ej1
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		
		int intervalo;
		ArrayList file_path;
		Timer tmr;
		int index;
		
		public Form1(int intervalo, ArrayList files)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.intervalo = intervalo;
			this.file_path = files;
			
			this.Bounds = Screen.PrimaryScreen.Bounds;
			this.pictureBox1.Bounds = Screen.PrimaryScreen.Bounds;
			
			index = 0;
			tmr = new Timer();
			tmr.Interval = intervalo*1000;
			tmr.Start();
			
			this.pictureBox1.Image = Image.FromFile((string)file_path[index]);
			tmr.Tick += tmr_Tick;
				
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void VisualizacionToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		private void Form_KeyDown(object sender, KeyEventArgs e)
		{
		    if (e.KeyCode == Keys.Escape)
		    {
		        this.Close();
		    }
		}
		
		void tmr_Tick(object sender, EventArgs e)
		 {
			if(index<(file_path.Count-1))
				index++;
			else
				index = 0;
		    //after 3 sec stop the timer
		    tmr.Stop();
		    tmr.Start();
		    this.pictureBox1.Image = Image.FromFile((string)file_path[index]);
		 }
	}
}
