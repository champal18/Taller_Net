/*
 * Created by SharpDevelop.
 * User: Meisser
 * Date: 18/05/2015
 * Time: 15:48
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
namespace Ejercicio_2b
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tamano = new System.Windows.Forms.GroupBox();
			this.informacion = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.label_invisible = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.tamano.SuspendLayout();
			this.informacion.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(19, 23);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(384, 205);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(148, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Palabra";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(59, 39);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.Value = new decimal(new int[] {
									12,
									0,
									0,
									0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tag = "";
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// tamano
			// 
			this.tamano.Controls.Add(this.numericUpDown1);
			this.tamano.Location = new System.Drawing.Point(210, 282);
			this.tamano.Name = "tamano";
			this.tamano.Size = new System.Drawing.Size(199, 85);
			this.tamano.TabIndex = 2;
			this.tamano.TabStop = false;
			this.tamano.Text = "Tamaño de la letra";
			// 
			// informacion
			// 
			this.informacion.Controls.Add(this.label3);
			this.informacion.Location = new System.Drawing.Point(209, 408);
			this.informacion.Name = "informacion";
			this.informacion.Size = new System.Drawing.Size(200, 100);
			this.informacion.TabIndex = 3;
			this.informacion.TabStop = false;
			this.informacion.Text = "Informacion";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 47);
			this.label3.TabIndex = 0;
			this.label3.Text = "label3";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Location = new System.Drawing.Point(19, 282);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(166, 226);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Controles de movimiento";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(21, 177);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Paso:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(17, 203);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(100, 21);
			this.comboBox1.TabIndex = 7;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(109, 126);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(51, 48);
			this.button4.TabIndex = 6;
			this.button4.Text = "Right";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(56, 126);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(48, 48);
			this.button3.TabIndex = 5;
			this.button3.Text = "Down";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(0, 126);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(49, 48);
			this.button2.TabIndex = 4;
			this.button2.Text = "Left";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(17, 20);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Limitar al panel";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1CheckedChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(56, 71);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(48, 43);
			this.button1.TabIndex = 0;
			this.button1.Text = "Up";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button_upClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(19, 526);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(390, 37);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Timer";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(135, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "label2";
			// 
			// label_invisible
			// 
			this.label_invisible.Location = new System.Drawing.Point(23, 242);
			this.label_invisible.Name = "label_invisible";
			this.label_invisible.Size = new System.Drawing.Size(100, 23);
			this.label_invisible.TabIndex = 7;
			this.label_invisible.Text = "timer_ref";
			this.label_invisible.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(427, 575);
			this.Controls.Add(this.label_invisible);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.informacion);
			this.Controls.Add(this.tamano);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "e_2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.tamano.ResumeLayout(false);
			this.informacion.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label_invisible;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox informacion;
		private System.Windows.Forms.GroupBox tamano;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		

		




	}
}
