using System;
class Song
{
    List<string> Lyrics;

    public Song(List<string> lyrics)
    {
        Lyrics = lyrics;
    }

    public void SingMeASong()
    {
        foreach (var line in Lyrics)
        {
            Console.WriteLine(line);
        }
    }
}

class Exercise11
{
    public static void Run()
    {
        var stairway = new Song(new List<string>{
            "There’s a lady who's sure",
            "all that glitters is gold",
            "and she’s buying a stairway to heaven"
        });

        stairway.SingMeASong();
    }
}
