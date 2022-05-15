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

namespace DNDM
{
    public class SQLiteDataAccess
    {
        public static List<DiceRollerModel> LoadDiceRollerPresets()
        {
            using(IDbConnection con=new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.Query<DiceRollerModel>("SELECT * from DiceRollerPresets");
                return output.ToList();
            }
        }

        public static void SaveDiceRollerPresets(DiceRollerModel dicePreset) {

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute(" INSERT INTO DiceRollerPresets (name ,D2Amount,D4Amount,D6Amount,D8Amount,D10Amount,D12Amount,D20Amount,D100Amount," +
                              "                                D2Mod,D4Mod,D6Mod,D8Mod,D10Mod,D12Mod,D20Mod,D100Mod) " +
                              " VALUES                        (@name ,@D2Amount,@D4Amount,@D6Amount,@D8Amount,@D10Amount,@D12Amount,@D20Amount,@D100Amount," +
                              "                                @D2Mod,@D4Mod,@D6Mod,@D8Mod,@D10Mod,@D12Mod,@D20Mod,@D100Mod)", dicePreset);
            }

        }

        public static DiceRollerModel LoadDiceRollerPresetByName(string presetName)
        {
            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var output = con.QuerySingle<DiceRollerModel>("SELECT * from DiceRollerPresets WHERE name = @presetName", new { presetName });
                return output;
            }
        }

        public static void DeleteDiceRollerPreset(string dicePreset)
        {

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("DELETE FROM DiceRollerPresets WHERE name = @dicePreset ",new { dicePreset });
            }

        }

        public static void UpdateDiceRollerPreset(DiceRollerModel dicePreset)
        {

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                con.Execute("UPDATE DiceRollerPresets SET " +
                    "                                     D2Amount=@D2Amount," +
                    "                                     D4Amount=@D4Amount," +
                    "                                     D6Amount=@D6Amount," +
                    "                                     D8Amount=@D8Amount," +
                    "                                     D10Amount=@D10Amount," +
                    "                                     D12Amount=@D12Amount," +
                    "                                     D20Amount=@D20Amount," +
                    "                                     D100Amount=@D100Amount," +
                    "                                     D2Mod=@D2Mod," +
                    "                                     D4Mod=@D4Mod," +
                    "                                     D6Mod=@D6Mod," +
                    "                                     D8Mod=@D8Mod," +
                    "                                     D10Mod=@D10Mod," +
                    "                                     D12Mod=@D12Mod," +
                    "                                     D20Mod=@D20Mod," +
                    "                                     D100Mod=@D100Mod" +
                    "                               WHERE name=@name;", dicePreset);
            }

        }


        public static bool CheckIfPresetExists(string dicePreset)
        {

            using (IDbConnection con = new SQLiteConnection(LoadConnectionString()))
            {
                var exists = con.ExecuteScalar<bool>("SELECT COUNT(1) FROM DiceRollerPresets WHERE name=@dicePreset ", new { dicePreset });
                return exists;
            }

        }


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
                con.Execute("INSERT INTO Notes(title,descr) VALUES (@title,@descr)",note);            
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
