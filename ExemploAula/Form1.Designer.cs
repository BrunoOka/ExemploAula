namespace ExemploAula
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
