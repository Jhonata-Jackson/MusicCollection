using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Model {
    public class Music {
        public string Title { get; set; }
        public string Duration { get; set; }
        public string BandName { get; set; }
        public string Favorite { get; set; }

        public Music() { }
        public Music(string title, string duration, string bandName, string favorite) {
            this.Title = title;
            this.Duration = duration;
            this.BandName = bandName;
            this.Favorite = favorite;
        }
        public override string ToString() {
            return
                $"Título: {Title}, Duração: {Duration}, Nome da Banda: {BandName}, Favorita: {Favorite}";
        }
    }
}
