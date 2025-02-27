namespace prjAnimeFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimeFactory factory = new AnimeFactory();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Please enter your anime");
            Console.WriteLine("----------------------------------------------");
            string selectedAnime = Console.ReadLine();
            IAnime anime = factory.getAnime(selectedAnime);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Title: {0} \nAuthor: {1} \nCategory: {2} \nRating {3}", anime.getTitle(), anime.getAuthor(), anime.getCategory(), anime.getRate());
            Console.WriteLine("----------------------------------------------");
        }
    }
}
