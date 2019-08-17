using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created By: Prince Sharma
 * Student ID: 301043771
 * Created on: 2 August 2019
 * Description: This Form includes START NEW ORDER button, SAVED ORDER button
 *                       and EXIT button
 */

namespace COMP123_S2019_Assgn05.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectForm.Show();
            this.Hide();

        }

        /// <summary>
        /// Event handler For Saved Order Button Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.productInfoForm.OpenPreviousOrder();
            this.Hide();
            Program.productInfoForm.Show();
        }
    }

}