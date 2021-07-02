using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.Presentation;


namespace PowerPoint2021.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult CreateDocument()
        {
            // create a powerpoint instance
            IPresentation pptxDoc = Presentation.Create();

            //Add slide to the the Powerpoint presentation
            ISlide slide = pptxDoc.Slides.Add(SlideLayoutType.Blank);

            //Addd a textbox to the slide
            IShape shape = slide.AddTextBox(10, 10, 500, 100);

            //Add a textbox to the text box
            shape.TextBody.AddParagraph("Welcome to Powerpoint");

            //Save the PowerPoint Presentation

            pptxDoc.Save("Sample.pptx", FormatType.Pptx, HttpContext.ApplicationInstance.Response);

            // Close the PowerPoint presentation
            pptxDoc.Close();

            ViewBag.Message = "Create A new SlideShow.";

            return View();
        }
    }
}