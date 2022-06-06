using System;
using MusicCollection.Controllers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Utils {
    class Mock {
        public static void GenerateData() {
            MenuActions.CreateAlbum("Depois da guerra", "2008", "OficinaG3");
            MenuActions.CreateMusic("Eu sou", "2:15", "OficinaG3", "s");
            MenuActions.CreateMusic("Continuar", "2:30", "OficinaG3", "n");
            MenuActions.CreateMusic("Meus Proprios meios", "3:00", "OficinaG3", "s");

            MenuActions.CreateAlbum("Historias e Bicicletas", "2013", "OficinaG3");
            MenuActions.CreateMusic("Diz", "2:00", "OficinaG3", "s");
            MenuActions.CreateMusic("Encontro", "2:30", "OficinaG3", "n");
            MenuActions.CreateMusic("Confiar", "2:42", "OficinaG3", "s");

            MenuActions.CreateAlbum("Essencial", "2016", "Rosa de Saron");
            MenuActions.CreateMusic("Sem você", "2:40", "Rosa de Saron", "n");
            MenuActions.CreateMusic("Aurora", "2:24", "Rosa de Saron", "s");
            MenuActions.CreateMusic("Monte Inverno", "2:40", "Rosa de Saron", "n");

            MenuActions.CreateAlbum("Lunação", "2020", "Rosa de Saron");
            MenuActions.CreateMusic("Pedro", "2:00", "Rosa de Saron", "s");
            MenuActions.CreateMusic("Um dia", "2:32", "Rosa de Saron", "n");
            MenuActions.CreateMusic("Estrangeiro", "2:40", "Rosa de Saron", "n");

            MenuActions.CreateAlbum("Princípio", "2014", "Leonardo Gonçalves");
            MenuActions.CreateMusic("Pedro", "2:30", "Leonardo Gonçalves", "n");
            MenuActions.CreateMusic("Um dia", "2:37", "Leonardo Gonçalves", "s");
            MenuActions.CreateMusic("Estrangeiro", "2:40", "Leonardo Gonçalves", "n");

            MenuActions.CreateAlbum("Viver e Cantar", "2007", "Leonardo Gonçalves");
            MenuActions.CreateMusic("Moriá", "2:30", "Leonardo Gonçalves", "n");
            MenuActions.CreateMusic("Livre Sou", "2:00", "Leonardo Gonçalves", "s");
            MenuActions.CreateMusic("Salmo", "2:40", "Leonardo Gonçalves", "n");

            MenuActions.CreateAlbum("Uma só voz", "2021", "Morada");
            MenuActions.CreateMusic("Pedro", "2:30", "Morada", "n");
            MenuActions.CreateMusic("Um dia", "2:00", "Morada", "s");
            MenuActions.CreateMusic("Estrangeiro", "2:40", "Morada", "n");

            MenuActions.CreateAlbum("Ele É ", "2020", "Morada");
            MenuActions.CreateMusic("Meus Votos", "2:30", "Morada", "n");
            MenuActions.CreateMusic("Dia e Noite", "2:39", "Morada", "s");
            MenuActions.CreateMusic("És exaltado", "2:40", "Morada", "n");

            MenuActions.CreateAlbum("Long Live Love", "2019", "Kirk Franklin");
            MenuActions.CreateMusic("Love Theory", "2:00", "Kirk Franklin", "s");
            MenuActions.CreateMusic("Ok", "2:00", "Kirk Franklin", "s");
            MenuActions.CreateMusic("Just For Me", "2:12", "Kirk Franklin", "s");

            MenuActions.CreateAlbum("Hello Fear", "2020", "Kirk Franklin");
            MenuActions.CreateMusic("Never Alone", "2:15", "Kirk Franklin", "s");
            MenuActions.CreateMusic("I smile", "3:00", "Kirk Franklin", "s");
            MenuActions.CreateMusic("Today", "2:00", "Kirk Franklin", "n");

            MenuActions.CreateAlbum("Memórias", "2017", "Eli Soares");
            MenuActions.CreateMusic("Ao único", "2:00", "Eli Soares", "n");
            MenuActions.CreateMusic("Portas Abertas", "2:00", "Eli Soares", "n");
            MenuActions.CreateMusic("Ele é exaltado", "2:00", "Eli Soares", "s");
        }
    }
}
