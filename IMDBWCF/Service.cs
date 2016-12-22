using System;
using System.Runtime.Serialization;
using IMDBWCF.Models;

namespace IMDBWCF
{
    public class Service : IService
    {

        public Film GetFilmById(string id)
        {
            var film = FilmsModel.Control("title", id);
            return film;
        }


        public Film GetFilmBySearch(string text)
        {
            var film = FilmsModel.Search(text);
            return film;
        }
    }
}
