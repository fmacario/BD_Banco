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
    public partial class AdicionarCliente : Form
    {
        public AdicionarCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DBInit.init();
            using (SqlCommand cmd = new SqlCommand("InserirCliente", DBInit.getmyConn()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nCC", SqlDbType.Int).Value = textBox1.Text;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 40).Value = textBox2.Text;
                cmd.Parameters.Add("@dataNasc", SqlDbType.Date).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@morada", SqlDbType.VarChar, 50).Value = textBox3.Text;
                cmd.Parameters.Add("@nCont", SqlDbType.Int).Value = textBox4.Text;
                cmd.Parameters.Add("@nTelefone", SqlDbType.Int).Value = textBox5.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente adicionado com sucesso", "Sucesso!");
            }

            DBInit.close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
