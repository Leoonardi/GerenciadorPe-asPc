namespace GerenciadorPeçasPc.Model
{
    partial class TelaPesquisaPecas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnbuscarcodigo = new System.Windows.Forms.Button();
            this.txtboxcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peça = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxpeca = new System.Windows.Forms.TextBox();
            this.txtboxmarca = new System.Windows.Forms.TextBox();
            this.txtboxcapacidade = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(253, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Peças.......";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 330);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtboxcapacidade);
            this.tabPage1.Controls.Add(this.txtboxmarca);
            this.tabPage1.Controls.Add(this.txtboxpeca);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnbuscarcodigo);
            this.tabPage1.Controls.Add(this.txtboxcodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por Código";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnbuscarcodigo
            // 
            this.btnbuscarcodigo.Location = new System.Drawing.Point(599, 39);
            this.btnbuscarcodigo.Name = "btnbuscarcodigo";
            this.btnbuscarcodigo.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarcodigo.TabIndex = 3;
            this.btnbuscarcodigo.Text = "Pesquisar";
            this.btnbuscarcodigo.UseVisualStyleBackColor = true;
            this.btnbuscarcodigo.Click += new System.EventHandler(this.btnbuscarcodigo_Click);
            // 
            // txtboxcodigo
            // 
            this.txtboxcodigo.Location = new System.Drawing.Point(362, 40);
            this.txtboxcodigo.Name = "txtboxcodigo";
            this.txtboxcodigo.Size = new System.Drawing.Size(189, 23);
            this.txtboxcodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(131, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a Código";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Peça,
            this.Marca,
            this.Capacidade});
            this.dataGridView1.Location = new System.Drawing.Point(148, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(453, 183);
            this.dataGridView1.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Peça
            // 
            this.Peça.HeaderText = "Peça";
            this.Peça.Name = "Peça";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Capacidade
            // 
            this.Capacidade.HeaderText = "Capacidade";
            this.Capacidade.Name = "Capacidade";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 302);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Peça";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Peça";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Marca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Capacidade";
            // 
            // txtboxpeca
            // 
            this.txtboxpeca.Location = new System.Drawing.Point(267, 111);
            this.txtboxpeca.Name = "txtboxpeca";
            this.txtboxpeca.Size = new System.Drawing.Size(100, 23);
            this.txtboxpeca.TabIndex = 7;
            // 
            // txtboxmarca
            // 
            this.txtboxmarca.Location = new System.Drawing.Point(267, 166);
            this.txtboxmarca.Name = "txtboxmarca";
            this.txtboxmarca.Size = new System.Drawing.Size(100, 23);
            this.txtboxmarca.TabIndex = 8;
            // 
            // txtboxcapacidade
            // 
            this.txtboxcapacidade.Location = new System.Drawing.Point(285, 234);
            this.txtboxcapacidade.Name = "txtboxcapacidade";
            this.txtboxcapacidade.Size = new System.Drawing.Size(100, 23);
            this.txtboxcapacidade.TabIndex = 9;
            // 
            // TelaPesquisaPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "TelaPesquisaPecas";
            this.Text = "TelaPesquisaPecas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Código;
        private DataGridViewTextBoxColumn Peça;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Capacidade;
        private TabPage tabPage2;
        private TextBox txtboxcodigo;
        private Label label2;
        private Button btnbuscarcodigo;
        private TextBox txtboxcapacidade;
        private TextBox txtboxmarca;
        private TextBox txtboxpeca;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}