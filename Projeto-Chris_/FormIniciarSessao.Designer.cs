namespace Projeto_Chris_
{
    partial class FormTelaDeContas
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
            this.button_iniciarSessaoForm2 = new System.Windows.Forms.Button();
            this.button_criarContaForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Info1Form2
            // 
            this.label_Info1Form2.AutoSize = true;
            this.label_Info1Form2.Font = new System.Drawing.Font("Trebuchet MS", 22.2F, System.Drawing.FontStyle.Bold);
            this.label_Info1Form2.Location = new System.Drawing.Point(301, 132);
            this.label_Info1Form2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Info1Form2.Name = "label_Info1Form2";
            this.label_Info1Form2.Size = new System.Drawing.Size(445, 46);
            this.label_Info1Form2.TabIndex = 0;
            this.label_Info1Form2.Text = "Bem vindo (a)! StundBus";
            // 
            // button_iniciarSessaoForm2
            // 
            this.button_iniciarSessaoForm2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciarSessaoForm2.Location = new System.Drawing.Point(387, 228);
            this.button_iniciarSessaoForm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_iniciarSessaoForm2.Name = "button_iniciarSessaoForm2";
            this.button_iniciarSessaoForm2.Size = new System.Drawing.Size(260, 47);
            this.button_iniciarSessaoForm2.TabIndex = 1;
            this.button_iniciarSessaoForm2.Text = "Iniciar Sessão";
            this.button_iniciarSessaoForm2.UseVisualStyleBackColor = true;
            this.button_iniciarSessaoForm2.Click += new System.EventHandler(this.button_iniciarSessaoForm2_Click);
            // 
            // button_criarContaForm2
            // 
            this.button_criarContaForm2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_criarContaForm2.Location = new System.Drawing.Point(387, 313);
            this.button_criarContaForm2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_criarContaForm2.Name = "button_criarContaForm2";
            this.button_criarContaForm2.Size = new System.Drawing.Size(260, 47);
            this.button_criarContaForm2.TabIndex = 2;
            this.button_criarContaForm2.Text = "Criar Conta";
            this.button_criarContaForm2.UseVisualStyleBackColor = true;
            this.button_criarContaForm2.Click += new System.EventHandler(this.button_criarContaForm2_Click);
            // 
            // FormTelaDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button_criarContaForm2);
            this.Controls.Add(this.button_iniciarSessaoForm2);
            this.Controls.Add(this.label_Info1Form2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTelaDeContas";
            this.Text = "FormIniciarSessao";
            this.Load += new System.EventHandler(this.FormTelaDeContas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Info1Form2;
        private System.Windows.Forms.Button button_iniciarSessaoForm2;
        private System.Windows.Forms.Button button_criarContaForm2;
    }
}