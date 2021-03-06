﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.ServiceReference;

namespace Client
{
    public partial class UpdateOtherData : Form
    {
        public UpdateOtherData()
        {
            InitializeComponent();
            setAllField();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            using (ServiceBDClient client = new ServiceBDClient())
            {
                client.Open();
                var all = from t in client.GetOtherInfo() where t.Id > 0 select t;
                int create = 0;
                foreach (var i in all)
                {
                    if (i.Id == Main.Id)
                    {
                        client.RemoveStudent(Main.Id, "a", DateTime.Now);
                        client.UpdateOtherInfo(Main.Id, comboBox_mender.Text, textBox_address.Text, textBox_telephone.Text, textBox_tickets.Text, 4);
                        create++;
                    }
                }
                if(create == 0)
                {
                    client.AddOtherData(Main.Id, comboBox_mender.Text, textBox_address.Text, textBox_telephone.Text, textBox_tickets.Text, 4);
                }
                client.Close();
            }
        }

        private void setAllField()
        {
            comboBox_mender.Items.Add("Man");
            comboBox_mender.Items.Add("Woman");
            comboBox_mender.SelectedItem = "Man";
        }
    }
}
