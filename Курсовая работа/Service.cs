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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;

namespace Курсовая_работа
{
    public partial class Service : Form
    {
        public int serviceNumber;
        public int clientNumber;
        Form1 form;
        public string mode;
        public bool check = false;
        public Service(int people, int set, Form1 frm, string type)
        {
            InitializeComponent();
            serviceNumber = set;
            clientNumber = people;
            form = frm;
            mode = type;
            periodTB.Mask = "[##-##-####]-[##-##-####]";
            try
            {
                if (serviceNumber == 0)
                {
                    this.Text = "Новая услуга";
                    MySqlConnection con = new MySqlConnection(form.connectBD);
                    con.Open();
                    string request = "select id_service from tservice;";
                    MySqlCommand command = new MySqlCommand(request, con);

                    MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        request = reader[0].ToString();
                    }
                    reader.Close();
                    con.Close();
                    serviceNumber = (Convert.ToInt32(request) + 1);
                }
                else
                {
                    Open();
                }
            }
            catch
            {
                serviceNumber = 1;
            }

        }
        public void Open()
        {
            MySqlConnection con = new MySqlConnection(form.connectBD);
            con.Open();

            string request = "SELECT client,name,description,price,period_ot,period_do,type,yesorno FROM tservice WHERE id_service="+serviceNumber+";";
            MySqlCommand command = new MySqlCommand(request, con);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                serviceName.Text = reader[1].ToString();
                noteService.Text = reader[2].ToString();
                priceService.Text = reader[3].ToString();
                string date= Regex.Replace(reader[4].ToString().Substring(0,10), @"[^\d]+", "")+ Regex.Replace(reader[5].ToString().Substring(0, 10), @"[^\d]+", "");
                if(date!="1970010119700101")periodTB.Text = date;
                if(date!="1970010119700101")periodTB.Text = date;

                if (reader[6].ToString() == "1") typeService.Text = "Сайт";
                if (reader[6].ToString() == "2") typeService.Text = "Хостинг";
                if (reader[6].ToString() == "3") typeService.Text = "Рекламная компания";
                if (reader[6].ToString() == "4") typeService.Text = "Домен";
                if (reader[7].ToString() == "true") checkBox1.Checked = true;
            }
            reader.Close();


            request = "SELECT predoplata,yesorno FROM tpredoplata WHERE service=" + serviceNumber + ";";
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                prePriceService.Text = reader[0].ToString();
                checkBox2.Checked = Convert.ToBoolean(reader[1].ToString());
            }
            reader.Close();

            int i = 0;//Счетчик созданных документов

            request = "SELECT dogovor FROM tdogovor WHERE service="+serviceNumber;
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {                
                if (Convert.ToBoolean(reader[0].ToString()))
                {
                    dogovorCB.Checked = true;
                    dogovorCB.Enabled = false;
                    i++;
                }
            }
            reader.Close();

            request = "SELECT act FROM tact WHERE service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (Convert.ToBoolean(reader[0].ToString()))
                {
                    actCB.Checked = true;
                    actCB.Enabled = false;
                    i++;
                }
            }
            reader.Close();

            request = "SELECT service_list FROM tservice_list WHERE service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                if (Convert.ToBoolean(reader[0].ToString()))
                {
                    priceCB.Checked = true;
                    priceCB.Enabled = false;
                    i++;
                }
            }
            reader.Close();

            request = "SELECT tz FROM ttz WHERE service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            reader = command.ExecuteReader();
            while (reader.Read())
            {

                if (Convert.ToBoolean(reader[0].ToString()))
                {
                    tzCB.Checked = true;
                    tzCB.Enabled = false;
                    i++;
                }
            }
            reader.Close();
            con.Close();

            if (i > 0) openBTN.Enabled = true;
        }
        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SaveService()
        {
            if (serviceName.Text.Length >= 2 && typeService.Text != "")
            {
                if (mode == "open")
                {
                    MySqlConnection con = new MySqlConnection(form.connectBD);
                    con.Open();
                    string dataAndType = Regex.Replace(periodTB.Text, @"[^\d]+", "");
                    if (dataAndType.Length > 0) dataAndType = "period_ot= STR_TO_DATE('"+dataAndType.Substring(0, 8)+"', '%d%m%Y')" + ",period_do= STR_TO_DATE('"+dataAndType.Substring(8, 8)+"', '%d%m%Y'),";
                    else dataAndType = "period_ot= STR_TO_DATE('01011970', '%d%m%Y'),period_do= STR_TO_DATE('01011970', '%d%m%Y'),";
                    if (typeService.Text == "Сайт") dataAndType += "type=1";
                    if (typeService.Text == "Хостинг") dataAndType += "type=2";
                    if (typeService.Text == "Рекламная компания") dataAndType += "type=3";
                    if (typeService.Text == "Домен") dataAndType += "type=4";
                    if (checkBox1.Checked) dataAndType += ",yesorno='true'";
                    else dataAndType += ",yesorno='false'";

                    if (noteService.Text == "") noteService.Text = " ";
                    if (priceService.Text == "") priceService.Text = "0";

                    string request = "UPDATE tservice SET name='" + serviceName.Text + "',description='" + noteService.Text + "',price=" + Convert.ToInt32(priceService.Text) + "," + dataAndType + " WHERE id_service=" + serviceNumber + ";";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();

                    if (prePriceService.Text.Length >= 1)
                    {
                        if (checkBox2.Checked) dataAndType = "true";
                        else dataAndType = "false";

                        request = "SELECT predoplata FROM tpredoplata WHERE service=" + serviceNumber + ";";
                        command = new MySqlCommand(request, con);
                        MySqlDataReader reader = command.ExecuteReader();
                        int i = 0;
                        while (reader.Read())
                        {
                            i++;
                        }
                        reader.Close();
                        if(i>0)
                            request = "UPDATE tpredoplata SET predoplata=" + prePriceService.Text + ",yesorno='" + dataAndType + "' WHERE service = " + serviceNumber + ";";
                        if (i == 0)
                            request = "INSERT INTO tpredoplata(predoplata,yesorno,service) VALUE("+prePriceService.Text+",'"+dataAndType+"',"+serviceNumber+");";
                        command = new MySqlCommand(request, con);
                        command.ExecuteNonQuery();
                    }

                    con.Close();
                }
                if (mode == "add")
                {
                        if (serviceName.Text.Length >= 1 && typeService.Text.Length >= 1)
                        {
                            MySqlConnection con = new MySqlConnection(form.connectBD);
                            con.Open();
                            string dataAndType = Regex.Replace(periodTB.Text, @"[^\d]+", "");
                            if (dataAndType.Length == 8) dataAndType = " STR_TO_DATE('"+dataAndType.Substring(0, 8)+"', '%d%m%Y')" + "," + " STR_TO_DATE('"+dataAndType.Substring(8, 8)+"', '%d%m%Y'),";
                            else dataAndType = "19700101,19700101,";
                            if (typeService.Text == "Сайт") dataAndType += "1";
                            if (typeService.Text == "Хостинг") dataAndType += "2";
                            if (typeService.Text == "Рекламная компания") dataAndType += "3";
                            if (typeService.Text == "Домен") dataAndType += "4";
                            if (checkBox1.Checked) dataAndType += ",'true'";
                            else dataAndType += ",'false'";

                            if (noteService.Text == "") noteService.Text = " ";
                            if (priceService.Text == "") priceService.Text = "0";

                            string request = "INSERT INTO tservice(client,name,description,price,period_ot,period_do,type,yesorno) VALUES(" + clientNumber + ",'" + serviceName.Text + "','" + noteService.Text + "'," + Convert.ToInt32(priceService.Text) + "," + dataAndType + ");";
                            MySqlCommand command = new MySqlCommand(request, con);
                            command.ExecuteNonQuery();
                            con.Close();
                            con = new MySqlConnection(form.connectBD);
                            con.Open();
                            if (prePriceService.Text.Length >= 1 && prePriceService.Text != "0")
                            {
                                if (checkBox2.Checked) dataAndType = "true";
                                else dataAndType = "false";
                                request = "INSERT INTO tpredoplata(predoplata,service,yesorno) VALUES(" + prePriceService.Text + "," + serviceNumber + ",'" + dataAndType + "');";
                                command = new MySqlCommand(request, con);
                                command.ExecuteNonQuery();
                            }
                            con.Close();
                        }
                }
                check = true;
            }
            else
            {
                MessageBox.Show("Не заолнено одно или несколько обязательных полей: Наименование услуги, тип услуги.", "Ошибка!");
            }
        }
        private void saveBTN_Click(object sender, EventArgs e)
        {
            SaveService();
            this.Close();
        }
        public void AddDocument(string documentName)
        {            
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\Data\Users\user[" + clientNumber + @"]\service["+serviceNumber+"]");
            File.Copy(@"" + Environment.CurrentDirectory + @"\Data\Template\Анкета.docx", @"" + Environment.CurrentDirectory + @"\Data\Users\user[" + clientNumber + @"]\service["+serviceNumber+@"]\"+documentName+".docx", true);
        }
        private void createBTN_Click(object sender, EventArgs e)
        {
            SaveService();
            if (check)
            {
                mode = "open";
                MySqlConnection con = new MySqlConnection(form.connectBD);
                con.Open();
                if (dogovorCB.Checked && dogovorCB.Enabled)
                {
                    AddDocument("Договор");
                    string request = "INSERT INTO tdogovor(dogovor,service) VALUES ('true'," + serviceNumber + ");";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                    openBTN.Enabled = true;
                }
                if (priceCB.Checked && priceCB.Enabled)
                {
                    AddDocument("Перечень услуг");
                    string request = "INSERT INTO tservice_list(service_list,service) VALUES ('true'," + serviceNumber + ");";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                    openBTN.Enabled = true;
                }
                if (tzCB.Checked && tzCB.Enabled)
                {
                    AddDocument("ТЗ");
                    string request = "INSERT INTO ttz(tz,service) VALUES ('true'," + serviceNumber + ");";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                    openBTN.Enabled = true;
                }
                if (actCB.Checked && actCB.Enabled)
                {
                    AddDocument("Акт сдачи-приема");
                    string request = "INSERT INTO tact(act,service) VALUES ('true'," + serviceNumber + ");";
                    MySqlCommand command = new MySqlCommand(request, con);
                    command.ExecuteNonQuery();
                    openBTN.Enabled = true;
                }
                con.Close();
            }
        }

        private void openBTN_Click(object sender, EventArgs e)
        {
            Process.Start(@"" + Environment.CurrentDirectory + @"\Data\Users\user[" + clientNumber + @"]\service["+serviceNumber+"]");
        }

        private void deleteService_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(form.connectBD);
            con.Open();

            string request = "DELETE FROM tdogovor WHERE service="+serviceNumber;
            MySqlCommand command = new MySqlCommand(request, con);
            command.ExecuteScalar();
            request = "DELETE FROM tservice_list WHERE service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            command.ExecuteScalar();
            request = "DELETE FROM tact WHERE service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            command.ExecuteScalar();
            request = "DELETE FROM ttz WHERE service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            command.ExecuteScalar();
            request = "DELETE FROM tpredoplata WHERE service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            command.ExecuteScalar();
            request = "DELETE FROM tservice WHERE id_service=" + serviceNumber;
            command = new MySqlCommand(request, con);
            command.ExecuteScalar();
            con.Close();
            this.Close();
        }
    }
}
