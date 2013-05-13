using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsBasedEmailClient.IntegratedEmailService;

namespace WindowsBasedEmailClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGmail_Click(object sender, EventArgs e)
        {
            List<Email> emails = new List<Email>();
            using (var client = new IntegratedEmailClient())
            {
                emails = client.GetEmails(EmailProviderType.Gmail, "a", "b").ToList();
            }
            dataGridView1.DataSource = emails;

        }

        private void btnYahoo_Click(object sender, EventArgs e)
        {
            List<Email> emails = new List<Email>();
            using (var client = new IntegratedEmailClient())
            {
                emails = client.GetEmails(EmailProviderType.Yahoo, "a", "b").ToList();
            }
            dataGridView1.DataSource = emails;
        }

        private void btnHotmail_Click(object sender, EventArgs e)
        {
            List<Email> emails = new List<Email>();
            using (var client = new IntegratedEmailClient())
            {
                emails = client.GetEmails(EmailProviderType.Hotmail, "a", "b").ToList();
            }
            dataGridView1.DataSource = emails;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Email> emails = new List<Email>();
            using (var client = new IntegratedEmailClient())
            {
                emails.AddRange(client.GetEmails(EmailProviderType.Hotmail, "a", "b").ToList());
            }

            using (var client = new IntegratedEmailClient())
            {
                emails.AddRange(client.GetEmails(EmailProviderType.Gmail, "a", "b").ToList());
            }

            using (var client = new IntegratedEmailClient())
            {
                emails.AddRange(client.GetEmails(EmailProviderType.Yahoo, "a", "b").ToList());
            }

            dataGridView1.DataSource = emails;
        }
    }
}
