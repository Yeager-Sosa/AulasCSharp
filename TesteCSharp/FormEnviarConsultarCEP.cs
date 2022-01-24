using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios;
using Npgsql;
using Dapper;

namespace TesteCSharp
{
    public partial class FormEnviarConsultarCEP : Form
    {
        Conexao conexao = new Conexao();
        
        NpgsqlCommand cmd = new NpgsqlCommand();

        public FormEnviarConsultarCEP()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrEmpty(txtCEP.Text))
                {
                    MessageBox.Show("CEP esta vazio, preencha por favor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    CorreiosApi correiosApi = new CorreiosApi();
                    
                    var retorno = correiosApi.consultaCEP(txtCEP.Text);

                    if (retorno is null)
                    {
                        MessageBox.Show("CEP não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    txtCEP.Text = retorno.cep;

                    txtLogradouro.Text = retorno.end;

                    txtComp1.Text = retorno.complemento;

                    txtBairro.Text = retorno.bairro;

                    txtLocalidade.Text = retorno.cidade;

                    txtUF.Text = retorno.uf;

                    if (txtComp1.Text is null) txtComp1.Text = "";

                    conexao.conectar();

                    cmd.Connection = conexao.conectar();

                    cmd.CommandText = "INSERT INTO ENDERECO (CEP, LOGRADOURO, COMPLEMENTO, BAIRRO, LOCALIDADE, UF) VALUES('" + txtCEP.Text + "', '" + txtLogradouro.Text + "','" + txtComp1.Text + "','" + txtBairro.Text + "','" + txtLocalidade.Text + "','" + txtUF.Text + "')";

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Informações armazenadas com sucesso");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Atenção, CEP Incorreto, verifique valor digitado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sair da aplicação?", "Saindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O3PT85T;Initial Catalog=BancoTesteCSharp;Persist Security Info=True;User ID=sa;Password=Gustavo9508***");

                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT LOGRADOURO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO FROM ENDERECO WHERE CEP = @CEP ", con);

                cmd.Parameters.Add("@CEP", SqlDbType.Int).Value = txtCEP.Text;

                SqlDataReader dr;

                dr = cmd.ExecuteReader();
                
                dr.Read();

                txtLogradouro.Text = dr.GetString(0);
                
                txtComp1.Text = dr.GetString(1);
                
                txtBairro.Text = dr.GetString(2);
                
                txtLocalidade.Text = dr.GetString(3);
                
                txtUF.Text = dr.GetString(4);
                
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Cep não encontrado ou invalido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCEP.Text = String.Empty;
            
            txtLogradouro.Text = String.Empty;
            
            txtComp1.Text = String.Empty;
            
            txtBairro.Text = String.Empty;
            
            txtLocalidade.Text = String.Empty;
            
            txtUF.Text = String.Empty;
        }
    }
}