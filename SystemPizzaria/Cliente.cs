using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemPizzaria
{
    public partial class Cliente : Form
    {
        //INSTANCIANDO A CLASSE CONEXAO
        Conexao con = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        public Cliente()
        {
            InitializeComponent();
        }

        // METODO HABILITAR CAMPOS

        private void habilitaCampos()
        {
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            btnNovo.Enabled = false;
            btnSalvar.Enabled = true;
            btnALterar.Enabled = false;
            txtNome.Focus(); //DEIXA A SETINHA NO CAMPO NOME
        }


        // METODO DESABILITAR CAMPOS

        private void desabiltaCampos()
        {
            txtEmail.Enabled = true;
            txtNome.Enabled = true;
            txtTelefone.Enabled = true;
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            btnALterar.Enabled = false;
            txtPesquisar.Clear(); //LIMPA O CAMPO PESQUISAR
            txtPesquisar.Focus();
            limpaCampos(); //CHAMANDO O METODO LIMPA CAMPOS
        }

        // LIMPA CAMPOS

        private void limpaCampos()
        {
            txtEmail.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtPesquisar.Clear();
            dgvCliente.DataSource = null; //LIMPA O DATAGRIDVIEW
        }





        //METODO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //CHAMANDO O METODO HABILITA CAMPOS
            habilitaCampos();
        }
        
        
        //METODO SALVAR

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //VERIFICA OS CAMPOS SE ESTÃO VAZIOS
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo nome");
                txtNome.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Email");
                txtEmail.Focus();
            }

            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o campo Telefone");
                txtTelefone.Focus();
            }
            else
            {    //tratamento de erros evita bugar todo sistema apresenta mensagem erro TRY ELE TENTA 
                try
                {
                    //VARIAVEI SQL QUE RECEBE O INSERT(VAI INSERIR OS DADOS NO BANCO com imagem)
                    string sql = "insert into tbcliente(nome,email, telefone,imagem) values(@nome,@email,@telefone,'"+picImage.Image+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, con.ConnectarBD()); //CMD IDENTIFICA OS COMANDOS DO MYSQL NO c#
                    cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text; //PEGA O VALOR DO NOME
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text; // PEGA O VALOR DO TELEFONE
                    cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = txtTelefone.Text;//
                    cmd.ExecuteNonQuery();//EXECUTA A AÇÃO DE INSERIR
                    MessageBox.Show("Dados Cadastrados com Sucesso"); //APRESENTE A MENSAGEM DE SUCESSO
                    limpaCampos();//CHAMA O METODO LIMPA CAMPOS
                    con.DesConnectarBD();//DESCONECTA DO BANCO DE DADOS
                }
                //CASO NÃO CONSIGA EM VEZ DE TRAVAR O PROJETO APARECE UMA MENSAGEM
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        public void carregarImagem(PictureBox picImage)
        {
            //vai filtrar o tipo de imagem 
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Imagem|*.jpg;*.doc;*.xls;*.ppt;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                //vai ler o tamanho do arquivo selecionado
                FileInfo file = new FileInfo(openFileDialog1.FileName);


                //testa se tem menos de 1MB (1MB em bytes = 1048576)
                if (file.Length <= 1048576)
                    picImage.ImageLocation = openFileDialog1.FileName;
                else
                    MessageBox.Show("Arquivo Maior que 1MB!");

            }
        }

        //METODO CARREGAR IMAGEM
        private void brnCarregar_Click(object sender, EventArgs e)
        {
            carregarImagem(picImage);
        }




        // METODO DO DATAGRIDVIEW
        private void dgvCliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //CHAMANADO O METODO CARREGAR CLIENTES
            carregarClientes();
        }


        private void carregarClientes()
        {
            //VAI TENTAR CASO DE CERTO ELE MOSTRA
            try
            {
                //ABRE A CONEXÃO DO BANCO COM C#
                con.ConnectarBD();          
                txtCodCli.Text = dgvCliente.SelectedRows[0].Cells[0].Value.ToString();  //PEGA O VALOR DO PRIMEIRO CAMPO DA TABELA(CODIGO POR EXEMPLO CASO TENHA)
                txtNome.Text = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();//PEGA O O NOME E PASSAR NO DATAGRID
                txtEmail.Text = dgvCliente.SelectedRows[0].Cells[2].Value.ToString();//PEGA O EMAIL E PASSAR NO DATAGRID
                txtTelefone.Text = dgvCliente.SelectedRows[0].Cells[3].Value.ToString();// PEGA O TELEFONE E PASSAR NO DATAGRID
                //DESCONECTA O BANCO DE DADOS
                con.DesConnectarBD();

            }
            //EM CASO DÊ ALGO ERRADO  
            catch (Exception erro)
            {
                //MOSTRA A MENSAGEM DE ERRO
                MessageBox.Show(erro.Message);
                
            }

        }
        //METODO PESQUISAR 
        private void txtPesquisar_TextChanged_1(object sender, EventArgs e)
        //SE O PESQUISAR ESTIVER VAZIO
        {
            if (txtPesquisar.Text != "")
            {
                //TENTA
                try
                {
                    con.ConnectarBD();
                    //COMO ESTAMOS USANDO MYSQL PRECISA SER CHAMANDO O MYSQLCOMMAND NA INSTANCIA
                    MySqlCommand cmd = new MySqlCommand();
                    //FAZENDO O SELECT NA TABELA DO BANCO
                    cmd.CommandText = "select * from tbcliente";

                    //ABRE A CONEXÃO DO c# COM MYSQL
                    cmd.Connection = con.ConnectarBD();
                    //MECANISMO QUE BUSCA OS DADOS DA TABELA NO BANCO
                    MySqlDataAdapter da = new MySqlDataAdapter();
                    //LOCAL AONDE ARMAZENA OS DADOS TRAZIDOS 
                    DataTable dt = new DataTable();
                    //JUNTO  O DATA ADAPTER (da) com MySqlCommand(cmd)
                    da.SelectCommand = cmd;
                    //FILTTRA OS DADOS DENTRO DO DT
                    da.Fill(dt);
                    //APRESENTA OS DADOS NO DATAGRIDVIEW
                    dgvCliente.DataSource = dt;
                    //DESCONECTA O BANCO
                    con.DesConnectarBD();
                }
                //CASO DE ERRADO 
                catch (Exception erro)
                {
                    //MOSTRA UMA MENSAGEM
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                //SENÃO TRAS O DATAGRID VAZIO
                dgvCliente.DataSource = null;

            }

        }
        //METODO QUE ALTERA OS DADOS DO CLIENTE
        private void btnALterar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");

            }
            else if(txtEmail.Text == "")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");
            }
            else if (txtTelefone.Text =="")
            {
                MessageBox.Show("Obrigatório Preencher o Campo");

            }
            try
            {
                //FAZ O UPDATE NO BANCO DE DADOS
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = con.ConnectarBD();
                cmd.CommandText = "update tbcliente set nome=@nome, email=@email, telefone=@telefone where codCli= "+txtCodCli.Text;
                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNome.Text;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = txtEmail.Text;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = txtTelefone.Text;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Dados Alterados com sucesso");
                limpaCampos();
                desabiltaCampos();
                txtPesquisar.Focus();
                cmd.Parameters.Clear();
                con.DesConnectarBD();
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
        //METODO EXCLUIR
        private void btnEcluir_Click(object sender, EventArgs e)
        {
            // FAZ A PERGUNTA SE DESEJA EXCLUIR OU NÃO 
            DialogResult excluir = MessageBox.Show("Deseja excluir esse registro ?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (excluir == DialogResult.No)
            {
                return;
            }
            else
            {
                try
                {
                    // EXCLUI DO BANCO DE DADOS
                    MySqlCommand cmd = new MySqlCommand();
                    con.ConnectarBD();
                    cmd.CommandText = "delete from tbcliente where codCli= "+txtCodCli.Text;
                    cmd.Connection = con.ConnectarBD();
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Dados apagados com sucesso");
                    limpaCampos();
                    desabiltaCampos();
                    txtPesquisar.Focus();
                    cmd.Parameters.Clear();
                    con.DesConnectarBD();


                }
                catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }

        }

    }
}
