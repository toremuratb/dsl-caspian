using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DSL.Models;
using System.Threading.Tasks;

namespace DSL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Contacts()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Asbestos_removal()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Fire_protection()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Industrial_cleaning()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Insulation()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Protective_coating()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Rope_access()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Scaffolding()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Career()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult HSEQ()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Procurement()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        public ActionResult Training()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendMessage(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>From: {2} ({0})</p><p>E-mail: {3} </p><p>Phone: {1}</p><p>Message:</p><p>{4}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("Zharas.akkulov@dslcaspian.com"));  // replace with valid value 
                message.Subject = "Обращение с сайта";
                message.Body = string.Format(body, model.FromCname, model.FromPhone, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Contacts", "Home");
                }
            }
            return RedirectToAction("Contacts", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendCv(CvFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("hr.admin@dslcaspian.com"));  // replace with valid value 
                message.Subject = "Новый кандидат";
                message.Body = string.Format(body, model.FromName, model.FromEmail);
                message.IsBodyHtml = true;
                if (model.Upload != null && model.Upload.ContentLength > 0)
                {
                    message.Attachments.Add(new Attachment(model.Upload.InputStream, Path.GetFileName(model.Upload.FileName)));
                }
                using (var smtp = new SmtpClient())
                {
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Career", "Home");
                }
            }
            return RedirectToAction("Career", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Subscribe(SubcscribeModel model)
        {
            var body = "<p>From: {0} ({1})</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress("Zharas.akkulov@dslcaspian.com"));  // replace with valid value 
            message.Subject = "Обращение с сайта";
            message.Body = string.Format(body, "новый подписчик", model.FromEmail, "Добавьте меня, пожалуйста, к списку подписчиков");
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);
                return RedirectToAction("Index", "Home");
            }
        }
    }
}