/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 26/06/2016
 * Time: 06:07 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prueba6
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
			foreach(TabPage tp in tabControl1.TabPages)
				tabControl1.TabPages.Remove(tp);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Desea agregar nueva pestaña",
			              "Confirmación",MessageBoxButtons.YesNo)==DialogResult.Yes){
				MonthCalendar calendario = new MonthCalendar();
				calendario.Dock=DockStyle.Fill;
				calendario.TodayDate=DateTime.Today.AddDays(tabControl1.TabPages.Count);
				TabPage tp=new TabPage(calendario.TodayDate.ToString("dd/MM"));
				tp.Controls.Add(calendario);
				tabControl1.TabPages.Add(tp);
			}
		}
	}
}
