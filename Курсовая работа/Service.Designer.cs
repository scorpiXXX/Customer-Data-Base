namespace Курсовая_работа
{
    partial class Service
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
            this.periodTB = new System.Windows.Forms.MaskedTextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.prePriceService = new System.Windows.Forms.TextBox();
            this.priceService = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typeService = new System.Windows.Forms.ComboBox();
            this.noteService = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serviceName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openBTN = new System.Windows.Forms.Button();
            this.createBTN = new System.Windows.Forms.Button();
            this.actCB = new System.Windows.Forms.CheckBox();
            this.tzCB = new System.Windows.Forms.CheckBox();
            this.priceCB = new System.Windows.Forms.CheckBox();
            this.dogovorCB = new System.Windows.Forms.CheckBox();
            this.closeBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.deleteService = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteService);
            this.groupBox1.Controls.Add(this.periodTB);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.prePriceService);
            this.groupBox1.Controls.Add(this.priceService);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.typeService);
            this.groupBox1.Controls.Add(this.noteService);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.serviceName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о услуге";
            // 
            // periodTB
            // 
            this.periodTB.Location = new System.Drawing.Point(149, 327);
            this.periodTB.Name = "periodTB";
            this.periodTB.Size = new System.Drawing.Size(247, 23);
            this.periodTB.TabIndex = 20;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(274, 298);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(92, 21);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Получена";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(274, 269);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Оплачено";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сроки выполнения:";
            // 
            // prePriceService
            // 
            this.prePriceService.Location = new System.Drawing.Point(149, 296);
            this.prePriceService.Name = "prePriceService";
            this.prePriceService.Size = new System.Drawing.Size(119, 23);
            this.prePriceService.TabIndex = 9;
            this.prePriceService.Text = "0";
            // 
            // priceService
            // 
            this.priceService.Location = new System.Drawing.Point(149, 267);
            this.priceService.Name = "priceService";
            this.priceService.Size = new System.Drawing.Size(119, 23);
            this.priceService.TabIndex = 8;
            this.priceService.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Предоплата:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Стоимость услуги:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Тип услуги:";
            // 
            // typeService
            // 
            this.typeService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeService.FormattingEnabled = true;
            this.typeService.Items.AddRange(new object[] {
            "Сайт",
            "Хостинг",
            "Рекламная компания",
            "Домен"});
            this.typeService.Location = new System.Drawing.Point(6, 237);
            this.typeService.Name = "typeService";
            this.typeService.Size = new System.Drawing.Size(390, 24);
            this.typeService.TabIndex = 4;
            // 
            // noteService
            // 
            this.noteService.Location = new System.Drawing.Point(9, 118);
            this.noteService.Name = "noteService";
            this.noteService.Size = new System.Drawing.Size(390, 96);
            this.noteService.TabIndex = 3;
            this.noteService.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание услуги:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование услуги:";
            // 
            // serviceName
            // 
            this.serviceName.Location = new System.Drawing.Point(9, 72);
            this.serviceName.Name = "serviceName";
            this.serviceName.Size = new System.Drawing.Size(390, 23);
            this.serviceName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.openBTN);
            this.groupBox2.Controls.Add(this.createBTN);
            this.groupBox2.Controls.Add(this.actCB);
            this.groupBox2.Controls.Add(this.tzCB);
            this.groupBox2.Controls.Add(this.priceCB);
            this.groupBox2.Controls.Add(this.dogovorCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(405, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Документация";
            // 
            // openBTN
            // 
            this.openBTN.Enabled = false;
            this.openBTN.Location = new System.Drawing.Point(274, 22);
            this.openBTN.Name = "openBTN";
            this.openBTN.Size = new System.Drawing.Size(122, 95);
            this.openBTN.TabIndex = 19;
            this.openBTN.Text = "Открыть документацию";
            this.openBTN.UseVisualStyleBackColor = true;
            this.openBTN.Click += new System.EventHandler(this.openBTN_Click);
            // 
            // createBTN
            // 
            this.createBTN.Location = new System.Drawing.Point(149, 22);
            this.createBTN.Name = "createBTN";
            this.createBTN.Size = new System.Drawing.Size(119, 95);
            this.createBTN.TabIndex = 18;
            this.createBTN.Text = "Создать документы";
            this.createBTN.UseVisualStyleBackColor = true;
            this.createBTN.Click += new System.EventHandler(this.createBTN_Click);
            // 
            // actCB
            // 
            this.actCB.AutoSize = true;
            this.actCB.Location = new System.Drawing.Point(6, 103);
            this.actCB.Name = "actCB";
            this.actCB.Size = new System.Drawing.Size(147, 21);
            this.actCB.TabIndex = 17;
            this.actCB.Text = "Акт сдачи-приема";
            this.actCB.UseVisualStyleBackColor = true;
            // 
            // tzCB
            // 
            this.tzCB.AutoSize = true;
            this.tzCB.Location = new System.Drawing.Point(6, 76);
            this.tzCB.Name = "tzCB";
            this.tzCB.Size = new System.Drawing.Size(45, 21);
            this.tzCB.TabIndex = 16;
            this.tzCB.Text = "ТЗ";
            this.tzCB.UseVisualStyleBackColor = true;
            // 
            // priceCB
            // 
            this.priceCB.AutoSize = true;
            this.priceCB.Location = new System.Drawing.Point(6, 49);
            this.priceCB.Name = "priceCB";
            this.priceCB.Size = new System.Drawing.Size(130, 21);
            this.priceCB.TabIndex = 15;
            this.priceCB.Text = "Перечень услуг";
            this.priceCB.UseVisualStyleBackColor = true;
            // 
            // dogovorCB
            // 
            this.dogovorCB.AutoSize = true;
            this.dogovorCB.Location = new System.Drawing.Point(6, 22);
            this.dogovorCB.Name = "dogovorCB";
            this.dogovorCB.Size = new System.Drawing.Size(82, 21);
            this.dogovorCB.TabIndex = 14;
            this.dogovorCB.Text = "Договор";
            this.dogovorCB.UseVisualStyleBackColor = true;
            // 
            // closeBTN
            // 
            this.closeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBTN.Location = new System.Drawing.Point(12, 508);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(143, 26);
            this.closeBTN.TabIndex = 2;
            this.closeBTN.Text = "Отмена";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBTN.Location = new System.Drawing.Point(161, 508);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(256, 26);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // deleteService
            // 
            this.deleteService.Location = new System.Drawing.Point(243, 29);
            this.deleteService.Name = "deleteService";
            this.deleteService.Size = new System.Drawing.Size(153, 26);
            this.deleteService.TabIndex = 21;
            this.deleteService.Text = "Удалить услугу";
            this.deleteService.UseVisualStyleBackColor = true;
            this.deleteService.Click += new System.EventHandler(this.deleteService_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 540);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуга";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox prePriceService;
        private System.Windows.Forms.TextBox priceService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox typeService;
        private System.Windows.Forms.RichTextBox noteService;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serviceName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button openBTN;
        private System.Windows.Forms.Button createBTN;
        private System.Windows.Forms.CheckBox actCB;
        private System.Windows.Forms.CheckBox tzCB;
        private System.Windows.Forms.CheckBox priceCB;
        private System.Windows.Forms.CheckBox dogovorCB;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.MaskedTextBox periodTB;
        private System.Windows.Forms.Button deleteService;
    }
}