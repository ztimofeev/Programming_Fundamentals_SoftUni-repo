namespace SocialMediaPosts
{
    using System;
    using System.Collections.Generic;

    public class SocialMediaPosts
    {
        public static void Main()
        {
            Dictionary<string, int[]> posts = new Dictionary<string, int[]>();
            Dictionary<string, Dictionary<string, string>> comments = new Dictionary<string, Dictionary<string, string>>();

            var inputData = Console.ReadLine();

            while (inputData != "drop the media")
            {
                var tokens = inputData.Split();
                var keyWord = tokens[0];
                var postName = tokens[1];

                switch (keyWord)
                {
                    case "post":
                    {
                        if (!posts.ContainsKey(postName))
                        {
                            posts.Add(postName, new int[2]);
                        }
                        break;
                    }

                    case "like":
                    {
                        posts[postName][0]++;
                        break;
                    }
                        
                    case "dislike":
                    {
                        posts[postName][1]++;
                        break;
                    }

                    case "comment":
                    {
                        var commentatorsName = tokens[2];
                        var commentContent = String.Empty;

                        for (int i = 3; i < tokens.Length; i++)
                        {
                            if (i != tokens.Length - 1)
                            {
                                commentContent += tokens[i] + " ";
                            }
                            else
                            {
                                commentContent += tokens[i];
                            }
                        }

                        if (!comments.ContainsKey(postName))
                        {
                            comments[postName] = new Dictionary<string, string>();
                        }
                        comments[postName].Add(commentatorsName, commentContent);
                        break;
                    }
                }

                inputData = Console.ReadLine();
            }

            foreach (var post in posts)
            {
                var postName = post.Key;
                var likes = post.Value[0];
                var dislikes = post.Value[1];
                bool isComment = true;

                Console.WriteLine($"Post: {postName} | Likes: {likes} | Dislikes: {dislikes}");
                Console.WriteLine("Comments:");

                foreach (var comment in comments)
                {
                    var currentPost = comment.Key;
                    var currentPostData = comment.Value;

                    foreach (var commentData in currentPostData)
                    {
                        var commentator = commentData.Key;
                        var content = commentData.Value;

                        if (postName == currentPost)
                        {
                            Console.WriteLine($"*  {commentator}: {content}");
                            isComment = false;
                        }
                    }
                }

                if (isComment)
                {
                    Console.WriteLine("None");
                }
            }
        }
    }
}
