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
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Курсовая_работа
{
    public partial class ClientForm : Form
    {
        Form1 form;
        public string clientName;
        public int set;
        public bool check = false;
        MaskedTextBox mtb;
        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        public ClientForm(int clientNumber, Form1 frm)
        {
            form = frm;
            set = clientNumber;
            InitializeComponent();            
            if (clientNumber == 0)
            {
                try
                {
                    this.Text = "Новый клиент";
                    MySqlConnection con = new MySqlConnection(form.connectBD);
                    con.Open();
                    string request = "select id_client from client;";
                    MySqlCommand command = new MySqlCommand(request, con);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        request = reader[0].ToString();
                    }
                    reader.Close();
                    con.Close();
                    label1.Text += (Convert.ToInt32(request) + 1).ToString();

                    contactBTN.Enabled = false;
                }
                catch
                {
                    label1.Text += "1";
                }
            }
            else
            {
                MySqlConnection con = new MySqlConnection(form.connectBD);
                con.Open();
                string request = "SELECT name from client where id_client=" + clientNumber + ";";
                MySqlCommand command = new MySqlCommand(request, con);
                clientName = command.ExecuteScalar().ToString();
                this.Text = "[" + clientNumber + "]" + clientName;
                con.Close();
                ReadData(clientNumber);
            }
            mtb = new MaskedTextBox();
            mtb.Visible = false;
            telephoneDGV.Controls.Add(mtb);

            telephoneDGV.CellBeginEdit += new DataGridViewCellCancelEventHandler(telephoneDGV_CellBeginEdit);
            telephoneDGV.CellEndEdit += new DataGridViewCellEventHandler(telephoneDGV_CellEndEdit);
            telephoneDGV.Scroll += new ScrollEventHandler(telephoneDGV_Scroll);
        }

        public void ReadData(int clientNumber)
        {
            telephoneDGV.Rows.Clear();
            noteRTB.Text = "";
            label1.Text = "ID клиента: " + clientNumber.ToString();
            MySqlConnection con = new MySqlConnection(form.connectBD);
            con.Open();
            string request = "SELECT * from client where id_client=" + clientNumber + ";";
            MySqlCommand command = new MySqlCommand(request, con);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                nameTB.Text = clientName;
                emailTB.Text = reader[2].ToString();
                webTB.Text = reader[3].ToString();
                addressTB.Text = reader[4].ToString();
                kindOfActivityTB.Text = reader[5].ToString();
                if (reader[6].ToString() == "1") typeCB.Text = "Юридическое лицо";
                else typeCB.Text = "Физическое лицо";
            }
            reader.Close();
            try
            {
                request = "SELECT note from tnote where client=" + clientNumber + ";";
                MySqlCommand command2 = new MySqlCommand(request, con);
                MySqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    noteRTB.AppendText(reader2[0].ToString());
                }
                reader2.Close();
            }
            catch { }

            request = "SELECT telephone from ttelephone where client=" + clientNumber + ";";
            MySqlCommand command3 = new MySqlCommand(request, con);
            MySqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                telephoneDGV.Rows.Add(reader3[0].ToString());
            }
            reader3.Close();




            Update(clientNumber);

            con.Close();
        }
        public void Update(int clientNumber)
        {
            MySqlConnection con = new MySqlConnection(form.connectBD);
            con.Open();
            try
            {
                string request = "SELECT social from tsocial where client=" + clientNumber + ";";
                MySqlCommand command2 = new MySqlCommand(request, con);
                command2.ExecuteNonQuery();
                if (command2.ExecuteScalar().ToString().Length >= 1)
                {
                    contactCB.Checked = true;
                    contactCB.Enabled = false;
                    contactBTN.Enabled = true;
                }
            }
            catch
            {
                contactCB.Checked = false;
                contactCB.Enabled = true;
                contactBTN.Enabled = false;
            }
            try
            {
                string request = "SELECT information from tinformation where client=" + clientNumber + ";";
                MySqlCommand command2 = new MySqlCommand(request, con);
                command2.ExecuteNonQuery();
                if (command2.ExecuteScalar().ToString().Length >= 1)
                {
                    techInfoCB.Checked = true;
                    techInfoCB.Enabled = false;
                    techInfoBTN.Enabled = true;
                }
            }
            catch
            {
                techInfoCB.Checked = false;
                techInfoCB.Enabled = true;
                techInfoBTN.Enabled = false;
            }
            try
            {
                string request = "SELECT anketa from tanketa where client=" + clientNumber + ";";
                MySqlCommand command2 = new MySqlCommand(request, con);
                command2.ExecuteNonQuery();
                if (command2.ExecuteScalar().ToString().Length >= 1)
                {
                    anketaCB.Checked = true;
                    anketaBTN.Enabled = true;
                }
            }
            catch
            {
                anketaCB.Checked = false;
                anketaBTN.Enabled = false;
            }
            serviceLB.Items.Clear();
            try
            {
                string request = "SELECT id_service,name,period_ot,period_do from tservice where client=" + clientNumber + ";";
                MySqlCommand command3 = new MySqlCommand(request, con);
                MySqlDataReader reader3 = command3.ExecuteReader();
                while (reader3.Read())
                {
                    string per_ot;
                    string per_do;
                    if (reader3[2].ToString().Substring(0, 10) == "01.01.1970") per_ot = "дата не указана";
                    else per_ot = reader3[2].ToString().Substring(0, 10);
                    if (reader3[3].ToString().Substring(0, 10) == "01.01.1970") per_do = "дата не указана";
                    else per_do = reader3[3].ToString().Substring(0, 10);
                    serviceLB.Items.Add("[" + reader3[0] + "] " + reader3[1] + " | " + per_ot + "-" + per_do);
                }
                reader3.Close();
            }
            catch
            {
            }







            con.Close();
            this.Refresh();
        }
        private void Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Save()
        {
            if (nameTB.Text == "" || typeCB.Text == "")
            {
                MessageBox.Show("Не заполнено одних из следеющих обязательных полей:\n-Имя или организация\n-Тип субъекта", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (set == 0)
                {
                    string config = "'" + nameTB.Text + "','" + emailTB.Text + "','" + webTB.Text + "','" + addressTB.Text + "','" + kindOfActivityTB.Text + "',";
                    if (typeCB.Text == "Юридическое лицо") config = config + "1";
                    else config = config + "0";
                    string request = "INSERT INTO client(name,email,site,address,kind_of_activity,type) VALUES(" + config + ");";
                    MySqlConnection con = new MySqlConnection(form.connectBD);
                    con.Open();
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();

                    request = "select id_client from client;";
                    MySqlCommand command0 = new MySqlCommand(request, con);

                    MySqlDataReader reader = command0.ExecuteReader();
                    while (reader.Read())
                    {
                        request = reader[0].ToString();
                    }
                    reader.Close();
                    int number = Convert.ToInt32(request);
                    request = "INSERT INTO tnote(note,client) VALUES('" + noteRTB.Text + "'," + number + ");";
                    MySqlCommand command2 = new MySqlCommand(request, con);
                    command2.ExecuteNonQuery();

                    foreach (DataGridViewRow row in telephoneDGV.Rows)
                    {
                        request = "INSERT INTO ttelephone(telephone,client) VALUES('" + row.Cells[0].Value.ToString() + "'," + number + ");";
                        MySqlCommand command3 = new MySqlCommand(request, con);
                        command3.ExecuteNonQuery();
                    }
                   

                    set = number;
                    con.Close();
                }
                else
                {
                    string config = "'" + nameTB.Text + "','" + emailTB.Text + "','" + webTB.Text + "','" + addressTB.Text + "','" + kindOfActivityTB.Text + "',";
                    if (typeCB.Text == "Юридическое лицо") config = config + "1";
                    else config = config + "0";
                    string request = "UPDATE client SET name='" + nameTB.Text + "',email='" + emailTB.Text + "',site='" + webTB.Text + "',address='" + addressTB.Text + "',kind_of_activity='" + kindOfActivityTB.Text;
                    if (typeCB.Text == "Юридическое лицо") request = request + "',type=1";
                    else request = request + "',type=0";
                    request += " where id_client=" + set;
                    MySqlConnection con = new MySqlConnection(form.connectBD);
                    con.Open();
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();

                    request = "SELECT id_note FROM tnote WHERE client=" + set + ";";
                    MySqlCommand command2 = new MySqlCommand(request, con);
                    command2.ExecuteNonQuery();
                    try
                    {
                        if (Convert.ToInt32(command2.ExecuteScalar().ToString()) >= 1)
                        {
                            request = "UPDATE tnote SET note='" + noteRTB.Text + "' where client=" + set + ";";
                            MySqlCommand command3 = new MySqlCommand(request, con);
                            command3.ExecuteNonQuery();
                        }
                    }
                    catch
                    {
                        request = "INSERT INTO tnote(note,client) VALUES('" + noteRTB.Text + "'," + set + ");";
                        MySqlCommand command4 = new MySqlCommand(request, con);
                        command4.ExecuteNonQuery();
                    }
                    request = "DELETE FROM ttelephone WHERE client=" + set + ";";
                    MySqlCommand command5 = new MySqlCommand(request, con);
                    command5.ExecuteNonQuery();

                    foreach (DataGridViewRow row in telephoneDGV.Rows)
                    {
                        request = "INSERT INTO ttelephone(telephone,client) VALUES('" + row.Cells[0].Value.ToString() + "'," + set + ");";
                        MySqlCommand command3 = new MySqlCommand(request, con);
                        command3.ExecuteNonQuery();
                    }

                    con.Close();
                }
                check = true;
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
            if (check)
            {
                Service ser = new Service(set,0, form, "add");
                ser.Show();
            }
        }

        private void telephoneDGV_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            mtb.Mask = "(##)###-##-##";
            Rectangle rect = telephoneDGV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
            mtb.Location = rect.Location;
            mtb.Size = rect.Size;
            mtb.Text = "";

            if(telephoneDGV[e.ColumnIndex,e.RowIndex].Value!=null)
            {
                mtb.Text = telephoneDGV[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
            mtb.Visible = true;
        }

        private void telephoneDGV_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(mtb.Visible)
            {
                telephoneDGV.CurrentCell.Value = mtb.Text;
                mtb.Visible = false;
            }
        }

        private void telephoneDGV_Scroll(object sender, ScrollEventArgs e)
        {
            if(mtb.Visible)
            {
                Rectangle rect = telephoneDGV.GetCellDisplayRectangle(telephoneDGV.CurrentCell.ColumnIndex, telephoneDGV.CurrentCell.RowIndex,true);
                mtb.Location = rect.Location;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            telephoneDGV.Rows.Add();
        }

        private void contactBTN_Click(object sender, EventArgs e)
        {
            Info inf = new Info(set, form, "open",1);
            inf.Show();
        }

        private void contactCB_Click(object sender, EventArgs e)
        {
            Save();
            if (check)
            {
                Info inf = new Info(set, form, "add",1);
                inf.Show();
            }
                contactCB.Checked = false;
        }


        private void ClientForm_Activated(object sender, EventArgs e)
        {
            Update(set);
        }

        private void techInfoCB_Click(object sender, EventArgs e)
        {
            Info inf = new Info(set, form, "add", 2);
            inf.Show();
        }

        private void techInfoBTN_Click(object sender, EventArgs e)
        {
            Save();
            if (check)
            {
                Info inf = new Info(set, form, "open", 2);
                inf.Show();
            }
            techInfoCB.Checked = false;
        }

        private void anketaCB_Click(object sender, EventArgs e)
        {
            Save();
            if (check)
            {
                
                MySqlConnection con = new MySqlConnection(form.connectBD);
                con.Open();
                if (anketaCB.Checked)
                {
                    Directory.CreateDirectory(Environment.CurrentDirectory + @"\Data\Users\user["+set+"]");
                    File.Copy(@"" + Environment.CurrentDirectory + @"\Data\Template\Анкета.docx", @""+ Environment.CurrentDirectory + @"\Data\Users\user[" + set + @"]\Анкета.docx",true);
                    string request = "INSERT INTO tanketa(anketa,client) VALUES ('true',"+set+");";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                }
                else
                {
                    Directory.Delete(Environment.CurrentDirectory + @"\Data\Users\user[" + set + "]",true);
                    string request = "DELETE FROM tanketa WHERE client="+set+";";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                }
                con.Close();
                Update(set);
            }
        }

        private void anketaBTN_Click(object sender, EventArgs e)
        {
            Process.Start(@""+ Environment.CurrentDirectory + @"\Data\Users\user[" + set + @"]");
        }

        private void serviceLB_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string result = Regex.Match(serviceLB.GetItemText(serviceLB.SelectedItem), @"\[(.*?)\]").Groups[1].Value;
                Service ser = new Service(set, Convert.ToInt32(result), form, "open");
                ser.Show();
            }
            catch
            {

            }
        }
    }
}
