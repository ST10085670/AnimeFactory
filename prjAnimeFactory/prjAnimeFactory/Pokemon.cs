using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimeFactory
{
    internal class Pokemon : IAnime
    {
        public string getAuthor()
        {
            return "Satoshi Tajiri";
        }

        public string getCategory()
        {
            return "Adventure Fantasy";
        }

        public double getRate()
        {
            return 10;
        }

        public string getTitle()
        {
            return "Pokemon";
        }
    }
}
