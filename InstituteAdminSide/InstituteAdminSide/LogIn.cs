﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace InstituteAdminSide
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mail = new MailMessage();
            var client = new SmtpClient("smtpcorp.com", 2525) //Port 8025, 587 and 25 can also be used.
            {
                Credentials = new NetworkCredential("ishantuf@gmail.com", "nvidiagtx680"),
                EnableSsl = true
            };
            mail.From = new MailAddress("sender@example.com");
            mail.To.Add(forgetMailtxt.Text);
            mail.Subject = "Your Subject";
            var plainView = AlternateView.CreateAlternateViewFromString("This is a text message", null, "text/plain");
            var htmlView = AlternateView.CreateAlternateViewFromString("<b>This is a html message</b>", null, "text/html");
            mail.AlternateViews.Add(plainView);
            mail.AlternateViews.Add(htmlView);
            client.Send(mail);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        LogIn log = new LogIn();
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (log.Height <= 420)
            {

                log.Height += 10;
            }
        }
    }
}
