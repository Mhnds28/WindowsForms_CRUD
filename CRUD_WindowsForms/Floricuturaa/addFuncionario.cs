using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Floricuturaa
{
    public partial class addFuncionario : Form
    {
        public addFuncionario()
        {
            InitializeComponent();

            txt_nome.Enabled = false;
            txt_tel.Enabled = false;
            txt_email.Enabled = false;
            txt_cel.Enabled = false;
            txt_bairro.Enabled = false;
            txt_endereco.Enabled = false;
            txt_numero.Enabled = false;
            txt_pesquisa.Enabled = false;
            txt_rg.Enabled = false;
            txt_cpf.Enabled = false;
            
        }

        SqlConnection sqlCon = null;
        private string strCon = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Marcos;Data Source=DESKTOP-3TDM3KN\SQLEXPRESS";
        private string strSql = string.Empty;

 
        private void Adicionar_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            txt_tel.Enabled = true;
            txt_cel.Enabled = true;
            txt_bairro.Enabled = true;
            txt_endereco.Enabled = true;
            txt_numero.Enabled = true;
            txt_pesquisa.Enabled = true;
            txt_rg.Enabled = true;
            txt_cpf.Enabled = true;
            txt_email.Enabled = true;

        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            strSql = "insert into floricultura (Nome,Telefone,Celular,Email,Endereco,Numero,Bairro,RG,CPF) values(@Nome,@Telefone,@Celular,@Email,@Endereco,@Numero,@Bairro,@RG,@CPF)";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txt_cel.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_numero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;
            

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO EFETUADO COM SUCESSO.");

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }
            txt_pesquisa.Enabled = false;

            txt_nome.Clear();
            txt_tel.Clear();
            txt_cel.Clear();
            txt_bairro.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
            //txt_email.Clear();

        }


        private void Buscar_Click(object sender, EventArgs e)
        {
            strSql = "select*from floricultura where Nome=@pesquisa";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@pesquisa", SqlDbType.VarChar).Value = txt_pesquisa.Text;

            try
            {
                if (txt_pesquisa.Text == string.Empty) ;
                {
                    MessageBox.Show("VOCÊ NÃO DIGITOU UM NOME.");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if (dr.HasRows == false)
                {
                    throw new Exception("ESTE NOME NÃO ESTA CADASTRADO");

                }
                dr.Read();
                txt_nome.Text = Convert.ToString(dr["Nome"]);
                txt_tel.Text = Convert.ToString(dr["Telefone"]);
                txt_cel.Text = Convert.ToString(dr["Celular"]);
                txt_endereco.Text = Convert.ToString(dr["Endereco"]);
                txt_numero.Text = Convert.ToString(dr["Numero"]);
                txt_bairro.Text = Convert.ToString(dr["Bairro"]);
                txt_rg.Text = Convert.ToString(dr["RG"]);
                txt_cpf.Text = Convert.ToString(dr["CPF"]);
                
            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlCon.Close();
            }


        }

        private void Editar_Click(object sender, EventArgs e)
        {
            strSql = "update floricultura set Nome=@Nome, Telefone=@Telefone, Celular=@Celular, Email=@Email, Endereco=@Endereco, Numero=@Numero, Bairro=@Bairro, RG=@RG, CPF=@CPF";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_tel.Text;
            comando.Parameters.Add("@Celular", SqlDbType.VarChar).Value = txt_cel.Text;
            comando.Parameters.Add("@Email", SqlDbType.VarChar).Value = txt_email.Text;
            comando.Parameters.Add("@Endereco", SqlDbType.VarChar).Value = txt_endereco.Text;
            comando.Parameters.Add("@Numero", SqlDbType.VarChar).Value = txt_numero.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@RG", SqlDbType.VarChar).Value = txt_rg.Text;
            comando.Parameters.Add("@CPF", SqlDbType.VarChar).Value = txt_cpf.Text;
            

            try
            {
                sqlCon.Open();

                comando.ExecuteNonQuery();

                MessageBox.Show("CADASTRO ALTERADO COM SUCESSO");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            txt_tel.Clear();
            txt_cel.Clear();
            txt_bairro.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
            
        }


        private void button5_Click(object sender, EventArgs e)
        {
            strSql = "delete from funcionario where Nome=@Nome";

            sqlCon = new SqlConnection(strCon);

            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("EXCLUSÃO DE CADASTRO FEITA COM SUCESSO");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            txt_nome.Clear();
            txt_tel.Clear();
            txt_cel.Clear();
            txt_bairro.Clear();
            txt_endereco.Clear();
            txt_numero.Clear();
            txt_rg.Clear();
            txt_cpf.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

       
    }
}
