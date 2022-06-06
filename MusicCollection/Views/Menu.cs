using MusicCollection.Model;
using MusicCollection.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MusicCollection.Models;

namespace MusicCollection.Views {
    class Menu {

        //static List<Album> albums = new List<Album>();
        public static void Principal() {
            int option = 0;
            bool valid, showMenu = true;

            while (showMenu) {

                Console.Clear();
                Component.PrintHeader();
                Console.WriteLine();

                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine();
                Console.WriteLine("1- Cadastrar álbum");
                Console.WriteLine("2- Pesquisar coleção de álbuns");
                Console.WriteLine("3- Pesquisar coleção de músicas");
                Console.WriteLine("4- Gerar Playlist");
                Console.WriteLine("5- Sair");
                Console.WriteLine();

                valid = Int32.TryParse(Console.ReadLine(), out option);

                if (!valid) {
                    Principal();
                }

                switch (option) {
                    case 1:
                        AlbumRegister();
                        Console.ReadKey();
                        break;
                    case 2:
                        SearchAlbum();
                        Console.ReadKey();
                        break;
                    case 3:
                        SearchMusic();
                        Console.ReadKey();
                        break;
                    case 4:
                        MenuActions.GeneratePlayList();
                        Console.Clear();
                        Principal();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção inválida, tente novamente.");
                        Console.WriteLine($"Aperte enter....");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void AlbumRegister() {
            bool showMenu = true, valid;
            string title, year, bandName;

            while (showMenu) {

                Console.Clear();
                Component.PrintHeader();
                Console.WriteLine();

                Console.WriteLine("Informe o título do álbum");
                title = Console.ReadLine();
                Console.WriteLine("Informe o ano do álbum");
                year = Console.ReadLine();
                Console.WriteLine("Informe a banda do álbum");
                bandName = Console.ReadLine();

                MenuActions.CreateAlbum(title, year, bandName);
                MusicRegister(bandName);

            }
        }

        public static void MusicRegister(string bandName) {
            Console.Clear();
            bool valid;
            string title, duration, favorite;

            Component.PrintHeader();
            Console.WriteLine();
            Console.WriteLine("Informe o título do música");
            title = Console.ReadLine();
            Console.WriteLine("Informe a duração da música (00:00)");
            duration = Console.ReadLine();
            Console.WriteLine("Informe se é música favorita (s/n)");
            favorite = Console.ReadLine();

            Console.Clear();
            MenuActions.CreateMusic(title, duration, bandName, favorite);
            Console.WriteLine();
            Console.WriteLine("Deseja adicionar mais uma musica? (s/n)");

            if (Console.ReadLine() == "s") {
                MusicRegister(bandName);
            }

            Console.Clear();
            Principal();
        }

        public static void SearchAlbum() {
            bool showMenu = true;
            int option;
            bool valid;
            string title, year, bandName;

            while (showMenu) {
                Console.Clear();
                Component.PrintHeader();
                Console.WriteLine();
                Console.WriteLine("Informe o modo de busca do Álbum:");
                Console.WriteLine("1- Nome do álbum");
                Console.WriteLine("2- Ano de lançamento");
                Console.WriteLine("3- Nome da Banda");
                Console.WriteLine("4- Sair");
                Console.WriteLine();

                valid = Int32.TryParse(Console.ReadLine(), out option);

                if (!valid) {
                    SearchAlbum();
                }

                switch (option) {
                    case 1:
                        Console.Clear();
                        Component.PrintHeader();
                        Console.WriteLine();
                        Console.WriteLine("Infome o nome do álbum: ");

                        MenuActions.SeachAlbum(option, Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Component.PrintHeader();
                        Console.WriteLine();
                        Console.WriteLine("Infome o ano de lançamento do álbum: ");

                        MenuActions.SeachAlbum(option, Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Component.PrintHeader();
                        Console.WriteLine();
                        Console.WriteLine("Infome o nome da banda do álbum: ");

                        MenuActions.SeachAlbum(option, Console.ReadLine());
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Principal();
                        break;
                }
            }
        }

        public static void SearchMusic() {
            bool showMenu = true;
            int option;
            bool valid;
            string title, bandName;

            while (showMenu) {
                Console.Clear();
                Component.PrintHeader();
                Console.WriteLine();
                Console.WriteLine("Informe o modo de busca da música:");
                Console.WriteLine("1- Título da música");
                Console.WriteLine("2- Nome da Banda");
                Console.WriteLine("3- Sair");
                Console.WriteLine();

                valid = Int32.TryParse(Console.ReadLine(), out option);

                if (!valid) {
                    SearchMusic();
                }

                switch (option) {
                    case 1:
                        Console.Clear();
                        Component.PrintHeader();
                        Console.WriteLine();
                        Console.WriteLine("Infome o título da música: ");

                        MenuActions.SearchMusic(option, Console.ReadLine());
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Component.PrintHeader();
                        Console.WriteLine();
                        Console.WriteLine("Infome o nome da banda da música: ");

                        MenuActions.SearchMusic(option, Console.ReadLine());
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Principal();
                        break;
                }
            }
        }
    }
}
