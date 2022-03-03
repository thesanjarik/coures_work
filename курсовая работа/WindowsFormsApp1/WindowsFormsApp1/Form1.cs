using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public struct people
    {
        public string name;
        public string number;
    }


    public partial class Form1 : Form
    {
        List<people> i = new List<people>();


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }


        int find(string s)
        {
            for (int i = 0; i < l.Count; ++i)
                if (l[i].name.Equlas(s))
                    return i;


            return -1;
        }
    }
}
