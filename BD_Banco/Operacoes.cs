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
    public partial class Operacoes : Form
    {
        public Operacoes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void Operacoes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBInit.init();
            using (SqlCommand cmd = new SqlCommand("FazerDepositoBalcao", DBInit.getmyConn()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@quantia", SqlDbType.Decimal).Value = textBox1.Text;
                cmd.Parameters.Add("@nCliente", SqlDbType.Int).Value = textBox2.Text;
                cmd.Parameters.Add("@nBalcao", SqlDbType.Int).Value = textBox3.Text;
                cmd.Parameters.Add("@nConta", SqlDbType.BigInt).Value = textBox4.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Depósito realizado com sucesso", "Sucesso!");
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }

            }

            DBInit.close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBInit.init();
            using (SqlCommand cmd = new SqlCommand("FazerTransferencia", DBInit.getmyConn()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@quantia", SqlDbType.Decimal).Value = textBox8.Text;
                cmd.Parameters.Add("@nCartao", SqlDbType.BigInt).Value = textBox7.Text;
                cmd.Parameters.Add("@nContaDestino", SqlDbType.BigInt).Value = textBox6.Text;
                cmd.Parameters.Add("@nContaDono", SqlDbType.BigInt).Value = textBox5.Text;

                
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Transferência realizada com sucesso", "Sucesso!");
                

            }

            DBInit.close();
        }
    }
}
