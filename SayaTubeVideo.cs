using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace JurnalModul6_103082400004_Muh_Aqsa_Sirojudin
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title.Length <= 200, "Error: Judul tidak boleh null dan maksimal 200 karakter.");

            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count >= 0 && count <= 25000000, "Error: Input play count harus positif dan maksimal 25.000.000.");

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine("\n[Exception Caught] Penambahan play count melebihi batas tertinggi integer!");
                Console.WriteLine("Pesan Error: " + e.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine($"Video ID   : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
        }

        public int GetPlayCount() { return playCount; }
        public string GetTitle() { return title; }
    }
}