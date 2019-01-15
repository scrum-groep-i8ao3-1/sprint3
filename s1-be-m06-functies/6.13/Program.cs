using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace _6._13

{
    class Program
    {
        static void Main()
        {
            // Create new SoundPlayer in the using statement.
            using (SoundPlayer player = new SoundPlayer("C:\\bass.wav"))
            {
                // Use PlaySync to load and then play the sound.
                // ... The program will pause until the sound is complete.
                player.PlaySync();
            }
        }
    }
}
