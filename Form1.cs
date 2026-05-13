using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace AluminumProject
{
    public partial class Form1 : Form
    {
        // File paths for data storage as required by the project
        private string materialsFile = "malzemeler.txt";
        
        // UI Elements
        private TextBox txtMaterialName, txtMaterialPrice;
        private ListBox lstDisplay;

        public Form1()
        {
            InitializeUserInterface();
        }

        private void InitializeUserInterface()
        {
            // Main Window Settings
            this.Text = "Aluminum Workshop System - Sakarya University";
            this.Size = new Size(450, 450);

            // Material Name Input
            Label lblName = new Label { Text = "Material Name:", Location = new Point(20, 30), Width = 120 };
            txtMaterialName = new TextBox { Location = new Point(150, 30), Width = 200 };

            // Price Input
            Label lblPrice = new Label { Text = "Unit Price:", Location = new Point(20, 70), Width = 120 };
            txtMaterialPrice = new TextBox { Location = new Point(150, 70), Width = 200 };

            // Save Button
            Button btnAdd = new Button { Text = "Save Material", Location = new Point(150, 110), Width = 120, Height = 35 };
            btnAdd.Click += BtnAdd_Click;

            // Display List
            lstDisplay = new ListBox { Location = new Point(20, 170), Width = 390, Height = 200 };

            // Adding controls to the form
            this.Controls.AddRange(new Control[] { lblName, txtMaterialName, lblPrice, txtMaterialPrice, btnAdd, lstDisplay });
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                // Creating a new instance of the Material class
                Material newMaterial = new Material
                {
                    MaterialName = txtMaterialName.Text,
                    Price = double.Parse(txtMaterialPrice.Text)
                };

                // Saving data to a text file (File-based requirement - 40 points)
                // Using formatted string from the Material class override
                File.AppendAllText(materialsFile, newMaterial.ToString() + Environment.NewLine);

                // Update the UI list
                lstDisplay.Items.Add("Stored: " + newMaterial.ToString());
                
                // Clear inputs for next entry
                txtMaterialName.Clear();
                txtMaterialPrice.Clear();

                MessageBox.Show("Material data saved successfully to the file!");
            }
            catch (Exception ex)
            {
                // Basic error handling for invalid inputs
                MessageBox.Show("Error: Please ensure the price is a valid number. " + ex.Message);
            }
        }
    }
}