namespace JurnalModul6_103082400004_Muh_Aqsa_Sirojudin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namaPraktikan = "Muh Aqsa Sirojudin";

            SayaTubeUser user = new SayaTubeUser(namaPraktikan);

            string[] judulFilm = { "Film 1", "Film 2", "Film 3", "Film 4",
                                   "Film 5", "Film 6", "Film 7", "Film 8",
                                   "Film 9", "Film 10" };

            for (int i = 0; i < 10; i++)
            {
                SayaTubeVideo video = new SayaTubeVideo($"Review Film {judulFilm[i]} oleh {namaPraktikan}");
                video.IncreasePlayCount(25000000);
                user.AddVideo(video);
            }

            Console.WriteLine("=== Menguji Postcondition (Maksimal 8 Print) ===");
            user.PrintAllVideoPlaycount();

            Console.WriteLine($"\nTotal Play Count Keseluruhan: {user.GetTotalVideoPlayCount()}");

            Console.WriteLine("\n=== Menguji Exception (Overflow) ===");
            SayaTubeVideo videoTest = new SayaTubeVideo("Video Test Exception");
            for (int i = 0; i < 100; i++)
            {
                videoTest.IncreasePlayCount(25000000);
            }

            Console.ReadLine();
        }
    }
}
