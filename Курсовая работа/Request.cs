using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Курсовая_работа
{
    public partial class Request : Form
    {
        Form1 mainfrm;
        public Request(Form1 frm)
        {
            InitializeComponent();
            mainfrm = frm;
        }
        public void RequestMySQL()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(mainfrm.connectBD);
                con.Open();
                string request = textBox1.Text + "\n";
                richTextBox1.AppendText(request);
                MySqlCommand command = new MySqlCommand(request, con);

                MySqlDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    richTextBox1.AppendText(reader[0].ToString()+"  |  "+ reader[1].ToString() + "  |  " + reader[2].ToString() + "  |  " + reader[3].ToString() + "  |  " + reader[4].ToString() + "  |  " + reader[5].ToString() + "  |  " + reader[6].ToString() + "\n");
                }
                reader.Close();
                //richTextBox1.AppendText(command.ExecuteScalar().ToString()+"\n");
                con.Close();
                textBox1.Text = "";
            }
            catch
            {
                richTextBox1.AppendText("Syntax Error!\n");
                textBox1.Text = "";
            }
        }
        private void okBTN_Click(object sender, EventArgs e)
        {
            RequestMySQL();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                RequestMySQL();
            }
        }
    }
}
