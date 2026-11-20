namespace Projeto_Chris_
{
    partial class CriarConta
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
            this.button_voltar2 = new System.Windows.Forms.Button();
            this.label_Info1Form2 = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_email2 = new System.Windows.Forms.TextBox();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.button_criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_voltar2
            // 
            this.button_voltar2.Location = new System.Drawing.Point(482, 351);
            this.button_voltar2.Margin = new System.Windows.Forms.Padding(4);
            this.button_voltar2.Name = "button_voltar2";
            this.button_voltar2.Size = new System.Drawing.Size(195, 49);
            this.button_voltar2.TabIndex = 0;
            this.button_voltar2.Text = "Voltar";
            this.button_voltar2.UseVisualStyleBackColor = true;
            this.button_voltar2.Click += new System.EventHandler(this.button_voltar2_Click);
            // 
            // label_Info1Form2
            // 
            this.label_Info1Form2.AutoSize = true;
            this.label_Info1Form2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info1Form2.ForeColor = System.Drawing.Color.Black;
            this.label_Info1Form2.Location = new System.Drawing.Point(328, 75);
            this.label_Info1Form2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Info1Form2.Name = "label_Info1Form2";
            this.label_Info1Form2.Size = new System.Drawing.Size(429, 46);
            this.label_Info1Form2.TabIndex = 2;
            this.label_Info1Form2.Text = "Vamos criar uma conta!";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(330, 180);
            this.label_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(96, 36);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "Email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Trebuchet MS", 16.2F, System.Drawing.FontStyle.Bold);
            this.label_password.Location = new System.Drawing.Point(322, 224);
            this.label_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(104, 36);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Senha:";
            this.label_password.Click += new System.EventHandler(this.label_password_Click);
            // 
            // textBox_email2
            // 
            this.textBox_email2.Location = new System.Drawing.Point(427, 180);
            this.textBox_email2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_email2.Multiline = true;
            this.textBox_email2.Name = "textBox_email2";
            this.textBox_email2.Size = new System.Drawing.Size(305, 36);
            this.textBox_email2.TabIndex = 7;
            // 
            // textBox_password2
            // 
            this.textBox_password2.Location = new System.Drawing.Point(427, 224);
            this.textBox_password2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_password2.Multiline = true;
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(305, 36);
            this.textBox_password2.TabIndex = 8;
            // 
            // button_criar
            // 
            this.button_criar.Location = new System.Drawing.Point(482, 285);
            this.button_criar.Margin = new System.Windows.Forms.Padding(4);
            this.button_criar.Name = "button_criar";
            this.button_criar.Size = new System.Drawing.Size(195, 49);
            this.button_criar.TabIndex = 9;
            this.button_criar.Text = "Criar ";
            this.button_criar.UseVisualStyleBackColor = true;
            this.button_criar.Click += new System.EventHandler(this.button_criar_Click);
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_criar);
            this.Controls.Add(this.textBox_password2);
            this.Controls.Add(this.textBox_email2);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_Info1Form2);
            this.Controls.Add(this.button_voltar2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.Load += new System.EventHandler(this.CriarConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_voltar2;
        private System.Windows.Forms.Label label_Info1Form2;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_email2;
        private System.Windows.Forms.TextBox textBox_password2;
        private System.Windows.Forms.Button button_criar;
    }
}