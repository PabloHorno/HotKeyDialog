using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotKeyDialog
{
    internal partial class HotKeyForm : Form
    {
        public HotKey hotKeyPressed { get; set; } = new HotKey();
        public HotKeyForm()
        {
            InitializeComponent();
        }
        public HotKeyForm(string title, string description)
        {
            InitializeComponent();
            this.Text = title;
            this.lblDescription.Text = description;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            this.Focus();
            HotKey hotkey = new HotKey(e.KeyData);

            hotKeyViewer.Text = hotkey.ToString();
            hotKeyPressed = hotkey;

            btnOk.Enabled = hotkey.IsValid;            
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void HotKeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                hotKeyPressed = new HotKey();
        }
    }

    public static class HotKeyMessageBox
    {
        public static HotKey Show(IWin32Window owner, string title, string description)
        {
            var form = new HotKeyForm(title, description);
            if (owner != null)
                form.ShowDialog(owner);
            else
                form.ShowDialog();
            return form.hotKeyPressed;
        }
        public static HotKey Show(string title, string description)
        {
            return Show(null, title, description);
        }
    }
}
