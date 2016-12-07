using LiteDB;

namespace IMDBWCF.Models
{
    public static class DbModel
    {
        public static void SetFilmInDB(Film film)
        {
            using (var db = new LiteDatabase(@"D:\Projects\visual studio 2015\IMDBWCF\IMDBWCF\bin\Films.db"))
            {
                var col = db.GetCollection<Film>("films");
                col.Insert(film);
            }
        }

        public static Film GetFilmFromDB(string id)
        {
            using (var db = new LiteDatabase(@"D:\Projects\visual studio 2015\IMDBWCF\IMDBWCF\bin\Films.db"))
            {
                var col = db.GetCollection<Film>("films");
                return col.FindOne(film => film.Id == id);
            }
        }
    }
}
