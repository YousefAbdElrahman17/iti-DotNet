using GenAiDay2.Models;
using GenAiDay2.Services;
using Microsoft.AspNetCore.Mvc;
using UglyToad.PdfPig;

namespace G6ChatBot.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult Ask (ChatViewModel model) 
        //{

        //    model.Answer = "Hello From Chat Bot";
        //    return View("Index",model);
        //}
        //[HttpPost]
        //public IActionResult Ask (ChatViewModel model) 
        //{
        //    if (model.PdfFile == null) 
        //    {
        //        model.Answer = "Please Upload A PDF ";
        //        return View("Index", model);
        //    }
        //    string pdfText = ReadPdf(model.PdfFile);
        //    model.Answer = $"PDF Read Success chars:{pdfText.Length}";

        //    return View("Index", model);
        //}
        [HttpPost]
        public async Task<IActionResult> Ask (ChatViewModel model) 
        {
            if (model.PdfFile == null) 
            {
                model.Answer = "Please Upload A PDF ";
                return View("Index", model);
            }
            if (model.PdfFile.ContentType != "application/pdf" && !model.PdfFile.FileName.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                model.Answer = "Please Upload A Valid PDF File";
                return View("Index", model);
            }
            if (string.IsNullOrWhiteSpace(model.Question)) 
            {
                model.Answer = "Please Enter The Question";
                return View("Index", model);
            }
            //1. Read PDF File
            string pdfText = ReadPdf(model.PdfFile);

            //2. send pdf Content + Qustion to ai 
            AIService aIService = new AIService();
            model.Answer = await aIService.AskAsync(pdfText, model.Question);

            //3 show answer

            return View("Index", model);
        }
        //[NonAction]
        //public string ReadPdf1()
        //{
        //    return "test";
        //}
        private string ReadPdf(IFormFile pdfFile) 
        {
            using var stream = pdfFile.OpenReadStream();
            using var doucument = PdfDocument.Open(stream);
            string text = "";
            foreach(var page in doucument.GetPages()) 
            {
                text += page.Text + Environment.NewLine;
            }
            return text;
        } 
    }
}
