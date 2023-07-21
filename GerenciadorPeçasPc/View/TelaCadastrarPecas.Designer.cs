namespace GerenciadorPeçasPc.Model
{
    partial class TelaCadastrarPecas
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
            this.btncadastrarpecas = new System.Windows.Forms.Button();
            this.txtboxpecas = new System.Windows.Forms.TextBox();
            this.txtboxmarcas = new System.Windows.Forms.TextBox();
            this.txtboxcapacidades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Peças";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peças";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(487, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marcas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(254, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacidades";
            // 
            // btncadastrarpecas
            // 
            this.btncadastrarpecas.Location = new System.Drawing.Point(274, 319);
            this.btncadastrarpecas.Name = "btncadastrarpecas";
            this.btncadastrarpecas.Size = new System.Drawing.Size(203, 30);
            this.btncadastrarpecas.TabIndex = 4;
            this.btncadastrarpecas.Text = "Cadastrar";
            this.btncadastrarpecas.UseVisualStyleBackColor = true;
            this.btncadastrarpecas.Click += new System.EventHandler(this.btncadastrarpecas_Click);
            // 
            // txtboxpecas
            // 
            this.txtboxpecas.Location = new System.Drawing.Point(211, 145);
            this.txtboxpecas.Name = "txtboxpecas";
            this.txtboxpecas.Size = new System.Drawing.Size(219, 23);
            this.txtboxpecas.TabIndex = 5;
      
            // 
            // txtboxmarcas
            // 
            this.txtboxmarcas.Location = new System.Drawing.Point(617, 153);
            this.txtboxmarcas.Name = "txtboxmarcas";
            this.txtboxmarcas.Size = new System.Drawing.Size(100, 23);
            this.txtboxmarcas.TabIndex = 6;
            // 
            // txtboxcapacidades
            // 
            this.txtboxcapacidades.Location = new System.Drawing.Point(393, 210);
            this.txtboxcapacidades.Name = "txtboxcapacidades";
            this.txtboxcapacidades.Size = new System.Drawing.Size(100, 23);
            this.txtboxcapacidades.TabIndex = 7;
            // 
            // TelaCadastrarPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtboxcapacidades);
            this.Controls.Add(this.txtboxmarcas);
            this.Controls.Add(this.txtboxpecas);
            this.Controls.Add(this.btncadastrarpecas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastrarPecas";
            this.Text = "TelaCadastrarPecas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btncadastrarpecas;
        private TextBox txtboxpecas;
        private TextBox txtboxmarcas;
        private TextBox txtboxcapacidades;
    }
}