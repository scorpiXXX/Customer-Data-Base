using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace Курсовая_работа
{
    public partial class Info : Form
    {
        public int clientNumber;
        Form1 form;
        public string mode;
        public int window;
        public Info(int set, Form1 frm,string status,int win)
        {
            InitializeComponent();
            clientNumber = set;
            form = frm;
            mode = status;
            window = win;
            if (status == "open") Open();
        }
        public void Open()
        {
            MySqlConnection con = new MySqlConnection(form.connectBD);
            con.Open();
            if (window == 1)
            {
                string request = "SELECT social from tsocial where client=" + clientNumber + ";";
                MySqlCommand command = new MySqlCommand(request, con);
                command.ExecuteNonQuery();
                textRTB.Text = command.ExecuteScalar().ToString();
            }
            if (window == 2)
            {
                string request = "SELECT information from tinformation where client=" + clientNumber + ";";
                MySqlCommand command = new MySqlCommand(request, con);
                command.ExecuteNonQuery();
                textRTB.Text = command.ExecuteScalar().ToString();
            }
            con.Close();
        }
        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(form.connectBD);
            con.Open();
            if (window == 1)
            {
                if (mode == "add")
                {
                    string request = "INSERT INTO tsocial(social,client) VALUES('" + textRTB.Text + "'," + clientNumber + ");";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                }
                else
                {
                    string request = "DELETE FROM tsocial where client=" + clientNumber + ";";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                    if (textRTB.Text.Length != 0)
                    {
                        request = "INSERT INTO tsocial(social,client) VALUES('" + textRTB.Text + "'," + clientNumber + ");";
                        MySqlCommand command2 = new MySqlCommand(request, con);
                        command2.ExecuteNonQuery();
                    }
                }
            }
            if (window == 2)
            {
                if (mode == "add")
                {
                    string request = "INSERT INTO tinformation(information,client) VALUES('" + textRTB.Text + "'," + clientNumber + ");";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                }
                else
                {
                    string request = "DELETE FROM tinformation where client=" + clientNumber + ";";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                    if (textRTB.Text.Length != 0)
                    {
                        request = "INSERT INTO tinformation(information,client) VALUES('" + textRTB.Text + "'," + clientNumber + ");";
                        MySqlCommand command2 = new MySqlCommand(request, con);
                        command2.ExecuteNonQuery();
                    }
                }
            }
            con.Close();
            this.Close();
        }
    }
}
