using MusicCollection.Views;
using MusicCollection.Utils;
using MusicCollection.Controllers;
using MusicCollection.Model;

namespace MusicCollection {
    internal class Program {
        static void Main(string[] args) {

            Mock.GenerateData();
            Menu.Principal();

        }
    }
}
