namespace Курсовая_работа
{
    partial class Info
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
            this.textRTB = new System.Windows.Forms.RichTextBox();
            this.CloseBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textRTB
            // 
            this.textRTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRTB.Location = new System.Drawing.Point(12, 12);
            this.textRTB.Name = "textRTB";
            this.textRTB.Size = new System.Drawing.Size(725, 371);
            this.textRTB.TabIndex = 0;
            this.textRTB.Text = "";
            // 
            // CloseBTN
            // 
            this.CloseBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseBTN.Location = new System.Drawing.Point(12, 389);
            this.CloseBTN.Name = "CloseBTN";
            this.CloseBTN.Size = new System.Drawing.Size(356, 39);
            this.CloseBTN.TabIndex = 1;
            this.CloseBTN.Text = "Закрыть";
            this.CloseBTN.UseVisualStyleBackColor = true;
            this.CloseBTN.Click += new System.EventHandler(this.CloseBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBTN.Location = new System.Drawing.Point(381, 389);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(356, 39);
            this.saveBTN.TabIndex = 2;
            this.saveBTN.Text = "Сохранить";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 440);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.CloseBTN);
            this.Controls.Add(this.textRTB);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дополнительная информация";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textRTB;
        private System.Windows.Forms.Button CloseBTN;
        private System.Windows.Forms.Button saveBTN;
    }
}