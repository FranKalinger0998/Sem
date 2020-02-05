using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testontext
{
    public partial class Form1 : Form
    {
        Button button = new Button();
        int a = 0;

        public Form1()
        {
            button.Click += new EventHandler(button_Click);
            button.Text = "Add";
            InitializeComponent();
            AddNewMasurmentSet();
            Add_AddButton(button);
        }
        private void Add_Text_Box_Click(object sender, EventArgs e)
        {
            AddNewMasurmentSet();
        }
        public void Add_AddButton(Button button)
        {

            button.Top = a * 30;
            button.Left = 5;
            this.Controls.Add(button);
        }
        private void button_Click(object sender, EventArgs e)
        {
            AddNewMasurmentSet();
            Add_AddButton(button);
        }
        public void AddNewMasurmentSet()
        {
            TextBox text1 = new TextBox();
            Label lab1 = new Label();
            TextBox text2 = new TextBox();
            Label lab2 = new Label();
            TextBox text3 = new TextBox();
            Label lab3 = new Label();
            this.Controls.Add(text1);
            this.Controls.Add(text2);
            this.Controls.Add(text3);
            this.Controls.Add(lab1);
            this.Controls.Add(lab2);
            this.Controls.Add(lab3);
            text1.Top = a * 30;
            text2.Top = a * 30;
            text3.Top = a * 30;
            lab1.Top = a * 30;
            lab2.Top = a * 30;
            lab3.Top = a * 30;
            text1.Left = 105;
            text2.Left = 245;
            text3.Left = 430;
            lab1.Left = 0;
            lab2.Left = 210;
            lab3.Left = 350;
            lab1.Text = "Name of masurment:";
            lab1.AutoSize = true;
            lab2.Text = "Value:";
            lab2.AutoSize = true;
            lab3.Text = "Masurment unit:";
            lab3.AutoSize = true;

            a++;
            
        }
        
    }
}
