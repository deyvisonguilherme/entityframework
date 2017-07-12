using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class Form1 : Form
    {
        private ProductDbContext context;

        public Form1()
        {
            InitializeComponent();

            context = new ProductDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Nome = "Loja teste DevMedia"
            };
            context.Lojas.Add(loja);

            Produto produto = new Produto()
            {
                Nome = "Produto teste DevMedia",
                Valor = 20m,
                Loja = loja
            };
            context.Produtos.Add(produto);

            context.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loja loja = context.Lojas.Find(1);
        }
    }
}
