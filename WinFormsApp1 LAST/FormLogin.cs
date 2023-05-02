using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormsApp1.NewFolder;
using Newtonsoft.Json;
using WinFormsApp1.DataStoarge;

namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Storage.SaveData();
            Close();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            FormManager formManager = new FormManager();
            Hide();
            formManager.ShowDialog();
            Show();
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            Hide();
            formCustomer.ShowDialog();
            Show();
        }




    }
}

