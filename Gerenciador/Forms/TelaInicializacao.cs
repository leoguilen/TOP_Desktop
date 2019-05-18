using Gerenciador.Classes.ObjetosBanco;
using Gerenciador.Classes.ObjetosDataSet;
using Gerenciador.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador.Forms
{
    public partial class TelaInicializacao : Form
    {
        public TelaInicializacao()
        {
            InitializeComponent();
            //new Gerenciador().ShowDialog();
        }

        private bd_top bd;
        private BancoDesconectado bDesc;
        private Banco banco;
        private Thread t;

        private void TelaSplash_Load_1(object sender, EventArgs e)
        {
            bd = new bd_top();
            bDesc = new BancoDesconectado(bd.Database.Connection.ConnectionString);
            banco = new Banco(bd);

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;

            t = new Thread(new ThreadStart(Inicialização));
            t.Start();
            timerProgressBar.Start();
        }
        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            Inicialização();
        }

        private void Inicialização()
        {
            banco = new Banco();

            if (progressBar1.Value > 10 && progressBar1.Value < 30)
            {
                labelProgressBar.Text = "Carregando bibliotecas e classes";
            }
            else if (progressBar1.Value > 40 && progressBar1.Value < 60)
            {
                if (banco.abrirConexao().Contains("Erro"))
                {
                    timerProgressBar.Stop();
                    labelProgressBar.ForeColor = Color.Red;
                    labelProgressBar.Text = "Houve um problema ao estabelecer a conexão com o banco";
                    banco.fecharConexao();
                    t.Abort();
                }
                else
                {
                    labelProgressBar.Text = "Estabelecendo conexão com o banco";

                }
            }
            else if (progressBar1.Value > 70 && progressBar1.Value < 90)
            {
                labelProgressBar.Text = "Terminando configuração da aplicação";
            }

            else if (progressBar1.Value > 90)
            {
                labelProgressBar.Text = "Abrindo sistema";

                if (progressBar1.Value == 100)
                {
                    timerProgressBar.Stop();
                    Thread.Sleep(500);
                    this.Visible = false;
                    new Gerenciador().ShowDialog();
                    t.Abort();
                }
            }



        }

    }
}
