﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace BlowOut.Controllers
{
    public class ContactController : Controller
    {
        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "estebanimpossible@gmail.com"; //Sender Email Address  
        static string password = "impossible1"; //Sender Password
       
        // GET: Contact
        public string Index()
        {
            return "<p>Please call Support at <b><u>801-555-1212</u></b> . Thank you!</p>";
        }

        public string Email(string name, string email)
        {
            //if (name == "" || email == "") { return "Sorry, you done messed up A-aron."; }
            if (email == "") { SendEmail(name + " didn't include an email.", "steven.rummler@gmail.com"); }
            else { SendEmail(name, email); }
            return "<p>Thank you, " + name + "! We will send you an email at " + email + " shortly.</p>";
        }

        public static void SendEmail(string name, string emailToAddress)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = "Dear " + name;
                mail.Body = "Thank you for your patronage.";
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
}