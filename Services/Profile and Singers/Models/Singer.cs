namespace Profile_and_Singers.Models
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public ICollection<SingerMusic> singerMusics { get; set; }

    }
}
