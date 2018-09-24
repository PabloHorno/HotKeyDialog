using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotKeyDialog;

namespace WindowsFormsTestApplication
{
    public partial class ExampleForm : Form
    {
        public ExampleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Example1();
        }

        void Example1()
        {
            HotKey hotkey = new HotKey();
            hotkey = HotKeyMessageBox.Show("Title", "Please press the key combination");
            label1.Text = "You have pressed the keys: " + hotkey.ToString();
        }
        void Example2()
        {
            var hotKey1 = new HotKey();
            var hotKey2 = new HotKey();

            hotKey1 = HotKeyMessageBox.Show("Title", "Hotkey 1");
            hotKey2 = HotKeyMessageBox.Show("Title", "Hotkey 2");
            label1.Text = "You have pressed the keys: " + hotKey1.ToString() + " and " + hotKey2.ToString() + ". Are they the same? " + (hotKey1 == hotKey2 ? "Yes" : "No");

        }
    }
}
