using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotKeyDialog
{
    public class HotKey : KeyEventArgs
    {
        public HotKey(Keys keyData) : base(keyData) { }
        public HotKey() : base(new Keys()) { }
        public bool IsValid
        {
            get
            {
                return KeyCode != Keys.None && KeyCode != Keys.ShiftKey && KeyCode != Keys.Alt && KeyCode != Keys.ControlKey && KeyCode != Keys.Menu;
            }
        }
        public override string ToString()
        {
            List<string> strKeys = new List<string>();
            if (Control)
                strKeys.Add("Ctrl");
            if (Shift)
                strKeys.Add("Shift");
            if (Alt)
                strKeys.Add("Alt");
            if (KeyCode != Keys.ControlKey && KeyCode != Keys.Alt && KeyCode != Keys.ShiftKey && KeyCode != Keys.Menu)
                strKeys.Add(KeyCode.ToString());

            return String.Join("+", strKeys.ToArray());
        }
        public static bool operator ==(HotKey hk1, HotKey hk2)
        {
            return hk1.Control == hk2.Control && hk1.Alt == hk2.Alt && hk1.Shift == hk2.Shift && hk1.KeyCode == hk2.KeyCode;
        }
        public static bool operator !=(HotKey hk1, HotKey hk2)
        {
            return !(hk1 == hk2);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
