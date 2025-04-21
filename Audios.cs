#pragma warning disable CA1416 
using System.Media;
namespace POE_PROG6221
{
    public class Audios
    {
        
        private string path = "C:/Users/Arlo/OneDrive - ADvTECH Ltd/Documents/PROG_6221/POE_PROG6221/files/";
        private SoundPlayer player;

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