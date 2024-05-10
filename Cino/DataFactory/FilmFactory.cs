using Cino.Models;
using Faker;
using System;
using System.Collections.Generic;

namespace Cino.DataFactory
{
    public static class FilmFactory
    {
        private static readonly Random random = new Random();

        public static Film CreateFilm(int id, string title, string author, string style, DateTime publishedAt, DateTime endSessions, List<Session> sessions)
        {
            return new Film(title, author, style, publishedAt, endSessions, sessions, id);
        }

        public static Film CreateRandomFilm(int id)
        {
            string title = NameFaker.MaleFirstName();
            string author = NameFaker.MaleName();
            string style = NumberFaker.Number(1,5).ToString();
            DateTime publishedAt = DateTimeFaker.DateTimeBetweenYears(2004, 2020);
            DateTime endSessions = publishedAt.AddHours(random.Next(1, 48));
            List<Session> sessions = CreateRandomSessions(random.Next(1, 5));

            return new Film(title, author, style, publishedAt, endSessions, sessions, id);
        }

        private static List<Session> CreateRandomSessions(int count)
        {
            List<Session> sessions = new List<Session>();

            for (int i = 0; i < count; i++)
            {
                DateTime startTime = DateTimeFaker.DateTimeBetweenMonths(1,12);
                sessions.Add(new Session(startTime, startTime.AddMonths(1)));
            }

            return sessions;
        }

        public static List<Film> CreateRandomFilms(int count)
        {
            List<Film> films = new List<Film>();

            for (int i = 0; i < count; i++)
            {
                films.Add(CreateRandomFilm(i+1));
            }

            return films;
        }
    }
}
