using MusicCollection.Model;
using MusicCollection.Models;
using MusicCollection.Utils;
using MusicCollection.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Controllers {
    public class MenuActions {

        static List<Album> albums = new List<Album>();
        static List<Music> musics = new List<Music>();

        public static List<Album> getAlbums() {
            return DataBase.Albums;
        }

        public static List<Music> getMusics() {
            return DataBase.Musics;
        }
        public static void CreateAlbum(string title, string year, string bandName) {

            albums.Add(new Album(title, year, bandName));
            DataBase.Albums = albums;
        }
        public static void CreateMusic(string title, string duration, string album, string favorite) {
            musics.Add(new Music(title, duration, album, favorite));
            DataBase.Musics = musics;

        }

        public static void SeachAlbum(int type, string value) {

            Console.Clear();
            Component.PrintHeader();
            Console.WriteLine();

            foreach (Album obj in DataBase.Albums) {
                if (type == 1 && obj.Title.ToLower() == value.ToLower()) {
                    Console.WriteLine(obj);
                    Console.WriteLine();

                    foreach (Music obj2 in DataBase.Musics) {
                        if (obj2.BandName.ToLower() == obj.BandName.ToLower()) {
                            Console.WriteLine(obj2);
                        }
                    }
                    Console.WriteLine();
                }

                if (type == 2 && obj.Year == value) {
                    Console.WriteLine(obj);
                    Console.WriteLine();

                    foreach (Music obj2 in DataBase.Musics) {
                        if (obj2.BandName.ToLower() == obj.BandName.ToLower()) {
                            Console.WriteLine(obj2);
                        }
                    }
                    Console.WriteLine();
                }

                if (type == 3 && obj.BandName.ToLower() == value.ToLower()) {
                    Console.WriteLine(obj);
                    Console.WriteLine();

                    foreach (Music obj2 in DataBase.Musics) {
                        if (obj2.BandName.ToLower() == obj.BandName.ToLower()) {
                            Console.WriteLine(obj2);
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Aperte enter para voltar ao menu");
        }

        public static void SearchMusic(int type, string value) {

            Console.Clear();
            Component.PrintHeader();
            Console.WriteLine();

            Console.WriteLine($"Resultados para: {value} \n");

            foreach (Music obj in DataBase.Musics) {
                if (type == 1 && obj.Title.ToLower() == value.ToLower()) {
                    Console.WriteLine(obj);
                    Console.WriteLine();
                }

                if (type == 2 && obj.BandName.ToLower() == value.ToLower()) {
                    Console.WriteLine(obj);
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"Aperte enter para voltar ao menu");
        }

        public static void GeneratePlayList() {
            int countMusicTime = 0;
            int fullMusicsTime = 0;
            int contMusicQTD = 0;

            int currentDuration = 0;
            int timeLimitInSecond = 3600;

            List<Music> favoriteMusics = new List<Music>();
            List<Music> noFavoriteMusics = new List<Music>();
            List<Music> playList = new List<Music>();

            Console.Clear();
   
            foreach (Music obj in DataBase.Musics) {
                string[] duration = obj.Duration.Split(":");
                fullMusicsTime += Utility.CalcDurationInSeconds(int.Parse(duration[0]), int.Parse(duration[1]));

                if (obj.Favorite == "s") {
                    favoriteMusics.Add(obj);
                }
                else {
                    noFavoriteMusics.Add(obj);
                }
            }

            if (favoriteMusics.Count != 0) {
                while (countMusicTime < fullMusicsTime & countMusicTime <= fullMusicsTime / 2) {
                    Music currentMusic = favoriteMusics[new Random().Next(favoriteMusics.Count)];
                    string[] duration = currentMusic.Duration.Split(":");
                    countMusicTime += Utility.CalcDurationInSeconds(int.Parse(duration[0]), int.Parse(duration[1]));

                    if (!playList.Contains(currentMusic)) {
                        countMusicTime += currentDuration;
                        contMusicQTD += 1;

                        playList.Add(currentMusic);
                    }
                }
            }

            if (noFavoriteMusics.Count != 0) {
                while (countMusicTime < fullMusicsTime & countMusicTime < timeLimitInSecond) {
                    Music currentMusic = noFavoriteMusics[new Random().Next(noFavoriteMusics.Count)];
                    string[] duration = currentMusic.Duration.Split(":");
                    currentDuration = Utility.CalcDurationInSeconds(int.Parse(duration[0]), int.Parse(duration[1]));

                    if (!playList.Contains(currentMusic)) {
                        countMusicTime += currentDuration;
                        contMusicQTD += 1;

                        playList.Add(currentMusic);
                    }
                }
            }

            double durationInMinutes = (countMusicTime - currentDuration) / 60;

            Console.WriteLine("===================================");
            Console.WriteLine("===                             ===");
            Console.WriteLine("===            Resumo           ===");
            Console.WriteLine("===                             ===");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine($"Total de músicas na playlist: {contMusicQTD}");
            Console.WriteLine($"Tempo total da playlist: {durationInMinutes} min");
            Console.WriteLine();

            foreach (Music obj in playList) {
                Console.WriteLine(obj);
                Console.WriteLine();
            }

            Console.WriteLine($"Aperte enter para voltar ao menu");

            Console.ReadKey();
            Console.Clear();
        }
    }
}
