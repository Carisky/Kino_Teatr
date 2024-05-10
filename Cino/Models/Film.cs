using System;
using System.Collections.Generic;

namespace Cino.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Style { get; set; }
        public DateTime PublisedAt { get; set; }
        public DateTime EndSessions { get; set; }
        public List<Session> Sessions { get; set; }

        public Film()
        {
            Title = "Title";
            Author = "";
            Style = "";
            PublisedAt = DateTime.Now;
            EndSessions = DateTime.Now;
            Sessions = new List<Session>();
        }

        public Film(string title, string author, string style, DateTime publishedAt, DateTime endSessions, List<Session> sessions, int id)
        {
            Title = title;
            Author = author;
            Style = style;
            PublisedAt = publishedAt;
            EndSessions = endSessions;
            Sessions = sessions;
            Id = id;
        }
    }
}
