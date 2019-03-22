namespace Курсовая_работа
{
    partial class SearchResult
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
            this.ResultLB = new System.Windows.Forms.ListBox();
            this.nowNewBTN = new System.Windows.Forms.Button();
            this.nowOldBTN = new System.Windows.Forms.Button();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.emailCB = new System.Windows.Forms.CheckBox();
            this.siteCB = new System.Windows.Forms.CheckBox();
            this.addressCB = new System.Windows.Forms.CheckBox();
            this.typeCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ResultLB
            // 
            this.ResultLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLB.FormattingEnabled = true;
            this.ResultLB.HorizontalScrollbar = true;
            this.ResultLB.ItemHeight = 20;
            this.ResultLB.Location = new System.Drawing.Point(12, 12);
            this.ResultLB.Name = "ResultLB";
            this.ResultLB.Size = new System.Drawing.Size(704, 364);
            this.ResultLB.TabIndex = 0;
            this.ResultLB.DoubleClick += new System.EventHandler(this.ResultLB_DoubleClick);
            // 
            // nowNewBTN
            // 
            this.nowNewBTN.Location = new System.Drawing.Point(723, 12);
            this.nowNewBTN.Name = "nowNewBTN";
            this.nowNewBTN.Size = new System.Drawing.Size(134, 38);
            this.nowNewBTN.TabIndex = 1;
            this.nowNewBTN.Text = "Сначала новые";
            this.nowNewBTN.UseVisualStyleBackColor = true;
            this.nowNewBTN.Click += new System.EventHandler(this.nowNewBTN_Click);
            // 
            // nowOldBTN
            // 
            this.nowOldBTN.Location = new System.Drawing.Point(723, 56);
            this.nowOldBTN.Name = "nowOldBTN";
            this.nowOldBTN.Size = new System.Drawing.Size(134, 38);
            this.nowOldBTN.TabIndex = 2;
            this.nowOldBTN.Text = "Сначала старые";
            this.nowOldBTN.UseVisualStyleBackColor = true;
            this.nowOldBTN.Click += new System.EventHandler(this.nowOldBTN_Click);
            // 
            // CloseBTN
            // 
            this.CloseBTN.Location = new System.Drawing.Point(12, 382);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(845, 38);
            this.CloseBTN.TabIndex = 3;
            this.CloseBTN.Text = "Закрыть";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // emailCB
            // 
            this.emailCB.AutoSize = true;
            this.emailCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailCB.Location = new System.Drawing.Point(723, 100);
            this.emailCB.Name = "emailCB";
            this.emailCB.Size = new System.Drawing.Size(131, 21);
            this.emailCB.TabIndex = 4;
            this.emailCB.Text = "Показать почту";
            this.emailCB.UseVisualStyleBackColor = true;
            this.emailCB.CheckedChanged += new System.EventHandler(this.emailCB_CheckedChanged);
            // 
            // siteCB
            // 
            this.siteCB.AutoSize = true;
            this.siteCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.siteCB.Location = new System.Drawing.Point(722, 127);
            this.siteCB.Name = "siteCB";
            this.siteCB.Size = new System.Drawing.Size(123, 21);
            this.siteCB.TabIndex = 5;
            this.siteCB.Text = "Показать сайт";
            this.siteCB.UseVisualStyleBackColor = true;
            this.siteCB.CheckedChanged += new System.EventHandler(this.emailCB_CheckedChanged);
            // 
            // addressCB
            // 
            this.addressCB.AutoSize = true;
            this.addressCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressCB.Location = new System.Drawing.Point(722, 154);
            this.addressCB.Name = "addressCB";
            this.addressCB.Size = new System.Drawing.Size(132, 21);
            this.addressCB.TabIndex = 6;
            this.addressCB.Text = "Показать адрес";
            this.addressCB.UseVisualStyleBackColor = true;
            this.addressCB.CheckedChanged += new System.EventHandler(this.emailCB_CheckedChanged);
            // 
            // typeCB
            // 
            this.typeCB.AutoSize = true;
            this.typeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeCB.Location = new System.Drawing.Point(722, 181);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(120, 38);
            this.typeCB.TabIndex = 7;
            this.typeCB.Text = "Показать тип \r\nклиента";
            this.typeCB.UseVisualStyleBackColor = true;
            this.typeCB.CheckedChanged += new System.EventHandler(this.emailCB_CheckedChanged);
            // 
            // SearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 429);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.addressCB);
            this.Controls.Add(this.siteCB);
            this.Controls.Add(this.emailCB);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.nowOldBTN);
            this.Controls.Add(this.nowNewBTN);
            this.Controls.Add(this.ResultLB);
            this.Name = "SearchResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результат поиска";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ResultLB;
        private System.Windows.Forms.Button nowNewBTN;
        private System.Windows.Forms.Button nowOldBTN;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.CheckBox emailCB;
        private System.Windows.Forms.CheckBox siteCB;
        private System.Windows.Forms.CheckBox addressCB;
        private System.Windows.Forms.CheckBox typeCB;
    }
}