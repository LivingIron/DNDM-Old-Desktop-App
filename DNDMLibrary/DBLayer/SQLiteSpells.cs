using Dapper;
using DNDMLibrary;
using DNDMLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDM
{
    public class SQLiteSpells
    {
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static List<SpellModel> LoadSpells()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<SpellModel>("SELECT * from Spells");
                return output.ToList();
            }
        }

        public static List<SchoolModel> LoadSchools()
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<SchoolModel>("SELECT * from MagicSchool");
                return output.ToList();
            }
        }



        public static void SaveSpell(SpellModel spell)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("INSERT INTO Spells(name,school_id,lvl,casting_time,range,components,duration,descr) VALUES (@name,@school_id,@lvl,@casting_time,@range,@components,@duration,@descr)", spell);
            }
        }

        public static bool CheckIfSpellExists(string spellName)
        {

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var exists = con.ExecuteScalar<bool>("SELECT COUNT(1) FROM Spells WHERE name=@spellName ", new { spellName });
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
