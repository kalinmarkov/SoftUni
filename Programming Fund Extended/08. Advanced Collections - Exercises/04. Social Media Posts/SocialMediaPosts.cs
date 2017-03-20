using System;
using System.Collections.Generic;

class SocialMediaPosts
{
    static void Main(string[] args)
    {
        var socialMediaDatabase = new Dictionary<string, Dictionary<string, int>>();
        var commentDatabase = new Dictionary<string, Dictionary<string, List<string>>>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "drop the media")
            {
                break;
            }

            var tokens = input.Split();
            var postName = tokens[1];

            switch (tokens[0])
            {
                case "post":
                    if (!socialMediaDatabase.ContainsKey(postName))
                        socialMediaDatabase.Add(postName, new Dictionary<string, int>());
                    socialMediaDatabase[postName].Add("Likes", 0);
                    socialMediaDatabase[postName].Add("Dislikes", 0);
                    break;
                case "like":
                    socialMediaDatabase[postName]["Likes"]++;
                    break;
                case "dislike":
                    socialMediaDatabase[postName]["Dislikes"]++;
                    break;
                case "comment":
                    var commentator = tokens[2];
                    if (!commentDatabase.ContainsKey(postName))
                    {
                        commentDatabase.Add(postName, new Dictionary<string, List<string>>());
                    }
                    commentDatabase[postName].Add(commentator, new List<string>());
                    for (int i = 3; i < tokens.Length; i++)
                    {
                        commentDatabase[postName][commentator].Add(tokens[i]);
                    }
                    break;
            }
            
        }

        foreach (var postName in socialMediaDatabase.Keys)
        {
            var likes = socialMediaDatabase[postName];
            Console.Write($"Post: {postName}");
            foreach (var like in likes)
            {
                Console.Write($" | {like.Key}: {like.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Comments:");
            if (commentDatabase.ContainsKey(postName))
            {
                var comments = commentDatabase[postName];
                foreach (var person in comments)
                {
                    var commentator = person.Key;
                    var comment = string.Join(" ", person.Value);
                    Console.WriteLine($"*  {commentator}: {comment}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
