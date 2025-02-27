using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimeFactory
{
    public class AnimeFactory
    {
        private IAnime returnInt;

        public IAnime getAnime(String AnimeType) 
        {
            if (AnimeType.ToLower().Equals("pokemon")) 
            {
                returnInt = new Pokemon();
            }
            else if (AnimeType.ToLower().Equals("dragonball"))
            {
                returnInt = new DragonBall();
            }
            else if (AnimeType.ToLower().Equals("one piece"))
            {
                returnInt = new OnePiece();
            }
            else 
            {
                returnInt = new DemonSlayer();
            }

            return returnInt;
        }
    }
}
