using System;

class Program
{
    static void Main(string[] args)
    {


        List<Video> youtubeVideos = new List<Video>();

        List<string[]> video1Comments = new List<string[]>();
        video1Comments.Add(new string[] { "saladbruh2625", "Here in Serbia I was never weirded out by Mort because he was voiced by a girl with a high pitch voice so he looked and sounded cute. When I heard Mort's voice in english I was weirded out tho." });
        video1Comments.Add(new string[] { "user999online", "yeah sure youtube i'll watch a 2 hour long video from three years ago about a character i haven't seen in a decade" });
        video1Comments.Add(new string[] { "Louwarrior2026", "the mental breakdown and descent into madness when he realized mort is actually death will never not be funny." });
        video1Comments.Add(new string[] { "periwinklesky777", "i cannot IMAGINE how much fun the writers had making All Hail King Julien. like, i'm pretty sure i would've pissed myself laughing coming up with these concepts and building off of them with people" });
        List<string[]> video2Comments = new List<string[]>();
        video2Comments.Add(new string[] { "FlakeyRice", "Charlie clutching the nightlord fight followed by him dropping onto a dragon and getting one shot, the duality of man" });
        video2Comments.Add(new string[] { "aaroncorrigan1308", "Exactly one hour is what caught my eye" });
        video2Comments.Add(new string[] { "Sean_S_00", "Gf: u got an hour to play\nCharlie: hold my beer" });
        List<string[]> video3Comments = new List<string[]>();
        video3Comments.Add(new string[] { "Do-u-know-da-wa", "Aint no way mark got an achievement for disposing 500 pieces of trash.😂 21:40" });
        video3Comments.Add(new string[] { "tst_09", "6:19 Mark finding fun in the activity that was supposed to be Wade's abuse is so passive aggressive." });
        video3Comments.Add(new string[] { "thexgamer8240", "Please do more of this series. We have been addicted to Charles and Seán's playthrough, so seeing Mark, Bob and Wade's series will complete the holy trinity." });
        List<string[]> video4Comments = new List<string[]>();
        video4Comments.Add(new string[] { "ilovethelegend", "I love how mark keeps getting enough information to know where all of the enemies are, and then just... leaves cards on the table." });
        video4Comments.Add(new string[] { "zedanide6984", "Balatro meets Minesweeper" });
        video4Comments.Add(new string[] { "bamers404", "Honestly, I expected any jumpscares or any unexpected things from Mr. Magpie\nBut on the other hand, the dev is being honest with the title, it's literally harmless" });
        video4Comments.Add(new string[] { "yaniobi", "3:30 Eminem has been realy quiet since this dropped..." });

        youtubeVideos.Add(new Video("The Most Disgusting Character in the History of Fiction", "The Theorizer", 9391, video1Comments));
        youtubeVideos.Add(new Video("Elden Ring Nightreign is Pretty Good", "penguinz0", 3600, video2Comments));
        youtubeVideos.Add(new Video("DEFINITELY NOT DRUGS | Schedule I - Part 2", "Markiplier", 1912, video3Comments));
        youtubeVideos.Add(new Video("Mr. Magpie's Harmless Card Game", "Markiplier", 2314, video4Comments));

        foreach (Video video in youtubeVideos)
        {
            Console.WriteLine(video.DisplayVideo());
        }
    }
}