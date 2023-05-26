using Microsoft.VisualBasic;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace Desafio.Estacionamento_TemVaga
{
    public partial class frm_Estaciona : Form
    {
        private int contador = 50;
        private Veiculo veiculo = new Veiculo();

        public frm_Estaciona()
        {
            InitializeComponent();
            veiculo = new Veiculo();
            this.Load += frm_Estaciona_Load; //muda cor do app

        }

        private void frm_Estaciona_Load(object sender, EventArgs e)
        {
            int horaAtual = DateTime.Now.Hour;
            //Configuração do Botão limpar
            btn_limpa.FlatStyle = FlatStyle.Flat;//define estilo
            btn_limpa.FlatAppearance.BorderColor = Color.Red;//define cor

            //Impoem o horario de funcionamento do programa.
            if (horaAtual < 8 || horaAtual >= 20)
            {
                MessageBox.Show("O Programa só pode ser utilizado entre as 8 horas da manhã e 20 horas!!");
                this.Enabled = false;
            }

        }

        private void Btn_Entrada_Click(object sender, EventArgs e)
        {

            string placa = lb_DigitaPlaca.Text;
            string modelo = lb_DigitaModelo.Text;
            string cor = lb_DigitaCor.Text;
            bool possuiPlaca = false;
            DateTime horaEntrada = DateTime.Now;
            string conteudo = $"{horaEntrada} -  {placa} - {modelo} - {cor}";
            //Atualiza o contador
            AtualizarContador();
            //Testa o contador, e a quantidade de vagas
            if (contador == 0)
            {
                Btn_Entrada.Enabled = false;
            }
            else { Btn_Entrada.Enabled = true; }

            //incrementa a lista
            //Faz a verificação se a placa já foi digitada                
            foreach (string item in listbox_entrada.Items)
            {
                string[] dados = item.Split(" - ");
                if (dados[1].Trim() == placa)
                {
                    possuiPlaca = true;
                    break;
                }
            }
            if (listbox_entrada.Items.Contains(placa) || string.IsNullOrWhiteSpace(placa) || possuiPlaca)
            {
                MessageBox.Show("Erro!!!\nDigite novamente");
                return;
            }
            else
            {
                veiculo.EntraVeiculo(placa, modelo, cor);
                MessageBox.Show($"Carro na garagem!");
            }
            //Adiciona na lista            
            if (!string.IsNullOrEmpty(conteudo))
            {
                listbox_entrada.Items.Add(conteudo);
            }
            lb_DigitaPlaca.Text = " ";
            lb_DigitaModelo.Text = " ";
            lb_DigitaCor.Text = " ";
            contador--;
        }
        private void Btn_Saida_Click(object sender, EventArgs e)
        {
            string placa = lb_DigitaPlaca.Text;
            IVeiculo registro = new Veiculo();
            veiculo.SaidaVeiculo(placa);
            DateTime horaentrada = DateTime.MinValue;
            //cria a lista, para calcular a entrada e saida
            List<string> entrada = new List<string>();
            
            foreach (string item in listbox_entrada.Items)
            {
                string[] dados = item.Split(" - ");
                if (dados[1] == placa)
                {
                    horaentrada = Convert.ToDateTime(dados[0]);
                    break;
                }
                
            }
            ///Percorre a lista para retirar da lista entrada caso o carro saia da garagem.
            //for (int i = listbox_entrada.Items.Count - 1; i >= 0; i--)
            //{
            //    string item1 = listbox_entrada.Items[i].ToString();
            //    if (item1.Contains(placa))
            //    {
            //        listbox_entrada.Items.RemoveAt(i);
            //        return;
            //    }
            //} 
            ///Calcula Saida
            double valor = 0;
            if (horaentrada != DateTime.MinValue)
            {
                TimeSpan diferenca = DateTime.Now - horaentrada;
                valor = Math.Ceiling(diferenca.TotalHours) * 5;
            }
            ///Atualiza o contador do programa
            AtualizarContador();
            if (contador < 51)
            {
                Btn_Entrada.Enabled = false;
            }
           
                       
            //Conteudos da listaSaida
            string conteudoSaida = $"R${valor} - Placa:{placa}-{DateTime.Now}";
            listbox_Saida.Items.Add(conteudoSaida);
            //MSG com o Valor a ser cobrado
            MessageBox.Show($"Valor a ser cobrado: R$ {valor}\n{DateTime.Now}");
            contador++;
        }
        private void AtualizarContador()
        {
            lb_Contador.Text = contador.ToString();
            if (lb_Contador.Text == "40")
            {
                lb_Contador.ForeColor = ColorTranslator.FromHtml("#ADFF2F");
            }
            if (lb_Contador.Text == "30")
            {
                lb_Contador.ForeColor = ColorTranslator.FromHtml("#6B8E23");
            }
            if (lb_Contador.Text == "25")
            {
                lb_Contador.ForeColor = ColorTranslator.FromHtml("#D2691E");
            }
            if (lb_Contador.Text == "15")
            {
                lb_Contador.ForeColor = ColorTranslator.FromHtml("#FF7F50");
            }
            if (lb_Contador.Text == "10")
            {
                lb_Contador.ForeColor = ColorTranslator.FromHtml("#FF0000");
            }
            if (lb_Contador.Text == "0")
            {
                lb_Contador.ForeColor = ColorTranslator.FromHtml("#FF0000");
                lb_Contador.Text = "0 - Vagas Indisponiveis";
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_dataHora.Text = DateTime.Now.ToString("HH:mm:ss");
            //Data e Horas em temporea

        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            string placa = Tb_pesquisarVeiculo.Text;
            bool placaEncontrada = false;
            foreach (string item in listbox_entrada.Items)
            {
                string[] dado = item.Split(" - ");
                if (dado[1].Trim() == placa)
                {
                    MessageBox.Show($"A placa {placa} está na lista de entrada.");
                    placaEncontrada = true;
                    break;
                }
            }
        }
    }
}