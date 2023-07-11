using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        
        List<Video> videos = new List<Video>();

        Video firstVideo = new Video
        {
            _title = "Trip to Indonesia",
            _author = "Stefano King",
            _length = 556
        };
        Comment firstComment = new Comment
        {
            _name = "Gianluca",
            _text = "Very interesting country!"
        };
        Comment secondComment = new Comment
        {
            _name = "Fiorella",
            _text = "I wanna go there!"
        };
        Comment thirdComment = new Comment
        {
            _name = "Roberto",
            _text = "What is the next country you are visiting?"
        };
        firstVideo.AddComment(firstComment);
        firstVideo.AddComment(secondComment);
        firstVideo.AddComment(thirdComment);

        Video secondVideo = new Video
        {
            _title = "Ice Bucket Challenge",
            _author = "LosDelBloque",
            _length = 327
        };
        Comment fourthComment = new Comment
        {
            _name = "Karina",
            _text = "Excellent video!"
        };
        Comment fifthComment = new Comment
        {
            _name = "Agustin",
            _text = "Cool content!"
        };
        secondVideo.AddComment(fourthComment);
        secondVideo.AddComment(fifthComment);

        Video thirdVideo = new Video
        {
            _title = "Top 10 Soccer Players",
            _author = "SoccerBoy",
            _length = 713
        };
        Comment sixthComment = new Comment
        {
            _name = "Micaela",
            _text = "Did not like it at all. It is very long!"
        };
        thirdVideo.AddComment(sixthComment);

        videos.Add(firstVideo);
        videos.Add(secondVideo);
        videos.Add(thirdVideo);

        
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("COMMENTS");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("Commenter: " + comment._name + ":"+" '" +comment._text +"'");
                
            }

            Console.WriteLine();
        }
    }
}
