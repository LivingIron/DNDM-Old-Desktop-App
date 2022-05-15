using Dapper;
using DNDMLibrary;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNDMLibrary.Models;

namespace DNDM
{
    public class SQLiteNote
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<NotesModel> LoadNotes()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<NotesModel>("SELECT * from Notes");
                return output.ToList();
            }
        }

        public static NotesModel LoadNoteById(int tempid)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Open();
                using (var command = con.CreateCommand())
                {
                    command.CommandText = "SELECT* from Notes WHERE id = @tempid";
                    command.Parameters.Add(new SQLiteParameter("@tempid", tempid));
                    var output = command.ExecuteReader();
                    NotesModel note = new NotesModel();
                    output.Read();
                    note.id = output.GetInt32(0);
                    note.title = output.GetString(1);
                    note.descr = output.GetString(2);


                    return note;
                }

            }
        }

        public static void SaveNote(NotesModel note)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("INSERT INTO Notes(title,descr) VALUES (@title,@descr)", note);
            }
        }

        public static bool CheckIfNoteExists(string note)
        {

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var exists = con.ExecuteScalar<bool>("SELECT COUNT(1) FROM Notes WHERE title=@note ", new { note });
                return exists;
            }

        }


        public static void UpdateNote(NotesModel note)
        {

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE Notes SET title=@title ,descr=@descr WHERE title=@title;", note);
            }

        }

    }
}
