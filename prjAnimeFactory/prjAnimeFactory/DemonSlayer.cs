using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimeFactory
{
    internal class DemonSlayer : IAnime
    {
        public string getAuthor()
        {
            return "Koyoharu Gotouge";
        }

        public string getCategory()
        {
            return "Dark Fantasy";
        }

        public string getTitle()
        {
            return "Demon Slayer: Kimetsu no Yaiba";
        }

        public double getRate()
        {
            return 4.5;
        }
    }
}
