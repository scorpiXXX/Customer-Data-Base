namespace Курсовая_работа
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newClient = new System.Windows.Forms.ToolStripMenuItem();
            this.statistics = new System.Windows.Forms.ToolStripMenuItem();
            this.заТекущийМесяцToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.за3МесяцаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заГодToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заВсеВремяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательскоеЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаПоКлиентуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nameClient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kindOfActivity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameClientLB = new System.Windows.Forms.ListBox();
            this.telephoneClientBTN = new System.Windows.Forms.Button();
            this.idClientBTN = new System.Windows.Forms.Button();
            this.kindOfActivityBTN = new System.Windows.Forms.Button();
            this.telephoneClient = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newClient,
            this.statistics,
            this.запросКБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newClient
            // 
            this.newClient.Name = "newClient";
            this.newClient.Size = new System.Drawing.Size(98, 20);
            this.newClient.Text = "Новый клиент";
            this.newClient.Click += new System.EventHandler(this.newClient_Click);
            // 
            // statistics
            // 
            this.statistics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заТекущийМесяцToolStripMenuItem,
            this.за3МесяцаToolStripMenuItem,
            this.заГодToolStripMenuItem,
            this.заВсеВремяToolStripMenuItem,
            this.пользовательскоеЗначениеToolStripMenuItem,
            this.статистикаПоКлиентуToolStripMenuItem});
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(80, 20);
            this.statistics.Text = "Статистика";
            // 
            // заТекущийМесяцToolStripMenuItem
            // 
            this.заТекущийМесяцToolStripMenuItem.Name = "заТекущийМесяцToolStripMenuItem";
            this.заТекущийМесяцToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.заТекущийМесяцToolStripMenuItem.Text = "За текущий месяц";
            this.заТекущийМесяцToolStripMenuItem.Click += new System.EventHandler(this.statistics_Click);
            // 
            // за3МесяцаToolStripMenuItem
            // 
            this.за3МесяцаToolStripMenuItem.Name = "за3МесяцаToolStripMenuItem";
            this.за3МесяцаToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.за3МесяцаToolStripMenuItem.Text = "За 3 месяца";
            this.за3МесяцаToolStripMenuItem.Click += new System.EventHandler(this.за3МесяцаToolStripMenuItem_Click);
            // 
            // заГодToolStripMenuItem
            // 
            this.заГодToolStripMenuItem.Name = "заГодToolStripMenuItem";
            this.заГодToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.заГодToolStripMenuItem.Text = "За год";
            this.заГодToolStripMenuItem.Click += new System.EventHandler(this.заГодToolStripMenuItem_Click);
            // 
            // заВсеВремяToolStripMenuItem
            // 
            this.заВсеВремяToolStripMenuItem.Name = "заВсеВремяToolStripMenuItem";
            this.заВсеВремяToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.заВсеВремяToolStripMenuItem.Text = "За все время";
            this.заВсеВремяToolStripMenuItem.Click += new System.EventHandler(this.заВсеВремяToolStripMenuItem_Click);
            // 
            // пользовательскоеЗначениеToolStripMenuItem
            // 
            this.пользовательскоеЗначениеToolStripMenuItem.Name = "пользовательскоеЗначениеToolStripMenuItem";
            this.пользовательскоеЗначениеToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.пользовательскоеЗначениеToolStripMenuItem.Text = "Пользовательское значение";
            this.пользовательскоеЗначениеToolStripMenuItem.Click += new System.EventHandler(this.пользовательскоеЗначениеToolStripMenuItem_Click);
            // 
            // статистикаПоКлиентуToolStripMenuItem
            // 
            this.статистикаПоКлиентуToolStripMenuItem.Name = "статистикаПоКлиентуToolStripMenuItem";
            this.статистикаПоКлиентуToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.статистикаПоКлиентуToolStripMenuItem.Text = "Статистика по клиенту";
            this.статистикаПоКлиентуToolStripMenuItem.Click += new System.EventHandler(this.статистикаПоКлиентуToolStripMenuItem_Click);
            // 
            // запросКБДToolStripMenuItem
            // 
            this.запросКБДToolStripMenuItem.Name = "запросКБДToolStripMenuItem";
            this.запросКБДToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.запросКБДToolStripMenuItem.Text = "Запрос к БД";
            this.запросКБДToolStripMenuItem.Click += new System.EventHandler(this.запросКБДToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование организации, ИП или ФИО";
            // 
            // nameClient
            // 
            this.nameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClient.Location = new System.Drawing.Point(12, 82);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(288, 26);
            this.nameClient.TabIndex = 2;
            this.nameClient.TextChanged += new System.EventHandler(this.nameClient_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(306, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // idClient
            // 
            this.idClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idClient.Location = new System.Drawing.Point(306, 140);
            this.idClient.Name = "idClient";
            this.idClient.Size = new System.Drawing.Size(288, 26);
            this.idClient.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(306, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "№_клиента";
            // 
            // kindOfActivity
            // 
            this.kindOfActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kindOfActivity.Location = new System.Drawing.Point(306, 189);
            this.kindOfActivity.Name = "kindOfActivity";
            this.kindOfActivity.Size = new System.Drawing.Size(288, 26);
            this.kindOfActivity.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(306, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Вид деятельности";
            // 
            // nameClientLB
            // 
            this.nameClientLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClientLB.FormattingEnabled = true;
            this.nameClientLB.ItemHeight = 20;
            this.nameClientLB.Location = new System.Drawing.Point(12, 111);
            this.nameClientLB.Name = "nameClientLB";
            this.nameClientLB.Size = new System.Drawing.Size(288, 104);
            this.nameClientLB.TabIndex = 11;
            this.nameClientLB.DoubleClick += new System.EventHandler(this.nameClientLB_DoubleClick);
            // 
            // telephoneClientBTN
            // 
            this.telephoneClientBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneClientBTN.Location = new System.Drawing.Point(600, 82);
            this.telephoneClientBTN.Name = "telephoneClientBTN";
            this.telephoneClientBTN.Size = new System.Drawing.Size(86, 26);
            this.telephoneClientBTN.TabIndex = 12;
            this.telephoneClientBTN.Text = "Поиск";
            this.telephoneClientBTN.UseVisualStyleBackColor = true;
            this.telephoneClientBTN.Click += new System.EventHandler(this.telephoneClientBTN_Click);
            // 
            // idClientBTN
            // 
            this.idClientBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idClientBTN.Location = new System.Drawing.Point(600, 140);
            this.idClientBTN.Name = "idClientBTN";
            this.idClientBTN.Size = new System.Drawing.Size(86, 26);
            this.idClientBTN.TabIndex = 13;
            this.idClientBTN.Text = "Открыть";
            this.idClientBTN.UseVisualStyleBackColor = true;
            this.idClientBTN.Click += new System.EventHandler(this.idClientBTN_Click);
            // 
            // kindOfActivityBTN
            // 
            this.kindOfActivityBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kindOfActivityBTN.Location = new System.Drawing.Point(600, 187);
            this.kindOfActivityBTN.Name = "kindOfActivityBTN";
            this.kindOfActivityBTN.Size = new System.Drawing.Size(86, 28);
            this.kindOfActivityBTN.TabIndex = 15;
            this.kindOfActivityBTN.Text = "Поиск";
            this.kindOfActivityBTN.UseVisualStyleBackColor = true;
            this.kindOfActivityBTN.Click += new System.EventHandler(this.kindOfActivityBTN_Click);
            // 
            // telephoneClient
            // 
            this.telephoneClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneClient.Location = new System.Drawing.Point(306, 82);
            this.telephoneClient.Name = "telephoneClient";
            this.telephoneClient.Size = new System.Drawing.Size(288, 26);
            this.telephoneClient.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 221);
            this.Controls.Add(this.telephoneClient);
            this.Controls.Add(this.kindOfActivityBTN);
            this.Controls.Add(this.idClientBTN);
            this.Controls.Add(this.telephoneClientBTN);
            this.Controls.Add(this.nameClientLB);
            this.Controls.Add(this.kindOfActivity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idClient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newClient;
        private System.Windows.Forms.ToolStripMenuItem statistics;
        private System.Windows.Forms.ToolStripMenuItem запросКБДToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kindOfActivity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox nameClientLB;
        private System.Windows.Forms.Button telephoneClientBTN;
        private System.Windows.Forms.Button idClientBTN;
        private System.Windows.Forms.Button kindOfActivityBTN;
        private System.Windows.Forms.MaskedTextBox telephoneClient;
        private System.Windows.Forms.ToolStripMenuItem заТекущийМесяцToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem за3МесяцаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заГодToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательскоеЗначениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаПоКлиентуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заВсеВремяToolStripMenuItem;
    }
}

