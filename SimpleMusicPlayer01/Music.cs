using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SimpleMusicPlayer01
{
    class Music
    {

        //importowanie winmm.dll pozwalającego odtworzyc mp3
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwndCallback);

        //wybor pliku do odtworzenia
        public void open(string file)
        {
            string command = "open \"" + file + "\" type MPEGVideo alias MyMusic";
            mciSendString(command, null, 0, 0);
        }

        //odtwarzanie pliku
        public void play()
        {
            string command = "play MyMusic";
            mciSendString(command, null, 0, 0);
        }

        //pauzowanie
        public void pause()
        {
            string command = "stop MyMusic";
            mciSendString(command, null, 0, 0);
        }

        //zatrzymywanie
        public void stop()
        {
            string command = "close MyMusic";
            mciSendString(command, null, 0, 0);
        }
    }
}
