using System;

class Program
{
    static void Main(string[] args)
    {
        int commentCounter = 0;
        VideoList list = new VideoList();

        Video vid1 = new Video();
        vid1._title = "Last To Take Hand Off Jet, Keeps it!";
        vid1._author = "MrBeast";
        vid1._length = "15:37";
        list._videoList.Add(vid1);
        Comments com1 = new Comments();
        com1._commentersName = "JJ Olatunji";
        com1._commentText = "This game is awesome! I wish I'm part of the game.";
        list._commentsList.Add(com1);
        commentCounter ++;
        Comments com2 = new Comments();
        com2._commentersName = "Logan Paul";
        com2._commentText = "I will 100% win the game if I play it.";
        list._commentsList.Add(com2);
        commentCounter ++;
        Comments com3 = new Comments();
        com3._commentersName = "Miniminter";
        com3._commentText = "Man, Harry is so gassed to take that jet home!";
        list._commentsList.Add(com3);
        commentCounter ++;
        list.Display();
        Console.WriteLine($"Number of comments: {commentCounter}");
        list._videoList.Clear();
        list._commentsList.Clear();
        commentCounter = 0;

        Video vid2 = new Video();
        vid2._title = "We're having a baby!";
        vid2._author = "PewDiePie";
        vid2._length = "1:31";
        list._videoList.Add(vid2);
        Comments com4 = new Comments();
        com4._commentersName = "JC Maala";
        com4._commentText = "I'm so happy for the both of you! I'm sure you and Marzia are gonna be a great parent.";
        list._commentsList.Add(com4);
        commentCounter ++;
        Comments com5 = new Comments();
        com5._commentersName = "Ethan Payne";
        com5._commentText = "I can tell Felix is so happy knowing he's about to become a dad. I know that feeling.";
        list._commentsList.Add(com5);
        commentCounter ++;
        Comments com6 = new Comments();
        com6._commentersName = "Talia Mar";
        com6._commentText = "This made me so happy! I'm excited to see your baby!";
        list._commentsList.Add(com6);
        commentCounter ++;
        list.Display();
        Console.WriteLine($"Number of comments: {commentCounter}");
        list._videoList.Clear();
        list._commentsList.Clear();
        commentCounter = 0;

        Video vid3 = new Video();
        vid3._title = "THE GREATEST SIDEMENT MOMENTS 2022";
        vid3._author = "Sidemen";
        vid3._length = "31:21";
        list._videoList.Add(vid3);
        Comments com7 = new Comments();
        com7._commentersName = "Josh Zerkaa";
        com7._commentText = "I had so much fun making these videos with the boys. What a year it has been!";
        list._commentsList.Add(com7);
        commentCounter ++;
        Comments com8 = new Comments();
        com8._commentersName = "TommyInnit";
        com8._commentText = "Been a fan of this group since high school. Happy to see them still making entertaining videos.";
        list._commentsList.Add(com8);
        commentCounter ++;
        Comments com9 = new Comments();
        com9._commentersName = "Stephen Tries";
        com9._commentText = "I can't believe I was in the video. I had fun, tho for sure!";
        list._commentsList.Add(com9);
        commentCounter ++;
        list.Display();
        Console.WriteLine($"Number of comments: {commentCounter}");
        list._videoList.Clear();
        list._commentsList.Clear();
        commentCounter = 0;



        
        

    }
}