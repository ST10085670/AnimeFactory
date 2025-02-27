using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjAnimeFactory
{
    public interface IAnime
    {
        String getCategory();
        String getTitle();
        String getAuthor();
        double getRate();

    }
}
