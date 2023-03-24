using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.VisualBasic.Logging;

namespace WinFormsAppForm
{
    public partial class FirstForm : Form
    {
        private List<User> _usersList = new List<User>();
        private int _it = 0;

        public FirstForm()
        {
            InitializeComponent();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            //textBox_name. = Color.Red;
            if (textBox_name.Text != "" && textBox_adress.Text != "" && textBox_phone.Text != "")
            {
                string name = textBox_name.Text;
                string adress = textBox_adress.Text;
                string phone = textBox_phone.Text;
                string sex = "";
                List<string> sports = new List<string>();
                if (radioButton_man.Checked || radioButton_women.Checked)
                {
                    if (radioButton_man.Checked)
                        sex = "Мужской";
                    else
                        sex = "Мужской";
                }
                for (int i = 0; i <= checkedListBox_sport.Items.Count - 1; i++)
                    if (checkedListBox_sport.GetItemChecked(i))
                        sports.Add($"{checkedListBox_sport.Items[i]}");

                User user = new User(name, adress, phone, sex, sports);
                _usersList.Add(user);
                richTextBox_data.Text = _usersList[_it].toString();
                _it += 1;
            }
        }

        private void radioButton_women_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_man.Checked)
            {
                radioButton_man.Checked = false;
                radioButton_women.Checked = true;
            }
        }

        private void radioButton_man_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_women.Checked)
            {
                radioButton_women.Checked = false;
                radioButton_man.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                try
                {
                    ofd.ShowDialog();
                    string filename = ofd.FileName;
                    Microsoft.Office.Interop.Excel.Application excelObject = new Microsoft.Office.Interop.Excel.Application();
                    excelObject.Visible = true;
                    Workbook wb = excelObject.Workbooks.Open(filename, 0, false, 5, "", "", false, XlPlatform.xlWindows, "", true, false, 0, true, false, false);
                    Worksheet wsh = wb.Sheets[1];

                    wsh.Cells[1, 1] = "ФИО";
                    wsh.Cells[2, 1] = "Адресс";
                    wsh.Cells[3, 1] = "Телефон";
                    wsh.Cells[4, 1] = "Пол";
                    wsh.Cells[5, 1] = "Спорт";

                    string sex = "None";
                    if (radioButton_man.Checked || radioButton_women.Checked)
                    {
                        if (radioButton_man.Checked)
                            sex = "Мужской";
                        else
                            sex = "Мужской";
                    }
                    string sports = "";
                    for (int i = 0; i <= checkedListBox_sport.Items.Count - 1; i++)
                        if (checkedListBox_sport.GetItemChecked(i))
                            sports += $"{checkedListBox_sport.Items[i]}\n";

                    wsh.Cells[4, 2] = sex;
                    wsh.Cells[1, 2] = textBox_name.Text;
                    wsh.Cells[2, 2] = textBox_adress.Text;
                    wsh.Cells[3, 2] = textBox_phone.Text;
                    wsh.Cells[5, 2] = sports;

                    wb.Save();
                }
                catch (Exception ex) { Console.WriteLine(ex); }
            }
        }
    }
    public class User
    {
        private string _name;
        private string _adress;
        private string _phone;
        private string _sex;
        private List<string>? _sport;

        public User(string name, string adress, string phone, string sex, List<string>? sports = null)
        {
            _name = name;
            _adress = adress;
            _phone = phone;
            _sex = sex;
            _sport = sports;
        }
        public string toString()
        {
            string s = "";
            foreach (string sport in _sport)
                s += $"* {sport}\n";
            return $"ФИО: {_name}\nАдресс: {_adress}\nТелефон: {_phone}\nПол: {_sex}\nСпорт: \n{s}";
        }
    }
}
