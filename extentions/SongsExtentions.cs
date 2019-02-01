using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.extentions
{
    static class SongsExtentions
    {
        static public List<Song> Shuffle(this List<Song> songs)
        {
            Random rnd = new Random();
            for (int i = songs.Count - 1; i <= 0; i--)
            {

                var song = songs[rnd.Next(songs.Count - 1)];
                songs.Remove(song);
                songs.Add(song);
            }

            return songs;
        }

        public static List<Song> Sort(this List<Song> songs)
        {
            List<string> newList = new List<string>(songs.Count);
            int ind = 0;
            foreach (var song in songs)
            {
                newList.Insert(ind, song.Name);
                ind++;
            }
            newList.Sort();

            List<Song> newSong = new List<Song>(songs.Count);
            ind = 0;
            foreach (var item in newList)
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    if (item == songs[i].Name)
                    {
                        newSong.Insert(ind, songs[i]);
                        ind++;
                    }
                }
            }
            return newSong;
        }


    }
}
