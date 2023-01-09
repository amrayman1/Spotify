namespace Profile_and_Singers.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string PublicId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<SingerMusic> singerMusics { get; set; }
    }
}
