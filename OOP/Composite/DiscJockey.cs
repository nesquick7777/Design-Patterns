using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class DiscJockey
    {
        SongComponent songList;
        public DiscJockey(SongComponent newSongList) {
        songList = newSongList;
        }

        public void getSongList()
        {
            songList.displaySongInfo();
        }
    }
}
