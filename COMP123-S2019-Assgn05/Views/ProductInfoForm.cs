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
 * Description: This Form includes LABELS and output Labels in which 
 *              PRODUCT info will be shown in output LABELS from selectForm DATAGRIDVIEW
 */

namespace COMP123_S2019_Assgn05.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Event handler for Form Activated Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {
            ManufacturerOutputLabel.Text = Program.product.manufacturer;
            ModelOutputLabel.Text = Program.product.model;
            LCDSizeOutputLabel.Text = Program.product.screensize;
            CPUBrandOutputLabel.Text = Program.product.CPU_brand;
            CPUTypeOutputLabel.Text = Program.product.CPU_type;
            OSOutputLabel.Text = Program.product.OS;
            ProductIDOutputLabel.Text = Program.product.productID.ToString();
            ConditionOutputLabel.Text = Program.product.condition;
            PriceOutputLabel.Text = Program.product.cost.ToString();
            ConditionOutputLabel.Text = Program.product.condition;
            PlatformOutputLabel.Text = Program.product.platform;
            MemoryOutputLabel.Text = Program.product.RAM_size;
            CPUnumOutputLabel.Text = Program.product.CPU_number;
            CPUSpeedOutputLabel.Text = Program.product.CPU_speed;
            HDDOutputLabel.Text = Program.product.HDD_size;
            GPUOutputLabel.Text = Program.product.GPU_Type;
            WebCameraOutputLabel.Text = Program.product.webcam;          
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPreviousOrder();

            NextButton_Click(sender, e);
        }

        /// <summary>
        /// Opens Saved Order
        /// </summary>
        public void OpenPreviousOrder()
        {
            // configuration for openFileDialog
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                using (StreamReader inputString = new StreamReader(
                     File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                {
                    //Write strings to File
                    Program.product.productID = short.Parse(inputString.ReadLine());
                    Program.product.manufacturer = inputString.ReadLine();
                    Program.product.model = inputString.ReadLine();
                    Program.product.cost = Convert.ToDecimal(inputString.ReadLine());
                    Program.product.condition = inputString.ReadLine();
                    Program.product.platform = inputString.ReadLine();
                    Program.product.CPU_type = inputString.ReadLine();
                    Program.product.CPU_number = inputString.ReadLine();
                    Program.product.CPU_speed = inputString.ReadLine();
                    Program.product.screensize = inputString.ReadLine();
                    Program.product.HDD_size = inputString.ReadLine();
                    Program.product.GPU_Type = inputString.ReadLine();
                    Program.product.webcam = inputString.ReadLine();
                    Program.product.OS = inputString.ReadLine();
                    Program.product.RAM_size = inputString.ReadLine();
                    Program.product.screensize = inputString.ReadLine();
                    Program.product.CPU_brand = inputString.ReadLine();
                    
                    // close 
                    inputString.Close();
                    inputString.Dispose();
                }

            }
        }

        /// <summary>
        /// Event handler for Save Tool Strip Click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //configure save file dialog box
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open file stream to read
                using (StreamReader inputStream = new StreamReader(
                    File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                {
                    Program.product.productID = short.Parse(inputStream.ReadLine());
                    Program.product.manufacturer = inputStream.ReadLine();
                    Program.product.model = inputStream.ReadLine();
                    Program.product.cost = Convert.ToDecimal(inputStream.ReadLine());
                    Program.product.condition = inputStream.ReadLine();
                    Program.product.platform = inputStream.ReadLine();
                    Program.product.CPU_type = inputStream.ReadLine();
                    Program.product.CPU_number = inputStream.ReadLine();
                    Program.product.CPU_speed = inputStream.ReadLine();
                    Program.product.screensize = inputStream.ReadLine();
                    Program.product.HDD_size = inputStream.ReadLine();
                    Program.product.GPU_Type = inputStream.ReadLine();
                    Program.product.webcam = inputStream.ReadLine();
                    Program.product.OS = inputStream.ReadLine();
                    Program.product.RAM_size = inputStream.ReadLine();
                    Program.product.screensize = inputStream.ReadLine();
                    Program.product.CPU_brand = inputStream.ReadLine();

                    // close 
                    inputStream.Close();
                    inputStream.Dispose();
                }


                NextButton_Click(sender, e);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.orderForm.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.selectForm.Show();
        }
    }
}
