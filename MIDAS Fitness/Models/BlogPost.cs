using System;
using System.Collections.Generic;

namespace MIDAS_Fitness.Models
{
    public class BlogPost
    {
        public BlogPost()
        {
            // Initialize collections to prevent null reference exceptions
            Tags = new List<string>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }
        public int ViewCount { get; set; } // Track number of views

        public string FormattedDate => PublishedDate.ToString("MMMM dd, yyyy");

        // Returns the first paragraph of content for preview
        public string GetFirstParagraph()
        {
            if (string.IsNullOrEmpty(Content))
                return string.Empty;

            var paragraphs = Content.Split(new[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            return paragraphs.Length > 0 ? paragraphs[0] : Content;
        }

        // Returns estimated reading time in minutes
        public int GetReadingTime()
        {
            if (string.IsNullOrEmpty(Content))
                return 1;

            // Average reading speed is about 200-250 words per minute
            // Assuming 5 characters per word on average
            return Math.Max(1, Content.Length / 5 / 200);
        }
    }
}