namespace Profile_and_Singers.Models
{
    public class SingerMusic
    {
        public int Id { get; set; }
        public int SingerId { get; set; }
        public ICollection<Singer> singers { get; set; }
        public int MusicId { get; set; }
        public ICollection<Music> musics { get; set; }
    }
}
