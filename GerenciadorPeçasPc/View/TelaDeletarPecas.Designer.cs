namespace GerenciadorPeçasPc.Model
{
    partial class TelaDeletarPecas
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
            this.btnprocurar = new System.Windows.Forms.Button();
            this.txtboxcapacidade = new System.Windows.Forms.TextBox();
            this.txtboxmarca = new System.Windows.Forms.TextBox();
            this.txtboxpeca = new System.Windows.Forms.TextBox();
            this.txtboxpesquisarcodigo = new System.Windows.Forms.TextBox();
            this.btndeletar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxcodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnprocurar
            // 
            this.btnprocurar.Location = new System.Drawing.Point(607, 49);
            this.btnprocurar.Name = "btnprocurar";
            this.btnprocurar.Size = new System.Drawing.Size(97, 31);
            this.btnprocurar.TabIndex = 19;
            this.btnprocurar.Text = "Procurar";
            this.btnprocurar.UseVisualStyleBackColor = true;
            this.btnprocurar.Click += new System.EventHandler(this.btnprocurar_Click);
            // 
            // txtboxcapacidade
            // 
            this.txtboxcapacidade.Location = new System.Drawing.Point(134, 312);
            this.txtboxcapacidade.Name = "txtboxcapacidade";
            this.txtboxcapacidade.Size = new System.Drawing.Size(196, 23);
            this.txtboxcapacidade.TabIndex = 18;
            // 
            // txtboxmarca
            // 
            this.txtboxmarca.Location = new System.Drawing.Point(134, 234);
            this.txtboxmarca.Name = "txtboxmarca";
            this.txtboxmarca.Size = new System.Drawing.Size(196, 23);
            this.txtboxmarca.TabIndex = 17;
            // 
            // txtboxpeca
            // 
            this.txtboxpeca.Location = new System.Drawing.Point(134, 159);
            this.txtboxpeca.Name = "txtboxpeca";
            this.txtboxpeca.Size = new System.Drawing.Size(196, 23);
            this.txtboxpeca.TabIndex = 16;
            // 
            // txtboxpesquisarcodigo
            // 
            this.txtboxpesquisarcodigo.Location = new System.Drawing.Point(430, 49);
            this.txtboxpesquisarcodigo.Name = "txtboxpesquisarcodigo";
            this.txtboxpesquisarcodigo.Size = new System.Drawing.Size(150, 23);
            this.txtboxpesquisarcodigo.TabIndex = 15;
            // 
            // btndeletar
            // 
            this.btndeletar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btndeletar.Location = new System.Drawing.Point(278, 353);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(328, 57);
            this.btndeletar.TabIndex = 14;
            this.btndeletar.Text = "Deletar os Dados da Peça";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(134, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Capacidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(134, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Peça";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(66, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Digite o código que deseja Deletar.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(407, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Código";
            // 
            // txtboxcodigo
            // 
            this.txtboxcodigo.Location = new System.Drawing.Point(506, 159);
            this.txtboxcodigo.Name = "txtboxcodigo";
            this.txtboxcodigo.Size = new System.Drawing.Size(137, 23);
            this.txtboxcodigo.TabIndex = 21;
            // 
            // TelaDeletarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnprocurar);
            this.Controls.Add(this.txtboxcapacidade);
            this.Controls.Add(this.txtboxmarca);
            this.Controls.Add(this.txtboxpeca);
            this.Controls.Add(this.txtboxpesquisarcodigo);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaDeletarPecas";
            this.Text = "TelaDeletarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnprocurar;
        private TextBox txtboxcapacidade;
        private TextBox txtboxmarca;
        private TextBox txtboxpeca;
        private TextBox txtboxpesquisarcodigo;
        private Button btndeletar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private TextBox txtboxcodigo;
    }
}