namespace KovaaksPlaylistManager
{
    public class Playlist
    {
        private string name;
        private string fileName;

        public Playlist(string fileName, string name)
        {
            this.fileName = fileName;
            this.name = name;
        }

        public string Name => name;

        public string FileName => fileName;
    }
}