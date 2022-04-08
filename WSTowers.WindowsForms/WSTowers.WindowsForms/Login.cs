using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WSTowers.WindowsForms
{
    public partial class Login : Form
    {
        public WSTowersEntities context = new WSTowersEntities();
        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(17, 40, 104);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (VerifyUserAndPassword(this.User.Text, this.Senha.Text) == null)
            {
                MessageBox.Show("Email ou senha incorretos");
                return;
            }
            this.Hide();
            ListaProdutos form = new ListaProdutos();
            form.Show();
        }

        private participante VerifyUserAndPassword(string user, string password)
        {
            string sobrenome = user.Substring(1, user.Length - 1);

            return context.participante.FirstOrDefault(x => x.nome.Substring(0, 1) == user.Substring(0, 1) &&
                                                     x.nome.Trim().Contains(" " + sobrenome) &&
                                                     x.cidade.estado.Sigla == password.Substring(0, 2) &&
                                                     x.genero.genero1 == password.Substring(2, 1) &&
                                                     x.idade.ToString() == password.Substring(3, 2));
        }
    }
}
