using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Song : SongComponent
    {
        String songName;
        String bandName;
        int releaseYear;

        public Song(String newSongName, String newBandName, int newYearRelease)
        {
            songName = newSongName;
            bandName = newBandName;
            releaseYear = newYearRelease;
        }
        public String getSongName() { return songName; }

        public String getBandName() { return bandName; }

        public int getReleaseYear() { return  releaseYear; }

        public void displaySongInfo()
        {
            Console.WriteLine(getSongName() + " was recorded in " + getReleaseYear() + " by a band named " + getBandName());
        }

    }
}
