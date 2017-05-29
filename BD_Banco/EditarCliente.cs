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
    public partial class EditarCliente : Form
    {
        string nCC;
        public EditarCliente(string s)
        {
            this.nCC = s;
            InitializeComponent();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            DBInit.init();
            using (SqlCommand cmd = new SqlCommand("PesquisaClientes", DBInit.getmyConn()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nCC", this.nCC);
                
                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 40);
                cmd.Parameters["@nome"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@dataNasc", SqlDbType.Date);
                cmd.Parameters["@dataNasc"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@morada", SqlDbType.VarChar, 50);
                cmd.Parameters["@morada"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@nCont", SqlDbType.Int);
                cmd.Parameters["@nCont"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@nTelefone", SqlDbType.Int);
                cmd.Parameters["@nTelefone"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@nCliente", SqlDbType.Int);
                cmd.Parameters["@nCliente"].Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@dataAdesao", SqlDbType.Date);
                cmd.Parameters["@dataAdesao"].Direction = ParameterDirection.Output;

                DBInit.init();
                cmd.ExecuteNonQuery();
                DBInit.close();

                textBox1.Text = cmd.Parameters["@nCC"].Value.ToString();
                textBox2.Text = cmd.Parameters["@nome"].Value.ToString();

                int dia = Convert.ToInt16(cmd.Parameters["@dataNasc"].Value.ToString().Substring(0, 2));
                int mes = Convert.ToInt16(cmd.Parameters["@dataNasc"].Value.ToString().Substring(3, 2));
                int ano = Convert.ToInt16(cmd.Parameters["@dataNasc"].Value.ToString().Substring(6, 4));
                
                dateTimePicker1.Value = new DateTime (ano, mes, dia);
                  
                textBox3.Text = cmd.Parameters["@morada"].Value.ToString();
                textBox4.Text = cmd.Parameters["@nCont"].Value.ToString();
                textBox5.Text = cmd.Parameters["@nTelefone"].Value.ToString();
                //MessageBox.Show("" + dia+" "+mes+" "+ano);
            }

            DBInit.close();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            DBInit.init();
            using (SqlCommand cmd = new SqlCommand("updateCliente", DBInit.getmyConn()))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nCC", SqlDbType.Int).Value = textBox1.Text;
                cmd.Parameters.Add("@nome", SqlDbType.VarChar, 40).Value = textBox2.Text;
                cmd.Parameters.Add("@dataNasc", SqlDbType.Date).Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@morada", SqlDbType.VarChar, 50).Value = textBox3.Text;
                cmd.Parameters.Add("@nCont", SqlDbType.Int).Value = textBox4.Text;
                cmd.Parameters.Add("@nTelefone", SqlDbType.Int).Value = textBox5.Text;

                cmd.ExecuteNonQuery();
                DBInit.close();
                MessageBox.Show("Cliente alterado com sucesso", "Sucesso!");
            }

            
        }
    }
}
