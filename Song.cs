﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    public class Song
    {
        public int Duration;
        public string Name;
        public Artist Artist;
        public Album Album;
        public enum Genres
        {
            Classic = 0b00000001,
            Reggae = 0b0000010,
            Electro = 0b00000100
        }


    }
}
