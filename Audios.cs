#pragma warning disable CA1416 
using System.Media;
namespace Practice_PROG
{
    public class Audios
    {
        
        private string path = "C:/Users/Arlo/OneDrive - ADvTECH Ltd/Documents/PROG_6221/Practice_PROG/files/";
        private SoundPlayer? player;

        public void Play(string file)
        {
            string filePath = Path.Combine(path, file);
            player = new SoundPlayer(filePath);
            if (player == null) { return; }
            try
            {

                player.PlaySync();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing audio: {ex.Message}");
            }
        }//play
    }//CLASS: Audios
}//POE_PROG6221
#pragma warning restore CA1416 