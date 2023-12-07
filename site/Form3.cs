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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace site
{
    public partial class Form3 : Form
    {
        private int Id;
        public Form3()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> usuarios = usuarioDAO.SelectUsuario();

            foreach (Usuario usuario in usuarios)
            {
                ListViewItem item = new ListViewItem(usuario.Id.ToString());
                item.SubItems.Add(usuario.Nome);
                item.SubItems.Add(usuario.Email);
                item.SubItems.Add(usuario.telefone);
                item.SubItems.Add(usuario.senha);
                listView1.Items.Add(item);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario("Nome", "Email", "Telefone", "Senha");
            usuario.Id = int.Parse(Txt.Text);
            usuario.Nome = text1.Text;
            usuario.Email = text2.Text;
            usuario.telefone = textm.Text;
            usuario.senha = Criptografia.CriptografarSenha(text3.Text);

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.UpdateUsuario(usuario);
            text1.Clear();
            text2.Clear();
            text3.Clear();
            textm.Clear();
            Txt.Clear();

            UpdateListView();

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            Id = int.Parse(listView1.Items[index].SubItems[0].Text);
            Txt.Text = (listView1.Items[index].SubItems[0].Text);
            text1.Text = listView1.Items[index].SubItems[1].Text;
            text2.Text = listView1.Items[index].SubItems[2].Text;
            textm.Text = listView1.Items[index].SubItems[3].Text;
            text3.Text = listView1.Items[index].SubItems[4].Text;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txt.Text);
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            usuarioDAO.DeletUsuario(id);
            text1.Clear();
            text2.Clear();
            text3.Clear();
            textm.Clear();
            Txt.Clear();
        }

        private void text10_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
