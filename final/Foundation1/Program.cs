public class Program
{
    public static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Tutorial", "John Doe", 300);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));
        video1.AddComment(new Comment("Bob", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Charlie", "Could you explain more about classes?"));

        Video video2 = new Video("Cooking Pasta", "Jane Smith", 600);
        video2.AddComment(new Comment("David", "Yummy!"));
        video2.AddComment(new Comment("Eva", "Thanks for the recipe!"));
        video2.AddComment(new Comment("Frank", "Can I use whole wheat pasta instead?"));

        Video video3 = new Video("Yoga for Beginners", "Mary Johnson", 450);
        video3.AddComment(new Comment("George", "Feeling relaxed already."));
        video3.AddComment(new Comment("Hannah", "Just what I needed."));
        video3.AddComment(new Comment("Ian", "Great session!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine(video.ToString());
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine(comment.ToString());
            }
            Console.WriteLine();
        }
    }
}