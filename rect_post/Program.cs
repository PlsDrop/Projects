using System;
using System.Collections.Generic;

namespace Rect_Post
{

    class Rect
    {
        public int topLeftX;
        public int topLeftY;
        public int width;
        public int height; 

        public void Move(int moveX, int moveY)
        {   
            this.topLeftX += moveX;
            this.topLeftY += moveY;
        }

        public int GetArea()
        {   
            return (width*height);
        }

        public int GetPerimeter()
        {
            return (width*2)+(height*2);
        }

        public override string ToString()
        {
            return $"(x: {topLeftX}, y: {topLeftY}) width: {width} height: {height}";
        }
    } 

    class Post
    {
        public string author;
        public string text;
        public DateTime publicationDate;
        public int likes;
        public bool visibility;
        public List<Post> comments;


        public Post(string author_, string text_)
        {
            likes = 0;
            author = author_;
            text = text_;
            comments = new List<Post>();
        }

        public void Like()
        {
            likes++;
        }

        public int GetLikesNumber()
        {
            return likes;
        }

        public void LeaveComment(string author, string text)
        {
            comments.Add(new Post(author,text));
        }

        public string[] GetComments()
        {
            int counter = 0;
            int commentsLenght = comments.Count;
            string[] allComments = new string[commentsLenght];
            
            foreach(Post comment in comments)
            {
                allComments[counter] = $" comment: {comment.text} \n Author: {comment.author} ";
                counter++;
            }
            return allComments;
        }

        public override string ToString()
        {
            return $" {text}\n Author: {author}\n likes = {likes}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Post
            Post post1 = new Post("Anton" , "I need some food.");

            Console.WriteLine(post1);
            
            post1.Like();
            Console.WriteLine(post1);
            
            Console.WriteLine(post1.GetLikesNumber());
            
            post1.LeaveComment("Natasha" , "Nope, no food for you.");
            Console.WriteLine(post1.GetComments()[0]);


            //Rect
            Rect rect1 = new Rect();
            rect1.height = 2;
            rect1.width = 3;
            rect1.topLeftX = 0;
            rect1.topLeftY = 0;
            Console.WriteLine(rect1);

            rect1.Move(3,-1);
            Console.WriteLine(rect1);

            Console.WriteLine(rect1.GetPerimeter());
            
            Console.WriteLine(rect1.GetArea());

        }
    }
}
