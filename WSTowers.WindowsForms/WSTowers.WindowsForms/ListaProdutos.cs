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
    public partial class ListaProdutos : Form
    {
        private WSTowersEntities context = new WSTowersEntities();
        public ListaProdutos()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(17, 40, 104);

            var lista = context.produto.Select(x => new
            {
                produto1 = x,
                produto = x.produto1,
                valor = "R$ " + x.valor + ",00",
                categoria = x.categoria.categoria1
            }).ToList();

            dgv.DataSource = lista;

            dgv.Columns["produto1"].Visible = false;

            for (int i = 0; i < 20; i++)
            { 
                var produto = dgv.Rows[i].Cells[0].Value as produto;
                    dgv.Rows[i].Cells[0].Style.BackColor = Color.Blue;
                    dgv.Rows[i].Cells[1].Style.BackColor = Color.Blue;
                    dgv.Rows[i].Cells[2].Style.BackColor = Color.Blue;
                    dgv.Rows[i].Cells[3].Style.BackColor = Color.Blue;
            }
        }
    }
}
