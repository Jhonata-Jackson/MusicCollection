using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Model {
    public class Album {
        public string Title { get; set; }
        public string Year { get; set; }
        public string BandName { get; set; }

        public override string ToString() {
            return $"Álbum: {Title}, Ano de Lançamento: {Year}, Nome da Banda: {BandName}";
        }
        public Album() { }
        public Album(string title, string year, string bandName) {
            this.Title = title;
            this.Year = year;
            this.BandName = bandName;
        }
    }
}
