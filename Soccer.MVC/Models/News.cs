namespace Soccer.MVC.Models
{
    public class News
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Slug { get; set; }
        public int Admin_ID { get; set; }
        public string? Excerpt { get; set; }
        public DateTime? Date_Created { get; set; }
        public DateTime? Date_Modified { get; set; }
        public int Post_Type_ID { get; set; }
        public int Privacy_ID { get; set; }
        public int Parent_ID { get; set; }
    }
}
