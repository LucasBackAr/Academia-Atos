namespace Desafio.Estacionamento_TemVaga
{
    partial class frm_Estaciona
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
            components = new System.ComponentModel.Container();
            lb_VagasDispo = new Label();
            label1 = new Label();
            lb_DigitaPlaca = new TextBox();
            Lb_digitaTxt = new Label();
            Btn_Entrada = new Button();
            Btn_Saida = new Button();
            lb_Contador = new Label();
            lb_dataHora = new Label();
            lb_DigitaModelo = new TextBox();
            lb_DigitaCor = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Tb_pesquisarVeiculo = new TextBox();
            lbPesquisa = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_limpa = new Button();
            btn_Pesquisa = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            listbox_entrada = new ListBox();
            listbox_Saida = new ListBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lb_VagasDispo
            // 
            lb_VagasDispo.Anchor = AnchorStyles.None;
            lb_VagasDispo.AutoSize = true;
            lb_VagasDispo.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_VagasDispo.ForeColor = SystemColors.ButtonHighlight;
            lb_VagasDispo.Location = new Point(27, 15);
            lb_VagasDispo.Name = "lb_VagasDispo";
            lb_VagasDispo.Size = new Size(225, 27);
            lb_VagasDispo.TabIndex = 0;
            lb_VagasDispo.Text = "Vagas Disponiveis:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(607, 645);
            label1.Name = "label1";
            label1.Size = new Size(390, 19);
            label1.TabIndex = 1;
            label1.Text = "Cadastro de carros no estacionamento TemVaga";
            // 
            // lb_DigitaPlaca
            // 
            lb_DigitaPlaca.Anchor = AnchorStyles.None;
            lb_DigitaPlaca.Location = new Point(3, 38);
            lb_DigitaPlaca.MaximumSize = new Size(300, 30);
            lb_DigitaPlaca.Name = "lb_DigitaPlaca";
            lb_DigitaPlaca.Size = new Size(300, 27);
            lb_DigitaPlaca.TabIndex = 2;
            // 
            // Lb_digitaTxt
            // 
            Lb_digitaTxt.Anchor = AnchorStyles.None;
            Lb_digitaTxt.AutoSize = true;
            Lb_digitaTxt.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lb_digitaTxt.ForeColor = SystemColors.ButtonHighlight;
            Lb_digitaTxt.Location = new Point(0, 11);
            Lb_digitaTxt.Name = "Lb_digitaTxt";
            Lb_digitaTxt.Size = new Size(241, 24);
            Lb_digitaTxt.TabIndex = 3;
            Lb_digitaTxt.Text = "Digite a Placa do veiculo";
            // 
            // Btn_Entrada
            // 
            Btn_Entrada.Anchor = AnchorStyles.None;
            Btn_Entrada.Cursor = Cursors.Hand;
            Btn_Entrada.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Entrada.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Entrada.Location = new Point(12, 296);
            Btn_Entrada.MaximumSize = new Size(125, 30);
            Btn_Entrada.Name = "Btn_Entrada";
            Btn_Entrada.Size = new Size(125, 30);
            Btn_Entrada.TabIndex = 4;
            Btn_Entrada.Text = "ENTRADA";
            Btn_Entrada.UseVisualStyleBackColor = true;
            Btn_Entrada.Click += Btn_Entrada_Click;
            // 
            // Btn_Saida
            // 
            Btn_Saida.Anchor = AnchorStyles.None;
            Btn_Saida.Cursor = Cursors.Hand;
            Btn_Saida.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Saida.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Saida.Location = new Point(872, 296);
            Btn_Saida.MaximumSize = new Size(125, 30);
            Btn_Saida.Name = "Btn_Saida";
            Btn_Saida.Size = new Size(125, 30);
            Btn_Saida.TabIndex = 5;
            Btn_Saida.Text = "SAIDA";
            Btn_Saida.UseVisualStyleBackColor = true;
            Btn_Saida.Click += Btn_Saida_Click;
            // 
            // lb_Contador
            // 
            lb_Contador.Anchor = AnchorStyles.None;
            lb_Contador.AutoSize = true;
            lb_Contador.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Contador.ForeColor = Color.Chartreuse;
            lb_Contador.Location = new Point(112, 56);
            lb_Contador.Name = "lb_Contador";
            lb_Contador.Size = new Size(55, 40);
            lb_Contador.TabIndex = 6;
            lb_Contador.Text = "50";
            // 
            // lb_dataHora
            // 
            lb_dataHora.Anchor = AnchorStyles.None;
            lb_dataHora.AutoSize = true;
            lb_dataHora.FlatStyle = FlatStyle.System;
            lb_dataHora.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lb_dataHora.ForeColor = SystemColors.ButtonHighlight;
            lb_dataHora.Location = new Point(891, 12);
            lb_dataHora.Name = "lb_dataHora";
            lb_dataHora.Size = new Size(104, 27);
            lb_dataHora.TabIndex = 7;
            lb_dataHora.Text = "14:00:00";
            // 
            // lb_DigitaModelo
            // 
            lb_DigitaModelo.Anchor = AnchorStyles.None;
            lb_DigitaModelo.Location = new Point(3, 178);
            lb_DigitaModelo.MaximumSize = new Size(300, 30);
            lb_DigitaModelo.Name = "lb_DigitaModelo";
            lb_DigitaModelo.Size = new Size(300, 27);
            lb_DigitaModelo.TabIndex = 10;
            // 
            // lb_DigitaCor
            // 
            lb_DigitaCor.Anchor = AnchorStyles.None;
            lb_DigitaCor.Location = new Point(3, 106);
            lb_DigitaCor.MaximumSize = new Size(300, 30);
            lb_DigitaCor.Name = "lb_DigitaCor";
            lb_DigitaCor.Size = new Size(300, 27);
            lb_DigitaCor.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 151);
            label2.Name = "label2";
            label2.Size = new Size(260, 24);
            label2.TabIndex = 12;
            label2.Text = "Digite o modelo do veiculo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(0, 79);
            label3.Name = "label3";
            label3.Size = new Size(221, 24);
            label3.TabIndex = 13;
            label3.Text = "Digite a cor do veiculo";
            // 
            // Tb_pesquisarVeiculo
            // 
            Tb_pesquisarVeiculo.Anchor = AnchorStyles.None;
            Tb_pesquisarVeiculo.Location = new Point(372, 383);
            Tb_pesquisarVeiculo.MaximumSize = new Size(275, 30);
            Tb_pesquisarVeiculo.Name = "Tb_pesquisarVeiculo";
            Tb_pesquisarVeiculo.Size = new Size(275, 27);
            Tb_pesquisarVeiculo.TabIndex = 14;
            // 
            // lbPesquisa
            // 
            lbPesquisa.Anchor = AnchorStyles.None;
            lbPesquisa.AutoSize = true;
            lbPesquisa.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbPesquisa.ForeColor = SystemColors.ButtonHighlight;
            lbPesquisa.Location = new Point(390, 332);
            lbPesquisa.Name = "lbPesquisa";
            lbPesquisa.Size = new Size(248, 24);
            lbPesquisa.TabIndex = 15;
            lbPesquisa.Text = "Pesquisar Veiculo (placa)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(799, 619);
            label4.Name = "label4";
            label4.Size = new Size(198, 20);
            label4.TabIndex = 16;
            label4.Text = "Insira a placa para indicar a  saida";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 619);
            label5.Name = "label5";
            label5.Size = new Size(219, 20);
            label5.TabIndex = 17;
            label5.Text = "Insira os dados para indicar a  entrada";
            // 
            // btn_limpa
            // 
            btn_limpa.Anchor = AnchorStyles.None;
            btn_limpa.BackColor = Color.Red;
            btn_limpa.BackgroundImageLayout = ImageLayout.Center;
            btn_limpa.Cursor = Cursors.Hand;
            btn_limpa.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_limpa.ForeColor = SystemColors.ButtonHighlight;
            btn_limpa.Location = new Point(458, 632);
            btn_limpa.Name = "btn_limpa";
            btn_limpa.Size = new Size(94, 29);
            btn_limpa.TabIndex = 18;
            btn_limpa.Text = "Limpa";
            btn_limpa.UseVisualStyleBackColor = false;
            // 
            // btn_Pesquisa
            // 
            btn_Pesquisa.Anchor = AnchorStyles.None;
            btn_Pesquisa.ForeColor = SystemColors.ActiveCaptionText;
            btn_Pesquisa.Location = new Point(458, 428);
            btn_Pesquisa.Name = "btn_Pesquisa";
            btn_Pesquisa.Size = new Size(94, 29);
            btn_Pesquisa.TabIndex = 19;
            btn_Pesquisa.Text = "Pesquisar";
            btn_Pesquisa.UseVisualStyleBackColor = true;
            btn_Pesquisa.Click += btn_Pesquisa_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // listbox_entrada
            // 
            listbox_entrada.FormattingEnabled = true;
            listbox_entrada.ItemHeight = 20;
            listbox_entrada.Location = new Point(12, 332);
            listbox_entrada.MaximumSize = new Size(332, 284);
            listbox_entrada.MinimumSize = new Size(300, 284);
            listbox_entrada.Name = "listbox_entrada";
            listbox_entrada.Size = new Size(332, 284);
            listbox_entrada.TabIndex = 20;
            // 
            // listbox_Saida
            // 
            listbox_Saida.FormattingEnabled = true;
            listbox_Saida.ItemHeight = 20;
            listbox_Saida.Location = new Point(665, 332);
            listbox_Saida.MaximumSize = new Size(332, 284);
            listbox_Saida.MinimumSize = new Size(300, 284);
            listbox_Saida.Name = "listbox_Saida";
            listbox_Saida.Size = new Size(332, 284);
            listbox_Saida.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lb_VagasDispo);
            panel1.Controls.Add(lb_Contador);
            panel1.Location = new Point(372, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(279, 126);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.Controls.Add(Lb_digitaTxt);
            panel2.Controls.Add(lb_DigitaPlaca);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lb_DigitaModelo);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lb_DigitaCor);
            panel2.Location = new Point(12, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 241);
            panel2.TabIndex = 23;
            // 
            // frm_Estaciona
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1003, 673);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(listbox_Saida);
            Controls.Add(listbox_entrada);
            Controls.Add(btn_Pesquisa);
            Controls.Add(btn_limpa);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbPesquisa);
            Controls.Add(Tb_pesquisarVeiculo);
            Controls.Add(lb_dataHora);
            Controls.Add(Btn_Saida);
            Controls.Add(Btn_Entrada);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlDark;
            MaximumSize = new Size(1021, 720);
            MinimumSize = new Size(1021, 720);
            Name = "frm_Estaciona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TemVaga";
            Load += frm_Estaciona_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_VagasDispo;
        private Label label1;
        private TextBox lb_DigitaPlaca;
        private Label Lb_digitaTxt;
        private Button Btn_Entrada;
        private Button Btn_Saida;
        private Label lb_Contador;
        private Label lb_dataHora;
        private TextBox lb_DigitaModelo;
        private TextBox lb_DigitaCor;
        private Label label2;
        private Label label3;
        private TextBox Tb_pesquisarVeiculo;
        private Label lbPesquisa;
        private Label label4;
        private Label label5;
        private Button btn_limpa;
        private Button btn_Pesquisa;
        private System.Windows.Forms.Timer timer1;
        private ListBox listbox_entrada;
        private ListBox listbox_Saida;
        private Panel panel1;
        private Panel panel2;
    }
}