using Profile_and_Singers.Models;

namespace Profile_and_Singers.Dtos
{
    public class SingerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public IList<MusicDto> musics { get; set; }
    }
}
