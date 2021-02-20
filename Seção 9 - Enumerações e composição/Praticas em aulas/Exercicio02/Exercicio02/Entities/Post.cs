﻿using System;
using Exercicio02.Entities;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public int Likes { get; set; }
        public string Content { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, int likes, string content)
        {
            Moment = moment;
            Title = title;
            Likes = likes;
            Content = content;
        }

        public void AddComments(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComments(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
    }
}
