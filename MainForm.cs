using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace RegistryProgram
{
    public partial class MainForm : Form
    {
        Processor processor = new Processor();
        public string registryPass;

        public MainForm()
        {
              InitializeComponent();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {          
            try
            {
                registryPass = processor.getPass();
            }
            catch
            {
                MessageBox.Show(Constants.ERROR_MESSAGE, Constants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }            
           
        private void showTempBtn_Click(object sender, EventArgs e)
        {
            processor.showTemp();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            processor.register();
        }

        private void getSerialBtn_Click(object sender, EventArgs e)
        {
            processor.getSerial();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void passCheckBtn_Click(object sender, EventArgs e)
        {
            if (registryPass == passTb.Text)
            {
                loginSuccess();
            }
            else
            {
                loginFailed();
            }
        }

        private void loginFailed()
        {
            loginPanel.Hide();
            MessageBox.Show(Constants.SHOW_DEMO, Constants.ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            demoLb.Show();
            regBtn.Enabled = true;
        }

        private void loginSuccess()
        {
            loginPanel.Hide();
            regBtn.Enabled = true;
            showTempBtn.Enabled = true;
            showSerialBtn.Enabled = true;
            showInfoBtn.Enabled = true;
        }

        private void getInfoBtn_Click(object sender, EventArgs e)
        {
            processor.getInfo();
        }
    }
}
