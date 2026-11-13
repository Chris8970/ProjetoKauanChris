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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_criar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_voltar2
            // 
            this.button_voltar2.Location = new System.Drawing.Point(322, 326);
            this.button_voltar2.Name = "button_voltar2";
            this.button_voltar2.Size = new System.Drawing.Size(146, 40);
            this.button_voltar2.TabIndex = 0;
            this.button_voltar2.Text = "Voltar";
            this.button_voltar2.UseVisualStyleBackColor = true;
            this.button_voltar2.Click += new System.EventHandler(this.button_voltar2_Click);
            // 
            // label_Info1Form2
            // 
            this.label_Info1Form2.AutoSize = true;
            this.label_Info1Form2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info1Form2.Location = new System.Drawing.Point(257, 97);
            this.label_Info1Form2.Name = "label_Info1Form2";
            this.label_Info1Form2.Size = new System.Drawing.Size(253, 28);
            this.label_Info1Form2.TabIndex = 2;
            this.label_Info1Form2.Text = "Vamos criar uma conta!";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(249, 160);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(66, 25);
            this.label_email.TabIndex = 5;
            this.label_email.Text = "Email:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(249, 210);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(74, 25);
            this.label_password.TabIndex = 6;
            this.label_password.Text = "Senha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(322, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(322, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button_criar
            // 
            this.button_criar.Location = new System.Drawing.Point(322, 267);
            this.button_criar.Name = "button_criar";
            this.button_criar.Size = new System.Drawing.Size(146, 40);
            this.button_criar.TabIndex = 9;
            this.button_criar.Text = "Criar ";
            this.button_criar.UseVisualStyleBackColor = true;
            // 
            // CriarConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_criar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_Info1Form2);
            this.Controls.Add(this.button_voltar2);
            this.Name = "CriarConta";
            this.Text = "CriarConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_voltar2;
        private System.Windows.Forms.Label label_Info1Form2;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_criar;
    }
}