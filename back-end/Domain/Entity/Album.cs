namespace Domain.Entity
{
    public class Album
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public List<Song> SongList { get; set; }
    }

}