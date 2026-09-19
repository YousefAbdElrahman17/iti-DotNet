namespace GenAiDay2.Models
{
    public class ChatViewModel
    {
        public IFormFile? PdfFile { get; set; }
        public string? Question { get; set; }
        public string? Answer { get; set; }
    }
}
