﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;



namespace HistoryClient
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.appData.Table);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void bttnBack_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}