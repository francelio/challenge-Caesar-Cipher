namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtDadosCasas = new System.Windows.Forms.TextBox();
			this.txtDadosResumo = new System.Windows.Forms.TextBox();
			this.txtDadosToken = new System.Windows.Forms.TextBox();
			this.txtDadosCifrado = new System.Windows.Forms.TextBox();
			this.txtDadosDecifrado = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(10, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(785, 30);
			this.button1.TabIndex = 5;
			this.button1.Text = "Obter informações";
			this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Número de casas:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Token:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Cifrado:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 231);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 9;
			this.label4.Text = "Decifrado:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 334);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(148, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "Resumo Criptografico:";
			// 
			// txtDadosCasas
			// 
			this.txtDadosCasas.Location = new System.Drawing.Point(141, 51);
			this.txtDadosCasas.Name = "txtDadosCasas";
			this.txtDadosCasas.ReadOnly = true;
			this.txtDadosCasas.Size = new System.Drawing.Size(138, 22);
			this.txtDadosCasas.TabIndex = 11;
			// 
			// txtDadosResumo
			// 
			this.txtDadosResumo.Location = new System.Drawing.Point(15, 354);
			this.txtDadosResumo.Multiline = true;
			this.txtDadosResumo.Name = "txtDadosResumo";
			this.txtDadosResumo.ReadOnly = true;
			this.txtDadosResumo.Size = new System.Drawing.Size(780, 80);
			this.txtDadosResumo.TabIndex = 12;
			// 
			// txtDadosToken
			// 
			this.txtDadosToken.Location = new System.Drawing.Point(141, 92);
			this.txtDadosToken.Name = "txtDadosToken";
			this.txtDadosToken.ReadOnly = true;
			this.txtDadosToken.Size = new System.Drawing.Size(649, 22);
			this.txtDadosToken.TabIndex = 13;
			// 
			// txtDadosCifrado
			// 
			this.txtDadosCifrado.Location = new System.Drawing.Point(15, 148);
			this.txtDadosCifrado.Multiline = true;
			this.txtDadosCifrado.Name = "txtDadosCifrado";
			this.txtDadosCifrado.ReadOnly = true;
			this.txtDadosCifrado.Size = new System.Drawing.Size(780, 80);
			this.txtDadosCifrado.TabIndex = 14;
			// 
			// txtDadosDecifrado
			// 
			this.txtDadosDecifrado.Location = new System.Drawing.Point(15, 251);
			this.txtDadosDecifrado.Multiline = true;
			this.txtDadosDecifrado.Name = "txtDadosDecifrado";
			this.txtDadosDecifrado.ReadOnly = true;
			this.txtDadosDecifrado.Size = new System.Drawing.Size(780, 80);
			this.txtDadosDecifrado.TabIndex = 15;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(842, 752);
			this.Controls.Add(this.txtDadosDecifrado);
			this.Controls.Add(this.txtDadosCifrado);
			this.Controls.Add(this.txtDadosToken);
			this.Controls.Add(this.txtDadosResumo);
			this.Controls.Add(this.txtDadosCasas);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDadosCasas;
		private System.Windows.Forms.TextBox txtDadosResumo;
		private System.Windows.Forms.TextBox txtDadosToken;
		private System.Windows.Forms.TextBox txtDadosCifrado;
		private System.Windows.Forms.TextBox txtDadosDecifrado;
	}
}

