﻿/*
 * Created by SharpDevelop.
 * User: Facu
 * Date: 26/06/2016
 * Time: 07:55 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio1
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(381, 30);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(336, 192);
			this.dataGridView1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Location = new System.Drawing.Point(12, 30);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 117);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nueva fila";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Edad";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nombre";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(66, 82);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(191, 20);
			this.textBox3.TabIndex = 2;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(67, 56);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(191, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 30);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(191, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(291, 86);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Agregar -->";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(381, 241);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Borrar fila ...";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(588, 241);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(129, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Borrar todas las filas";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(765, 303);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MainForm";
			this.Text = "Ejercicio1";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		
		
	}
}
