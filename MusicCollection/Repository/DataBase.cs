using MusicCollection.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Repository {
    class DataBase {

        public DataBase() { }
        public static List<Album> Albums { get; set; }
        public static List<Music> Musics { get; set; }
    }
}
