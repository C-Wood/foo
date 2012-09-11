using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace foo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Food is good!");
            Form form = new Form();
            Button button1 = new Button();
            Button button2 = new Button();
            button1.Dock = DockStyle.Top;
            button2.Dock = DockStyle.Bottom;
            button1.Click += new EventHandler(button1_Click);
            button2.Click += new EventHandler(button2_Click);
            form.Controls.Add(button1);
            form.Controls.Add(button2);
            form.ShowDialog();
        }

        static void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked button 2.");
        }

        static void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked button 1.");
        }
    }
}
