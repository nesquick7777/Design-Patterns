namespace Composite
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            SongGroup industrialMusic = new SongGroup("Industrial", 
                                                  "Industrial music is a genre of music that draws on harsh, mechanical, transgressive or provocative sounds and themes");

            SongGroup heavyMetalMusic = new SongGroup("\nHeavy Metal", 
                                                   "Heavy metal (or simply metal) is a genre of rock music that developed in the late 1960s and early 1970s, largely in the United Kingdom and United States.");

            SongGroup dubstepMusic = new SongGroup("\nDubstep", 
                                               "Dubstep is a genre of electronic dance music that originated in South London in the early 2000s.");

            SongGroup everySong = new SongGroup("Song List","Every Song Available");

            everySong.add(industrialMusic);

            industrialMusic.add(new Song("Head like a Hole", "NIN", 1990));
            industrialMusic.add(new Song("Headhunter","Front 242",1988));
            industrialMusic.add(dubstepMusic);

            dubstepMusic.add(new Song("Centipide","Knife Party",2012));
            dubstepMusic.add(new Song("Tetris", "Doctor P", 2011));

            everySong.add(heavyMetalMusic);

            heavyMetalMusic.add(new Song("War Pig", "Black Sabbath", 1970));
            heavyMetalMusic.add(new Song("Ace of Spades", "Motorhead", 1980));

            DiscJockey crazyLarry = new DiscJockey(everySong);

            crazyLarry.getSongList();
        }
    }
}