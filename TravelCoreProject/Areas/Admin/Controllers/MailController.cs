﻿using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using TravelCoreProject.Models;

namespace TravelCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailRequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxFromAddress = new MailboxAddress("Admin", "traversalcore2@gmail.com");
            mimeMessage.From.Add(mailboxFromAddress);
            MailboxAddress mailboxToAddress = new MailboxAddress("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxToAddress);

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = mailRequest.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailRequest.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("traversalcore2@gmail.com", "123456aA+");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
