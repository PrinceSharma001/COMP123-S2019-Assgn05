using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created By: Prince Sharma
 * Student ID: 301043771
 * Created on: 2 August 2019
 * Description: This Form includes same OUTPUT LABEL as ProductInfoForm
 *             with price and Sales Tax 
 *                    
 */

namespace COMP123_S2019_Assgn05.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LCDLabel_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        /// <summary>
        /// This is the event handler for aboutToolStripMenu click event
        /// and it shows the about form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ManufacturerOutputLabel.Text = Program.product.manufacturer;
            ModelOutputLabel.Text = Program.product.model;
            MemoryOutputLabel.Text = Program.product.RAM_size;
            LCDSizeOutputLabel.Text = Program.product.screensize;
            CPUBrandOutputLabel.Text = Program.product.CPU_brand;
            CPUTypeLabel.Text = Program.product.CPU_type;
            
            CPUnumOutputLabel.Text = Program.product.CPU_number;
            HDDOutputLabel.Text = Program.product.HDD_size;
            CPUSpeedOutputLabel.Text = Program.product.CPU_speed;
            GPUOutputLabel.Text = Program.product.GPU_Type;
            WebCameraOutputLabel.Text = Program.product.webcam;
            OSOutputLabel.Text = Program.product.OS;
            PlatformOutputLabel.Text = Program.product.platform;
            ConditionOutputLabel.Text = Program.product.condition;
            PriceOutputLabel.Text = Program.product.cost.ToString();
            SalesTaxOutputLabel.Text = Convert.ToDouble(Program.product.cost/100*13).ToString();
            SalesTaxOutputLabel.Text = Convert.ToDouble(Program.product.cost/100*13).ToString();
            TotalResultLabel.Text = (Convert.ToDouble(Program.product.cost)  + Convert.ToDouble(Program.product.cost/100*13)).ToString();

        }

        private void WebCameraOutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        /// <summary>
        /// This is the event handler for backtoolsStripMenu Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Program.productInfoForm.Show();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for ordering your Computer.");
            Application.Exit();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
