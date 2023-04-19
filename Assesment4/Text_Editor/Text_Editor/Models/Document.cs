namespace Text_Editor.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string DocumentId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
