namespace WinFormsAppForm
{
    partial class FirstForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_sport = new System.Windows.Forms.Label();
            this.checkedListBox_sport = new System.Windows.Forms.CheckedListBox();
            this.label_sex = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_adress = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.radioButton_women = new System.Windows.Forms.RadioButton();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_adress = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_exportExcel = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.richTextBox_data = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_sport);
            this.panel1.Controls.Add(this.checkedListBox_sport);
            this.panel1.Controls.Add(this.label_sex);
            this.panel1.Controls.Add(this.label_phone);
            this.panel1.Controls.Add(this.label_adress);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.radioButton_women);
            this.panel1.Controls.Add(this.radioButton_man);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.textBox_adress);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.button_exportExcel);
            this.panel1.Controls.Add(this.button_confirm);
            this.panel1.Controls.Add(this.richTextBox_data);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 437);
            this.panel1.TabIndex = 0;
            // 
            // label_sport
            // 
            this.label_sport.AutoSize = true;
            this.label_sport.Location = new System.Drawing.Point(13, 212);
            this.label_sport.Name = "label_sport";
            this.label_sport.Size = new System.Drawing.Size(41, 15);
            this.label_sport.TabIndex = 14;
            this.label_sport.Text = "Спорт";
            // 
            // checkedListBox_sport
            // 
            this.checkedListBox_sport.FormattingEnabled = true;
            this.checkedListBox_sport.HorizontalScrollbar = true;
            this.checkedListBox_sport.Items.AddRange(new object[] {
            "Футбол",
            "Баскетбол",
            "Плавание",
            "Волейбол",
            "Шахматы",
            "Хокей"});
            this.checkedListBox_sport.Location = new System.Drawing.Point(62, 212);
            this.checkedListBox_sport.Name = "checkedListBox_sport";
            this.checkedListBox_sport.Size = new System.Drawing.Size(129, 76);
            this.checkedListBox_sport.TabIndex = 13;
            // 
            // label_sex
            // 
            this.label_sex.AutoSize = true;
            this.label_sex.Location = new System.Drawing.Point(25, 170);
            this.label_sex.Name = "label_sex";
            this.label_sex.Size = new System.Drawing.Size(30, 15);
            this.label_sex.TabIndex = 12;
            this.label_sex.Text = "Пол";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(25, 115);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(29, 15);
            this.label_phone.TabIndex = 11;
            this.label_phone.Text = "Тел.";
            // 
            // label_adress
            // 
            this.label_adress.AutoSize = true;
            this.label_adress.Location = new System.Drawing.Point(18, 72);
            this.label_adress.Name = "label_adress";
            this.label_adress.Size = new System.Drawing.Size(40, 15);
            this.label_adress.TabIndex = 10;
            this.label_adress.Text = "Адрес";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(24, 29);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(34, 15);
            this.label_name.TabIndex = 8;
            this.label_name.Text = "ФИО";
            // 
            // radioButton_women
            // 
            this.radioButton_women.AutoSize = true;
            this.radioButton_women.Location = new System.Drawing.Point(146, 166);
            this.radioButton_women.Name = "radioButton_women";
            this.radioButton_women.Size = new System.Drawing.Size(47, 19);
            this.radioButton_women.TabIndex = 7;
            this.radioButton_women.TabStop = true;
            this.radioButton_women.Text = "жен";
            this.radioButton_women.UseVisualStyleBackColor = true;
            this.radioButton_women.CheckedChanged += new System.EventHandler(this.radioButton_women_CheckedChanged);
            // 
            // radioButton_man
            // 
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Location = new System.Drawing.Point(64, 166);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(49, 19);
            this.radioButton_man.TabIndex = 6;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "муж";
            this.radioButton_man.UseVisualStyleBackColor = true;
            this.radioButton_man.CheckedChanged += new System.EventHandler(this.radioButton_man_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(64, 112);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(160, 23);
            this.textBox_phone.TabIndex = 4;
            // 
            // textBox_adress
            // 
            this.textBox_adress.Location = new System.Drawing.Point(64, 69);
            this.textBox_adress.Name = "textBox_adress";
            this.textBox_adress.Size = new System.Drawing.Size(160, 23);
            this.textBox_adress.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(64, 26);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(160, 23);
            this.textBox_name.TabIndex = 2;
            // 
            // button_exportExcel
            // 
            this.button_exportExcel.Location = new System.Drawing.Point(146, 312);
            this.button_exportExcel.Name = "button_exportExcel";
            this.button_exportExcel.Size = new System.Drawing.Size(100, 23);
            this.button_exportExcel.TabIndex = 1;
            this.button_exportExcel.Text = "Экспорт в Excel";
            this.button_exportExcel.UseVisualStyleBackColor = true;
            this.button_exportExcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(25, 312);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(100, 23);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "Сформировать";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // richTextBox_data
            // 
            this.richTextBox_data.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox_data.Location = new System.Drawing.Point(0, 341);
            this.richTextBox_data.Name = "richTextBox_data";
            this.richTextBox_data.ReadOnly = true;
            this.richTextBox_data.Size = new System.Drawing.Size(260, 96);
            this.richTextBox_data.TabIndex = 0;
            this.richTextBox_data.Text = "";
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FirstForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirstForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_adress;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.RichTextBox richTextBox_data;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.RadioButton radioButton_women;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.Label label_adress;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_sport;
        private System.Windows.Forms.CheckedListBox checkedListBox_sport;
        private System.Windows.Forms.Label label_sex;
        private Button button_exportExcel;
    }
}