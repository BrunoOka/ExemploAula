﻿namespace ExemploAula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbllogin = new Label();
            lblusuario = new Label();
            lblsenha = new Label();
            txtusuario = new TextBox();
            txtsenha = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Font = new Font("Segoe UI", 30F);
            lbllogin.Location = new Point(323, 61);
            lbllogin.Margin = new Padding(7, 0, 3, 0);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(113, 54);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "login";
            lbllogin.Click += label1_Click;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Font = new Font("Segoe UI", 20F);
            lblusuario.Location = new Point(145, 145);
            lblusuario.Margin = new Padding(7, 0, 3, 0);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(104, 37);
            lblusuario.TabIndex = 1;
            lblusuario.Text = "usuario";
            lblusuario.Click += label1_Click_1;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI", 20F);
            lblsenha.Location = new Point(145, 199);
            lblsenha.Margin = new Padding(7, 0, 3, 0);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(86, 37);
            lblsenha.TabIndex = 2;
            lblsenha.Text = "senha";
            // 
            // txtusuario
            // 
            txtusuario.Location = new Point(414, 159);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(100, 23);
            txtusuario.TabIndex = 3;
            // 
            // txtsenha
            // 
            txtsenha.Location = new Point(414, 213);
            txtsenha.Name = "txtsenha";
            txtsenha.PasswordChar = '*';
            txtsenha.Size = new Size(100, 23);
            txtsenha.TabIndex = 4;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(323, 298);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(75, 23);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(txtsenha);
            Controls.Add(txtusuario);
            Controls.Add(lblsenha);
            Controls.Add(lblusuario);
            Controls.Add(lbllogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblusuario;
        private Label lblsenha;
        private TextBox txtusuario;
        private TextBox txtsenha;
        private Button btnlogin;
    }
}
