using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BD_Banco
{
    public partial class Emprestimo : Form
    {
        public Emprestimo()
        {
            InitializeComponent();
        }

        private void criarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdicionarCliente f = new AdicionarCliente();
            f.Show();
            //this.Hide();
        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarClientes f = new MostrarClientes();
            f.Show();
            //this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mostrarEmpregadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFuncionarios f = new MostrarFuncionarios();
            f.Show();
        }

        private void novoEmpréstimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Emprestimo f = new Emprestimo();
            f.Show();
        }

        private void criarOperaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operacoes f = new Operacoes();
            f.Show();
        }

        private void criarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CriarConta f = new CriarConta();
            f.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DBInit.init();
            using (SqlCommand cmd = new SqlCommand("FazerEmprestimo", DBInit.getmyConn()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@quantia", SqlDbType.Decimal).Value = textBox1.Text;
                cmd.Parameters.Add("@juro", SqlDbType.Decimal).Value = textBox2.Text;
                cmd.Parameters.Add("@prazo", SqlDbType.Date).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@nCC", SqlDbType.Int).Value = textBox3.Text;
                cmd.Parameters.Add("@nConta", SqlDbType.BigInt).Value = textBox4.Text;
                cmd.Parameters.Add("@nFuncionario", SqlDbType.Int).Value = textBox5.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Empréstimo executado com sucesso", "Sucesso!");
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }         
            }

            DBInit.close();
        }
    }
}
