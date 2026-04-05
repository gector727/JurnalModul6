using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalModul6_103082400004_Muh_Aqsa_Sirojudin
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random rnd = new Random();
            this.id = rnd.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
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
