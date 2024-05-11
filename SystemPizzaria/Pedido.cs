using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemPizzaria
{
    public partial class Pedido : Form
    {


        //INSTANCIANDO  A CLASSE CONEXÃO
        Conexao con = new Conexao();
        public Pedido()
        {
            InitializeComponent();
        }
        //mostra os tamanhos no combobox
        private void Pedido_Load(object sender, EventArgs e)
        {
            cmbTamanhoPizza.Items.Add("Pequena - R$20,00");
            cmbTamanhoPizza.Items.Add("Média -R$30,00");
            cmbTamanhoPizza.Items.Add("Grande -R$ 50,00");
        }

        //metodo que calcula o pedido
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valorPizza = 0, valorOpcao = 0, valorTotal = 0;

            if(cmbTamanhoPizza.SelectedIndex == 0)
            {
                valorPizza = 20;
            }else if(cmbTamanhoPizza.SelectedIndex == 1)
            {
                valorPizza = 30;
            }else if (cmbTamanhoPizza.SelectedIndex == 2) 
            {
                valorPizza = 50;
            }

            if(chkBorda.Checked == true)
            {
                valorOpcao = valorOpcao + 5;
            }
            if(chkTempero.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
            }
            if(chkCebola.Checked == true)
            {
                valorOpcao = valorOpcao + 3;
            }
            if(chkCatupiry.Checked == true)
            {
                valorOpcao = valorOpcao + 6;
               
            }
            else
            {
                //MessageBox.Show("Calculo");
            }
            valorTotal = valorPizza + valorOpcao;



            txtValorPizza.Text = Convert.ToString(valorPizza);
            txtValorOpcional.Text = Convert.ToString(valorOpcao);
            txtTotalPagar.Text = Convert.ToString(valorTotal);



        }
        //grupo box para escolher as opçoes
        private void grpOpcionais_Enter(object sender, EventArgs e)
        {
            cmbTamanhoPizza.SelectedIndex = -1;
            txtValorPizza.Clear();
            txtValorOpcional.Clear();
            chkBorda.Checked = false;
            chkCatupiry.Checked = false;
            chkTempero.Checked = false;
            chkCebola.Checked = false;
        }
        //metodo do botão salvar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //verifica os campos 
            if (txtValorPizza.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo nome");
                txtValorPizza.Focus();
            }
            else if (txtValorOpcional.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Email");
                txtValorOpcional.Focus();
            }

            else if (txtTotalPagar.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Telefone");
                txtTotalPagar.Focus();
            }
            else
            {

                try
                {
                    //insere no banco de dados
                    string sql = "insert into tbpedido(tipoPizza,valorPizza,valorOpcao,valorTotal)values(@pizza,@vpizza,@opcao,@valor)";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD());
                    cmd.Parameters.Add("@pizza", MySqlDbType.Text).Value = cmbTamanhoPizza.Text;
                    cmd.Parameters.Add("@vpizza", MySqlDbType.Text).Value = txtValorPizza.Text;
                    cmd.Parameters.Add("@opcao", MySqlDbType.Text).Value = txtValorOpcional.Text;
                    cmd.Parameters.Add("@valor", MySqlDbType.Text).Value = txtTotalPagar.Text;
                    cmd.ExecuteNonQuery();


                    MessageBox.Show("Dados cadastrados com Sucesso !!!");
                    cmbTamanhoPizza.Text = "";
                    txtValorPizza.Text = "";
                    txtValorOpcional.Text = "";
                    txtTotalPagar.Text = "";
                    cmbTamanhoPizza.Focus();
                    con.DesConnectarBD();

                }
                catch (Exception erro)
                {

                    MessageBox.Show(erro.Message);
                   
                }
            }
        }

        private void dgvPedido_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CarregarPedidos();
        }

        //metodo que carrega as informações no DataGridView
        public void CarregarPedidos()
        {
            try
            {
                txtCodPedido.Text = dgvPedido.SelectedRows[0].Cells[0].Value.ToString(); //valor da posição da memoria  0 0
                cmbTamanhoPizza.Text = dgvPedido.SelectedRows[0].Cells[1].Value.ToString();//valor da posição da memoria  0 1
                txtValorPizza.Text = dgvPedido.SelectedRows[0].Cells[2].Value.ToString();//valor da posição da memoria  0 2
                txtValorOpcional.Text = dgvPedido.SelectedRows[0].Cells[3].Value.ToString();//valor da posição da memoria  0 3
                txtTotalPagar.Text = dgvPedido.SelectedRows[0].Cells[4].Value.ToString();//valor da posição da memoria  0 4
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao clicar" + erro);
            }
           
        }

        //Metodo Pesquisar 
        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != "")
            {
                try
                {
                    //conecta o banco
                    con.ConnectarBD();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "select * from tbpedido";

                    cmd.Connection = con.ConnectarBD();
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    DataTable dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    dgvPedido.DataSource = dt;
                    con.DesConnectarBD();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                //dataGridView
                dgvPedido.DataSource = null;
            }
        }
    }
}
