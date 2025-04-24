using muzyka.Model;
namespace muzyka.View
{
    public partial class MainPage : ContentPage

    {
        private List<Song> songs;
        private int currentIndex = 0;
      
        public MainPage()
        {
            InitializeComponent();
            LoadSongs();
            ShowSong(currentIndex);
        }
       
        private void LoadSongs()
        {
            songs = new List<Song>
        {
            new Song
            {
                Artist = "Noisestorm",
                Title = "Crab Rave",
                Duration = "3:12",
                CoverImage = "crab.jpg"
            },
            new Song
            {
                Artist = "Warriyo",
                Title = "Mortals (feat. Laura Brehm)",
                Duration = "3:47",
                CoverImage = "mortals.jpg"
            },
            new Song
            {
                Artist = "Marshmello",
                Title = "Alone",
                Duration = "3:20",
                CoverImage = "alone.jpg"
            }
        };
        }
       
        private void ShowSong(int index)
        {
            if (songs == null || songs.Count == 0)
                return;

            var song = songs[index];
            Titlel.Text = song.Title;
            Artistl.Text = song.Artist;
            CoverImage.Source = song.CoverImage;
            Durationl.Text = song.Duration;
        }
      
        private void OnNextClicked(object sender, EventArgs e)
        {
            currentIndex = (currentIndex + 1) % songs.Count;
            ShowSong(currentIndex);
        }
      
        private void OnBackClicked(object sender, EventArgs e)
        {
            currentIndex = (currentIndex - 1 + songs.Count) % songs.Count;
            ShowSong(currentIndex);
        }
     
        private void OnPlayClicked(object sender, EventArgs e)
        {

        }
    }}
