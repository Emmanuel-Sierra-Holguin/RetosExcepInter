namespace RetoInterfaces
{
    // interfaz 
    interface IMediaPlayer
    {
        // Metodos
        void Play();
        void Pause();
        void Stop();
        string GetCurrentTrack();
    }

    class MusicPlayer : IMediaPlayer
    {
        // Campo 
        private string current_track = "Sin pista";
        // Metodo Clase
        
        // Metodos interfaz
        public void Play()
        {
            Console.WriteLine($"Reproduciendo: {current_track}");
        }

        public void Pause()
        {
            Console.WriteLine("Pista en Pausa");
        }

        public void Stop()
        {
            Console.WriteLine("Reproduccion detenida");
            current_track = "Sin pista";
        }

        public string GetCurrentTrack()
        {
           return current_track;
        }

        public void LoadTrack(string track_name)
        {
            current_track = track_name;
            Console.WriteLine($"Pista Cargada: {current_track}");
        }
    }

    class Program
    {
     static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();
            
            Console.WriteLine($"Reprodutor: {player.GetCurrentTrack()}");

            player.LoadTrack("Lies");
            player.Play();
            player.Pause();
            player.Stop();
        }   
    }
}