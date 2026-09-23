using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Inspiring Short: When Angels Are Busy | Don R.Clarke", "BYU Speeches", 214);
        video1.AddComment("steven dorsey", "I love this story! Regular people can surely be used as subs for angels when needed.");
        video1.AddComment("craig norton", "God calls on all of us to be ministers. We're placed on the earth to comfort the sick or afflicted, and to help those in need. It's a tender mercy. I truly believe this.");
        video1.AddComment("lori harding", "What a beautiful reminder that Heavenly Father puts us in places to help others if we are intune to the promptings and stop and act.  We are His Hands!");
        videos.Add(video1);
        Video video2 = new Video("Inspiring Short: The Unlikely Shepherd | R.Kent Crookston", "BYU Speeches", 214);
        video2.AddComment("anonymous", "This reminds me that the Lord can qualify those whom He calls, and He can see in each of us what others cannot. If we turn to Him and rely on Him, we can become who He knows we can.");
        video2.AddComment("julian anixdite", "Seem to be hearing this message a lot lately. Reminders that God often chooses the weak and simple.");
        video2.AddComment("charles richardson", "The lord sees what we can not, our eyes and hearts are quik to judge, i still struggle in this life, but we all have 3rd an 4th chances to love and live and believe in our lord & savior");
        videos.Add(video2);
        Video video3 = new Video("Inspiring Short: The Whisperings of Heaven | Bruce C. Hafen", "BYU Speeches", 234);
        video3.AddComment("anonymous", "I love the humility that Elder Hafen exhibited in sharing this message.");
        video3.AddComment("macdonald douglas", "This was great... I went through something similar on my mission, I really know that this Gospel is True.");
        video3.AddComment("acelius deminuis", "Valuable lessen for all who watch this. Thanks for posting!!");
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideo());
            Console.WriteLine();
        }

    }
}