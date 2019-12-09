namespace CrmUI
{
    partial class frmAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbCountry = new System.Windows.Forms.TextBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnOther = new System.Windows.Forms.RadioButton();
            this.trbrDiscount = new System.Windows.Forms.TrackBar();
            this.lbDiscount = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbrDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Адрес";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Скидка";
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(149, 30);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(186, 20);
            this.txbFirstName.TabIndex = 6;
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(149, 61);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(186, 20);
            this.txbLastName.TabIndex = 7;
            // 
            // txbCountry
            // 
            this.txbCountry.Location = new System.Drawing.Point(149, 122);
            this.txbCountry.Name = "txbCountry";
            this.txbCountry.Size = new System.Drawing.Size(186, 20);
            this.txbCountry.TabIndex = 8;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(149, 158);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(186, 20);
            this.txbAddress.TabIndex = 9;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(149, 92);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(34, 17);
            this.rbtnMale.TabIndex = 14;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "М";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(189, 92);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(36, 17);
            this.rbtnFemale.TabIndex = 15;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Ж";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnOther
            // 
            this.rbtnOther.AutoSize = true;
            this.rbtnOther.Location = new System.Drawing.Point(231, 92);
            this.rbtnOther.Name = "rbtnOther";
            this.rbtnOther.Size = new System.Drawing.Size(97, 17);
            this.rbtnOther.TabIndex = 16;
            this.rbtnOther.TabStop = true;
            this.rbtnOther.Text = "неизв./другой";
            this.rbtnOther.UseVisualStyleBackColor = true;
            // 
            // trbrDiscount
            // 
            this.trbrDiscount.Location = new System.Drawing.Point(149, 196);
            this.trbrDiscount.Maximum = 50;
            this.trbrDiscount.Name = "trbrDiscount";
            this.trbrDiscount.Size = new System.Drawing.Size(150, 45);
            this.trbrDiscount.SmallChange = 5;
            this.trbrDiscount.TabIndex = 17;
            // 
            // lbDiscount
            // 
            this.lbDiscount.AutoSize = true;
            this.lbDiscount.Location = new System.Drawing.Point(305, 196);
            this.lbDiscount.Name = "lbDiscount";
            this.lbDiscount.Size = new System.Drawing.Size(13, 13);
            this.lbDiscount.TabIndex = 18;
            this.lbDiscount.Text = "0";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(74, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 19;
            this.btnOk.Text = "Добавить";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(253, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 289);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbDiscount);
            this.Controls.Add(this.trbrDiscount);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnOther);
            this.Controls.Add(this.txbAddress);
            this.Controls.Add(this.txbCountry);
            this.Controls.Add(this.txbLastName);
            this.Controls.Add(this.txbFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAdd";
            this.Text = "Добавление записи ";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbrDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbCountry;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnOther;
        private System.Windows.Forms.TrackBar trbrDiscount;
        private System.Windows.Forms.Label lbDiscount;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}