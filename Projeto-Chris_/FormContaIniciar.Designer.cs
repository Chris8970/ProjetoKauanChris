namespace Projeto_Chris_
{
    partial class FormContaIniciar
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
            this.label_Info1Form2 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_entrar = new System.Windows.Forms.Button();
            this.button_voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Info1Form2
            // 
            this.label_Info1Form2.AutoSize = true;
            this.label_Info1Form2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold);
            this.label_Info1Form2.Location = new System.Drawing.Point(352, 87);
            this.label_Info1Form2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Info1Form2.Name = "label_Info1Form2";
            this.label_Info1Form2.Size = new System.Drawing.Size(385, 46);
            this.label_Info1Form2.TabIndex = 1;
            this.label_Info1Form2.Text = "Vamos iniciar sessão!";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(392, 171);
            this.textBox_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(305, 36);
            this.textBox_email.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(392, 231);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(305, 36);
            this.textBox_password.TabIndex = 3;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_email.Location = new System.Drawing.Point(296, 171);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(96, 36);
            this.label_email.TabIndex = 4;
            this.label_email.Text = "Email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_password.Location = new System.Drawing.Point(288, 231);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(104, 36);
            this.label_password.TabIndex = 5;
            this.label_password.Text = "Senha:";
            // 
            // button_entrar
            // 
            this.button_entrar.Location = new System.Drawing.Point(446, 297);
            this.button_entrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(195, 49);
            this.button_entrar.TabIndex = 6;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // button_voltar
            // 
            this.button_voltar.Location = new System.Drawing.Point(446, 370);
            this.button_voltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_voltar.Name = "button_voltar";
            this.button_voltar.Size = new System.Drawing.Size(195, 55);
            this.button_voltar.TabIndex = 7;
            this.button_voltar.Text = "Voltar";
            this.button_voltar.UseVisualStyleBackColor = true;
            this.button_voltar.Click += new System.EventHandler(this.button_voltar_Click);
            // 
            // FormContaIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_voltar);
            this.Controls.Add(this.button_entrar);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_Info1Form2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormContaIniciar";
            this.Text = "FormContaIniciar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Info1Form2;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.Button button_voltar;
    }
}