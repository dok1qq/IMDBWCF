using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using IMDBWCF.Models;

namespace IMDBWCF
{
    public class Service : IService
    {
        public Film GetFilmById(string id)
        {
            var film = FilmsModel.Control("title", id);
            if (film == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return film;
        }

        public Film GetFilmBySearch(string text)
        {
            //var text = Request.Content.ReadAsStringAsync();
            var film = FilmsModel.Search(text);
            if (film == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return film;
        }
    }
}
