using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection.Utils {
    class Utility {
        public static int CalcDurationInSeconds(int min, int sec) {
            return (min * 60) + sec;
        }
    }
}
