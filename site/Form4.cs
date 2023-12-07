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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace site
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {

            listView1.Items.Clear();
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT ID,Nome,Senha FROM Cadastro";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string name = (string)dr["Nome"];
                    string senha = (string)dr["Senha"];

                    ListViewItem lv = new ListViewItem(name.ToString());
                    lv.SubItems.Add(senha);
                    listView1.Items.Add(lv);



                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("Email", "Senha");
            usuario.Email = text1.Text;
            usuario.senha = Criptografia.CriptografarSenha(text2.Text);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.loginUsuario(usuario);
        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            text1.Text = listView1.Items[index].SubItems[0].Text;
            text2.Text = listView1.Items[index].SubItems[1].Text;
        }
    }
}
