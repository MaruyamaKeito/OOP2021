using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Song {

        private string title;
        private string artistName;
        private int length;

        public string Title { get => title; set => title = value; }
        public string ArtistName { get => artistName; set => artistName = value; }
        public int Length { get => length; set => length = value; }

        public Song(string Title, string ArtistName, int Length) {
            Title = title;
            ArtistName = artistName;
            Length = length;
        }
    }
}
