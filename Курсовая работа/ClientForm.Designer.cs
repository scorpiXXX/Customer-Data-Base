namespace Курсовая_работа
{
    partial class ClientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.telephoneDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kindOfActivityTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.webTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contactBTN = new System.Windows.Forms.Button();
            this.anketaBTN = new System.Windows.Forms.Button();
            this.techInfoBTN = new System.Windows.Forms.Button();
            this.techInfoCB = new System.Windows.Forms.CheckBox();
            this.anketaCB = new System.Windows.Forms.CheckBox();
            this.contactCB = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.noteRTB = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.serviceLB = new System.Windows.Forms.ListBox();
            this.addService = new System.Windows.Forms.Button();
            this.Cansel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDGV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.telephoneDGV);
            this.groupBox1.Controls.Add(this.typeCB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.kindOfActivityTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.addressTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.webTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "О клиенте";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(375, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 73);
            this.button2.TabIndex = 5;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // telephoneDGV
            // 
            this.telephoneDGV.AllowUserToAddRows = false;
            this.telephoneDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telephoneDGV.ColumnHeadersVisible = false;
            this.telephoneDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.telephoneDGV.Location = new System.Drawing.Point(163, 65);
            this.telephoneDGV.Name = "telephoneDGV";
            this.telephoneDGV.RowHeadersVisible = false;
            this.telephoneDGV.Size = new System.Drawing.Size(206, 73);
            this.telephoneDGV.TabIndex = 15;
            this.telephoneDGV.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.telephoneDGV_CellBeginEdit);
            this.telephoneDGV.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.telephoneDGV_CellEndEdit);
            this.telephoneDGV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.telephoneDGV_Scroll);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Телефон";
            this.Column1.Name = "Column1";
            this.Column1.Width = 203;
            // 
            // typeCB
            // 
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.typeCB.Location = new System.Drawing.Point(163, 272);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(253, 28);
            this.typeCB.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Тип субъекта";
            // 
            // kindOfActivityTB
            // 
            this.kindOfActivityTB.Location = new System.Drawing.Point(163, 240);
            this.kindOfActivityTB.Name = "kindOfActivityTB";
            this.kindOfActivityTB.Size = new System.Drawing.Size(253, 26);
            this.kindOfActivityTB.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Вид деятельности";
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(163, 208);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(253, 26);
            this.addressTB.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Адрес (город,улица,дом)";
            // 
            // webTB
            // 
            this.webTB.Location = new System.Drawing.Point(163, 176);
            this.webTB.Name = "webTB";
            this.webTB.Size = new System.Drawing.Size(253, 26);
            this.webTB.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "WEB сайт";
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(163, 144);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(253, 26);
            this.emailTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Телефоны            +375";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(163, 36);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(253, 26);
            this.nameTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя или организация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID клиента: ";
            this.label1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.contactBTN);
            this.groupBox2.Controls.Add(this.anketaBTN);
            this.groupBox2.Controls.Add(this.techInfoBTN);
            this.groupBox2.Controls.Add(this.techInfoCB);
            this.groupBox2.Controls.Add(this.anketaCB);
            this.groupBox2.Controls.Add(this.contactCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 124);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительная информация";
            // 
            // contactBTN
            // 
            this.contactBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactBTN.Location = new System.Drawing.Point(325, 22);
            this.contactBTN.Name = "contactBTN";
            this.contactBTN.Size = new System.Drawing.Size(91, 23);
            this.contactBTN.TabIndex = 6;
            this.contactBTN.Text = "Открыть";
            this.contactBTN.UseVisualStyleBackColor = true;
            this.contactBTN.Click += new System.EventHandler(this.contactBTN_Click);
            // 
            // anketaBTN
            // 
            this.anketaBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anketaBTN.Location = new System.Drawing.Point(325, 53);
            this.anketaBTN.Name = "anketaBTN";
            this.anketaBTN.Size = new System.Drawing.Size(91, 23);
            this.anketaBTN.TabIndex = 5;
            this.anketaBTN.Text = "Открыть";
            this.anketaBTN.UseVisualStyleBackColor = true;
            this.anketaBTN.Click += new System.EventHandler(this.anketaBTN_Click);
            // 
            // techInfoBTN
            // 
            this.techInfoBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.techInfoBTN.Location = new System.Drawing.Point(325, 83);
            this.techInfoBTN.Name = "techInfoBTN";
            this.techInfoBTN.Size = new System.Drawing.Size(91, 23);
            this.techInfoBTN.TabIndex = 4;
            this.techInfoBTN.Text = "Открыть";
            this.techInfoBTN.UseVisualStyleBackColor = true;
            this.techInfoBTN.Click += new System.EventHandler(this.techInfoBTN_Click);
            // 
            // techInfoCB
            // 
            this.techInfoCB.AutoSize = true;
            this.techInfoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.techInfoCB.Location = new System.Drawing.Point(6, 85);
            this.techInfoCB.Name = "techInfoCB";
            this.techInfoCB.Size = new System.Drawing.Size(313, 21);
            this.techInfoCB.TabIndex = 2;
            this.techInfoCB.Text = "Логины, пароли и прочая тех. информация";
            this.techInfoCB.UseVisualStyleBackColor = true;
            this.techInfoCB.Click += new System.EventHandler(this.techInfoCB_Click);
            // 
            // anketaCB
            // 
            this.anketaCB.AutoSize = true;
            this.anketaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.anketaCB.Location = new System.Drawing.Point(6, 55);
            this.anketaCB.Name = "anketaCB";
            this.anketaCB.Size = new System.Drawing.Size(132, 21);
            this.anketaCB.TabIndex = 1;
            this.anketaCB.Text = "Анкета клиента";
            this.anketaCB.UseVisualStyleBackColor = true;
            this.anketaCB.Click += new System.EventHandler(this.anketaCB_Click);
            // 
            // contactCB
            // 
            this.contactCB.AutoSize = true;
            this.contactCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactCB.Location = new System.Drawing.Point(6, 25);
            this.contactCB.Name = "contactCB";
            this.contactCB.Size = new System.Drawing.Size(260, 21);
            this.contactCB.TabIndex = 0;
            this.contactCB.Text = "Контактная информация(соц.сети)";
            this.contactCB.UseVisualStyleBackColor = true;
            this.contactCB.Click += new System.EventHandler(this.contactCB_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.noteRTB);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(440, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 124);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Заметки";
            // 
            // noteRTB
            // 
            this.noteRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteRTB.Location = new System.Drawing.Point(3, 22);
            this.noteRTB.Name = "noteRTB";
            this.noteRTB.Size = new System.Drawing.Size(416, 99);
            this.noteRTB.TabIndex = 0;
            this.noteRTB.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.serviceLB);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(440, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 277);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Оказанные услуги";
            // 
            // serviceLB
            // 
            this.serviceLB.FormattingEnabled = true;
            this.serviceLB.ItemHeight = 20;
            this.serviceLB.Location = new System.Drawing.Point(6, 25);
            this.serviceLB.Name = "serviceLB";
            this.serviceLB.Size = new System.Drawing.Size(410, 244);
            this.serviceLB.TabIndex = 0;
            this.serviceLB.DoubleClick += new System.EventHandler(this.serviceLB_DoubleClick);
            // 
            // addService
            // 
            this.addService.Location = new System.Drawing.Point(440, 295);
            this.addService.Name = "addService";
            this.addService.Size = new System.Drawing.Size(422, 23);
            this.addService.TabIndex = 4;
            this.addService.Text = "Добавить услугу";
            this.addService.UseVisualStyleBackColor = true;
            this.addService.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cansel
            // 
            this.Cansel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cansel.Location = new System.Drawing.Point(12, 454);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(369, 31);
            this.Cansel.TabIndex = 5;
            this.Cansel.Text = "Отменить";
            this.Cansel.UseVisualStyleBackColor = true;
            this.Cansel.Click += new System.EventHandler(this.Cansel_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.Location = new System.Drawing.Point(486, 454);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(376, 31);
            this.save.TabIndex = 6;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBTN.Location = new System.Drawing.Point(387, 454);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(93, 31);
            this.deleteBTN.TabIndex = 7;
            this.deleteBTN.Text = "Удалить";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 497);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Cansel);
            this.Controls.Add(this.addService);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.Activated += new System.EventHandler(this.ClientForm_Activated);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telephoneDGV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addService;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kindOfActivityTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox webTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox noteRTB;
        private System.Windows.Forms.ListBox serviceLB;
        private System.Windows.Forms.CheckBox techInfoCB;
        private System.Windows.Forms.CheckBox anketaCB;
        private System.Windows.Forms.CheckBox contactCB;
        private System.Windows.Forms.DataGridView telephoneDGV;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button contactBTN;
        private System.Windows.Forms.Button anketaBTN;
        private System.Windows.Forms.Button techInfoBTN;
        private System.Windows.Forms.Button deleteBTN;
    }
}