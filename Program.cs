﻿using COMP123_S2019_Assgn05.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assgn05

{
    public static class Program
    {
        public static SplashForm splashForm;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static AboutForm aboutForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //instantiate all forms

            splashForm = new SplashForm();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            aboutForm = new AboutForm();

            Application.Run(new Views.StartForm());
        }
    }
}
