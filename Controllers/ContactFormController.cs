using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;
using System.Net.Mail;
using PerfectAimBowling.Models;

namespace PerfectAimBowling.Controllers
{
    public class ContactFormController : SurfaceController
    {
        public const string LAYOUT_DIRECTORY = "~/Views/Partials/Contact/";

        // GET: Contact
        [HttpPost]
        [ValidateMvcAngularAntiForgeryToken]
        public ActionResult Submit(ContactFormViewModel model)
        {
            if (ModelState.IsValid) {
                SendMail(model);
                TempData["ContactSuccess"] = true;
                return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }

        public ActionResult RenderContactForm()
        {
            return PartialView(LAYOUT_DIRECTORY + "_ContactForm.cshtml");
        }

        private void SendMail(ContactFormViewModel model)
        {
            MailMessage message = new MailMessage(model.Email, "eckkyle2@gmail.com");
            message.Subject = string.Format("Enquiry from {0} {1} - {2}", model.FirstName, model.LastName, model.Email);
            message.Body = model.Message;
            SmtpClient client = new SmtpClient("127.0.0.1", 25);
            client.Send(message);
        }
    }
}