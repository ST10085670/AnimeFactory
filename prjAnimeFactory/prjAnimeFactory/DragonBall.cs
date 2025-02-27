using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimeFactory
{
    internal class DragonBall : IAnime
    {
        public string getAuthor()
        {
            return "Akira Toriyama (RIP <3)";
        }

        public string getCategory()
        {
            return "Adventure fantasy";
        }

        public double getRate()
        {
            return 5;
        }

        public string getTitle()
        {
            return "Dragon ball Z";
        }
    }
}
