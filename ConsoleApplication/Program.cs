using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotKeyDialog;

namespace ConsoleApplication
{
    class Example
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Example2();
            }
        }
        static void Example1()
        {
            var e = HotKeyMessageBox.Show("Title", "A simple description");
            Console.WriteLine("You have pressed the keys: " + e.ToString());
            Console.ReadKey();
        }
        static void Example2()
        {
            var hotKey1 = new HotKey();
            var hotKey2 = new HotKey();
            
            hotKey1 = HotKeyMessageBox.Show("Title", "Hotkey 1");
            hotKey2 = HotKeyMessageBox.Show("Title", "Hotkey 2");
            Console.WriteLine("You have pressed the keys: " + hotKey1.ToString() + " and " + hotKey2.ToString() + " are they the same? " + (hotKey1 == hotKey2 ? "Yes" : "No"));
            Console.ReadKey();

        }
    }
}
