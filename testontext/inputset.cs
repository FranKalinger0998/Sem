using StorageINF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testontext
{
     class inputset
    {
        
        public Label lab1;
        public TextBox text1;
        public Label lab2;
        public TextBox text2;
        public Label lab3;
        public TextBox text3;
        public inputset(Label lab1, Label lab2, Label lab3, TextBox text1, TextBox text2, TextBox text3)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.lab1 = lab1;
            this.lab2 = lab2;
            this.lab3 = lab3;
        }
        public void destroy()
        {
            lab1.Dispose();
            lab2.Dispose();
            lab3.Dispose();
            text1.Dispose();
            text2.Dispose();
            text3.Dispose();
        }
        public SpecificationSet conv()
        {
            return new SpecificationSet(text1.Text, Convert.ToDouble(text2.Text), text3.Text);
        }
    }
}
