﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AD_Authentication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ///Azure AD Authentication
            //Code
            var aad ="Azure";
            //Done
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
