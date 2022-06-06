using MusicCollection.Model;
using MusicCollection.Controllers;
using MusicCollection.Repository;
using Xunit;
using System.Collections.Generic;
using System;

namespace MusicCollectionTests {
    public class MenuActionsTests {
        [Fact]
        public void Album_Creation_With_Success() {

            Album myAlbum = new Album("TituloTeste", "2022", "BandaTeste");

            MenuActions.CreateAlbum(myAlbum.Title, myAlbum.Year, myAlbum.BandName);

            List<Album> albums = MenuActions.getAlbums();

            Assert.NotNull(albums);
            Assert.Equal(albums[0].Title, myAlbum.Title);
            Assert.Equal(albums[0].Year, myAlbum.Year);
            Assert.Equal(albums[0].BandName, myAlbum.BandName);
        }

        [Fact]
        public void Music_Creation_With_Success() {

            Music myMusic = new Music("TituloTeste", "2:14", "BandaTeste", "s");

            MenuActions.CreateMusic(myMusic.Title, myMusic.Duration, myMusic.BandName, myMusic.Favorite);

            List<Music> musics = MenuActions.getMusics();

            Assert.NotNull(musics);
            Assert.Equal(musics[0].Title, myMusic.Title);
            Assert.Equal(musics[0].Duration, myMusic.Duration);
            Assert.Equal(musics[0].BandName, myMusic.BandName);
            Assert.Equal(musics[0].Favorite, myMusic.Favorite);
        }
    }
}