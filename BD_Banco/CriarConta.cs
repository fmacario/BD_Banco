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
    public partial class CriarConta : Form
    {
        public CriarConta()
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
        private void CriarConta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBInit.init();
            using (SqlCommand cmd = new SqlCommand("CriarConta", DBInit.getmyConn()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nCC", SqlDbType.Int).Value = textBox1.Text;
                if (comboBox1.Text == "Prazo")
                    cmd.Parameters.Add("@juros", SqlDbType.Decimal).Value = textBox2.Text;
                else if (comboBox1.Text == "Ordem")
                    cmd.Parameters.Add("@juros", SqlDbType.Decimal).Value = 0.0;

                if (checkBox1.Checked)
                    cmd.Parameters.Add("@admin", SqlDbType.Bit).Value = 1;
                else
                    cmd.Parameters.Add("@admin", SqlDbType.Bit).Value = 0;


                cmd.Parameters.Add("@saldo", SqlDbType.Decimal).Value = textBox3.Text;


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Conta criada com sucesso", "Sucesso!");
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.ToString());
                }


            }

            DBInit.close();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Prazo")
            {
                label3.Show();
                textBox2.Show();
            }
            else
            {
                label3.Hide();
                textBox2.Hide();
            }
        }
    }
}
