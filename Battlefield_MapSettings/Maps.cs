using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Maps
{
    public static Map_Info[] maps { get; set; }

    public static void Get_Maps(SQLiteConnection db_Connection)
    {
        string sql = "SELECT [Engine name], [Human-readable name], [Game modes,,,,,,,,,] FROM [main].[BF4 PC Maps] ORDER BY [Human-readable name] ASC;";
        SQLiteCommand command = new SQLiteCommand(sql, db_Connection);
        SQLiteDataReader reader = command.ExecuteReader();
        List<Map_Info> map_list = new List<Map_Info>();
        while (reader.Read())
        {
            map_list.Add(new Map_Info() { Engine_Name = reader["Engine name"].ToString(), Human_readable_name = reader["Human-readable name"].ToString(), Game_modes = reader["Game modes,,,,,,,,,"].ToString(), });
        }
        maps = map_list.ToArray();
    }

    public static void Get_Maps(SQLiteConnection db_Connection, ref ComboBox cBox_map_name, ref RichTextBox rTBox_log)
    {
        Get_Maps(db_Connection);
        if(maps != null)
        {
            cBox_map_name.Items.Clear();
            rTBox_log.Text += String.Format("{0} {1}", "***Maps Loading Started***", "\r\n");
            for(int i = 0; i < maps.Length;i++)
            {
                cBox_map_name.Items.Add(maps[i].Human_readable_name);
                rTBox_log.Text += String.Format("Engine name: {0,-18} | Human-readable name: {1}", maps[i].Engine_Name, maps[i].Human_readable_name);
                rTBox_log.Text += Environment.NewLine;
            }
            rTBox_log.Text += String.Format("{0} {1}", "***Maps Loading Finished***", "\r\n");
        }
    }
}

public class Map_Info
{
    public String Engine_Name { get; set; }
    public String Human_readable_name { get; set; }
    public String Game_modes { get; set; }
}