namespace GerenciadorPeçasPc.Model
{
    partial class TelaAlterarPecas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnalterard = new System.Windows.Forms.Button();
            this.txtboxCod = new System.Windows.Forms.TextBox();
            this.txtboxpeca = new System.Windows.Forms.TextBox();
            this.txtboxmarca = new System.Windows.Forms.TextBox();
            this.txtboxcapacidade = new System.Windows.Forms.TextBox();
            this.btnprocurar = new System.Windows.Forms.Button();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o código que deseja alterar.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peça";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(86, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(86, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidade";
            // 
            // btnalterard
            // 
            this.btnalterard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnalterard.Location = new System.Drawing.Point(406, 363);
            this.btnalterard.Name = "btnalterard";
            this.btnalterard.Size = new System.Drawing.Size(328, 57);
            this.btnalterard.TabIndex = 4;
            this.btnalterard.Text = "Alterar os Dados";
            this.btnalterard.UseVisualStyleBackColor = true;
            this.btnalterard.Click += new System.EventHandler(this.btnalterard_Click);
            // 
            // txtboxCod
            // 
            this.txtboxCod.Location = new System.Drawing.Point(395, 47);
            this.txtboxCod.Name = "txtboxCod";
            this.txtboxCod.Size = new System.Drawing.Size(150, 23);
            this.txtboxCod.TabIndex = 5;
            // 
            // txtboxpeca
            // 
            this.txtboxpeca.Location = new System.Drawing.Point(86, 208);
            this.txtboxpeca.Name = "txtboxpeca";
            this.txtboxpeca.Size = new System.Drawing.Size(196, 23);
            this.txtboxpeca.TabIndex = 6;
            // 
            // txtboxmarca
            // 
            this.txtboxmarca.Location = new System.Drawing.Point(86, 285);
            this.txtboxmarca.Name = "txtboxmarca";
            this.txtboxmarca.Size = new System.Drawing.Size(196, 23);
            this.txtboxmarca.TabIndex = 7;
            // 
            // txtboxcapacidade
            // 
            this.txtboxcapacidade.Location = new System.Drawing.Point(86, 363);
            this.txtboxcapacidade.Name = "txtboxcapacidade";
            this.txtboxcapacidade.Size = new System.Drawing.Size(196, 23);
            this.txtboxcapacidade.TabIndex = 8;
            // 
            // btnprocurar
            // 
            this.btnprocurar.Location = new System.Drawing.Point(592, 47);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Size = new System.Drawing.Size(97, 31);
            this.btnprocurar.TabIndex = 9;
            this.btnprocurar.Text = "Procurar";
            this.btnprocurar.UseVisualStyleBackColor = true;
            this.btnprocurar.Click += new System.EventHandler(this.btnprocurar_Click);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Location = new System.Drawing.Point(86, 140);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(196, 23);
            this.textBoxCodigo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(86, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código";
            // 
            // TelaAlterarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnprocurar);
            this.Controls.Add(this.txtboxcapacidade);
            this.Controls.Add(this.txtboxmarca);
            this.Controls.Add(this.txtboxpeca);
            this.Controls.Add(this.txtboxCod);
            this.Controls.Add(this.btnalterard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaAlterarPecas";
            this.Text = "TelaAlterarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnalterard;
        private TextBox txtboxCod;
        private TextBox txtboxpeca;
        private TextBox txtboxmarca;
        private TextBox txtboxcapacidade;
        private Button btnprocurar;
        private TextBox textBoxCodigo;
        private Label label5;
    }
}