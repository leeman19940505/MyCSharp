﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTest2
{
    class Test2
    {
        public Test2()
        {
            Button button = new Button();
            button.Text = "Click me";
            button.Click += new EventHandler(LogPlainEvent);
            button.KeyPress += new KeyPressEventHandler(LogKeyEvent);
            button.MouseClick += new MouseEventHandler(LogMouseEvent);

            Form form = new Form();
            form.AutoSize = true;
            form.Controls.Add(button);
            Application.Run(form);
        }

        static void LogPlainEvent(object sender, EventArgs e)
        {
            Console.WriteLine("LogPlain");
        }

        static void LogKeyEvent(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("LogKey");
        }

        static void LogMouseEvent(object sender, MouseEventArgs e)
        {
            Console.WriteLine("LogMouse");
        }
    }
}
