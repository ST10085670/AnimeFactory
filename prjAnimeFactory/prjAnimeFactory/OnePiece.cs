using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimeFactory
{
    internal class OnePiece : IAnime
    {
        public string getAuthor()
        {
            return "Eiichiro Oda";
        }

        public string getCategory()
        {
            return "Shonen";
        }

        public double getRate()
        {
            return 4;
        }

        public string getTitle()
        {
            return "One Piece";
        }
    }
}
