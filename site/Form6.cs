using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace site
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            UsuarioDAO usuarioDao = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDao.SelectUsuario1();

            try
            {
                foreach (Usuario usuario in usuarios)
                {
                    ListViewItem lv = new ListViewItem(usuario.Id.ToString());
                    lv.SubItems.Add(usuario.rua);
                    lv.SubItems.Add(usuario.Bairro);
                    lv.SubItems.Add(usuario.Numero);

                    listView1.Items.Add(lv);

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario("Rua", "Bairro", "Numero", "CEP");
            usuario.rua = textBox1.Text;
            usuario.Bairro = textBox2.Text;
            usuario.Numero = textBox3.Text;
            usuario.cep = maskedTextBox1.Text;
            string cep = maskedTextBox1.Text;
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            using (var client = new WebClient())
            {
                var json = client.DownloadString(url);
                dynamic result = JsonConvert.DeserializeObject(json);

                if (result.erro != null)
                {
                    MessageBox.Show("CEP não encontrado.");
                    return;
                }
            }


            UsuarioDAO usuarioDAO = new UsuarioDAO();
            textBox1.Clear();
            usuarioDAO.InsertUsuario1(usuario);
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();

            UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario("Rua", "Bairro", "Numero", "CEP");
            usuario.Id = int.Parse(textBox5.Text);
            usuario.rua = textBox1.Text;
            usuario.Bairro = textBox2.Text;
            usuario.Numero = textBox3.Text;
            usuario.cep = maskedTextBox1.Text;
            string cep = maskedTextBox1.Text;
            string url = "https://viacep.com.br/ws/" + cep + "/json/";

            using (var client = new WebClient())
            {
                var json = client.DownloadString(url);
                dynamic result = JsonConvert.DeserializeObject(json);

                if (result.erro != null)
                {
                    MessageBox.Show("CEP não encontrado.");
                    return;
                }
            }
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            textBox1.Clear();
            usuarioDAO.UpdateUsuario1(usuario);
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();

            UpdateListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario("Rua", "Bairro", "Numero", "CEP");
            usuario.Id = int.Parse(textBox5.Text);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeleteUsuario1(usuario.Id);
            textBox1.Clear();
            textBox3.Clear();

            UpdateListView();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void textBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
