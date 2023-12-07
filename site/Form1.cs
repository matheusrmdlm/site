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
    public partial class Form1 : Form
    {
        private int Id;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {

            listView1.Items.Clear();
            Connect conn = new Connect();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Cadastro";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string name = (string)dr["Nome"];
                    string email = (string)dr["Email"];
                    string tel = (string)dr["Telefone"];
                    string cpf = (string)dr["Senha"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(email);
                    lv.SubItems.Add(tel);
                    lv.SubItems.Add(cpf);
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
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
        string mensagem = "";
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {

            string valor = maskValor.Text;


            if (rdb_cpf.Checked)
            {
                if (Validacao.ValidaCPF.IsCpf(valor))
                {

                    Usuario usuario = new Usuario("Nome", "Email", "Telefone", "Senha");
                    usuario.Nome = text1.Text;
                    usuario.Email = text2.Text;
                    usuario.telefone = textm.Text;
                    usuario.senha = Criptografia.CriptografarSenha(text3.Text);

                    UsuarioDAO usuarioDAO = new UsuarioDAO();
                    usuarioDAO.InsertUsuario(usuario);
                    text1.Clear();
                    text2.Clear();
                    text3.Clear();
                    textm.Clear();

                    UpdateListView();
                }
                else
                {
                    mensagem = "O número é um CPF Inválido !";
                }
                MessageBox.Show(mensagem, "Validação");
            }


        }

        private void rdb_cpf_CheckedChanged(object sender, EventArgs e)
        {
            maskValor.Text = "";
            maskValor.Mask = "000.000.000-00";
            maskValor.MaskInputRejected += new MaskInputRejectedEventHandler(maskValor_MaskInputRejected);
        }
        void maskValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            toolTip1.ToolTipTitle = "Número informado inválido";
            toolTip1.Show("Somente digitos de (0-9) são permitidos.", maskValor, maskValor.Location, 5000);
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Border3DStyle.Flat.CompareTo(BorderStyle.None);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void textm_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            text1.Text = listView1.Items[index].SubItems[1].Text;
            text2.Text = listView1.Items[index].SubItems[2].Text;
            textm.Text = listView1.Items[index].SubItems[3].Text;
            text3.Text = listView1.Items[index].SubItems[4].Text;
        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
