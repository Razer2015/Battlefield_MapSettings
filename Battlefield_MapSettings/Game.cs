using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Game
{
    public static Game_Mode[] game_modes { get; set; }

    #region Game Modes
    public static void Get_GameModes(SQLiteConnection db_Connection, String game_modes_list)
    {
        List<Game_Mode> game_mode_list = new List<Game_Mode>();
        String[] game_modes_array = game_modes_list.Split(',');
        for (int i = 0; i < game_modes_array.Length; i++)
        {
            String g_mode_search = game_modes_array[i];
            String col_name = String.Empty;
            if (!String.IsNullOrEmpty(game_modes_list)) { col_name = "[Engine Name] = '"; col_name += g_mode_search; col_name += "'"; } else { col_name = "1"; }

            string sql = "SELECT [Engine Name], [Human-Readable Name], [Intended max player count] FROM [main].[BF4 PC Game Modes] WHERE " + col_name + ";";
            SQLiteCommand command = new SQLiteCommand(sql, db_Connection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                game_mode_list.Add(new Game_Mode() { Engine_Name = reader["Engine name"].ToString(), Human_readable_name = reader["Human-readable name"].ToString(), Intended_max_player_count = Convert.ToInt32(reader["Intended max player count"]) });
            }
        }
        game_modes = game_mode_list.ToArray();
    }

    public static void Get_GameModes(SQLiteConnection db_Connection, String game_modes_list, ref ComboBox cBox_game_mode, ref RichTextBox rTBox_log)
    {
        Get_GameModes(db_Connection, game_modes_list);
        if (game_modes != null)
        {
            cBox_game_mode.Items.Clear();
            rTBox_log.Text += String.Format("{0} {1}", "***Game Mode Loading Started***", "\r\n");
            for (int i = 0; i < game_modes.Length; i++)
            {
                cBox_game_mode.Items.Add(game_modes[i].Human_readable_name);
                rTBox_log.Text += String.Format("Engine name: {0,-18} | Human-readable name: {1}", game_modes[i].Engine_Name, game_modes[i].Human_readable_name);
                rTBox_log.Text += Environment.NewLine;
            }
            rTBox_log.Text += String.Format("{0} {1}", "***Game Mode Loading Finished***", "\r\n");
        }
    }
    #endregion

    public static Game_Faction game_faction { get; set; }

    #region Game Factions
    public static void Get_GameFaction(SQLiteConnection db_Connection, String Engine_Name)
    {
        string sql = "SELECT [Engine Name], [Human-Readable Name], [Team 1], [Team 2] FROM [main].[BF4 PC Game Factions] WHERE [Engine Name] = '" + Engine_Name + "'";
        SQLiteCommand command = new SQLiteCommand(sql, db_Connection);
        SQLiteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            game_faction = (new Game_Faction() { Engine_Name = reader["Engine name"].ToString(), Human_readable_name = reader["Human-readable name"].ToString(),
                Team_1 = (Game_Faction.Factions)Enum.Parse(typeof(Game_Faction.Factions), reader["Team 1"].ToString()),
                Team_2 = (Game_Faction.Factions)Enum.Parse(typeof(Game_Faction.Factions), reader["Team 2"].ToString())
            });
        }
    }

    public static void Get_GameFaction(SQLiteConnection db_Connection, String Engine_Name, Game_Mode game_mode, ref Label label)
    {
        Get_GameFaction(db_Connection, Engine_Name);
        if (game_faction == null)
            return;

        if(game_mode.Engine_Name == "SquadDeathMatch0" || game_mode.Engine_Name == "SquadObliteration0")
        {
            label.Text = String.Format("Team 1: {0} -|- Team 2: {1} -|- Team 3: {0} -|- Team 4: {1}", game_faction.Team_1, game_faction.Team_2);
        }
        else
        {
            label.Text = String.Format("Team 1: {0} -|- Team 2: {1}", game_faction.Team_1, game_faction.Team_2);
        }
    }
    #endregion

    public static Game_Ticket game_tickets { get; set; }

    #region Game Tickets
    public static void Get_GameTickets(SQLiteConnection db_Connection, String Engine_Name)
    {
        String col_name = String.Empty;
        if (!String.IsNullOrEmpty(Engine_Name)) { col_name = "[Engine Name] = '"; col_name += Engine_Name; col_name += "'"; } else { col_name = "1"; }
        string sql = "SELECT [Engine Name], [Human-Readable Name], [Default value (tickets)] FROM [main].[BF4 PC Game Tickets] WHERE " + col_name + "";
        SQLiteCommand command = new SQLiteCommand(sql, db_Connection);
        SQLiteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            game_tickets = (new Game_Ticket() { Engine_Name = reader["Engine name"].ToString(), Human_readable_name = reader["Human-readable name"].ToString(), Default_value = (reader["Default value (tickets)"] != DBNull.Value) ? Convert.ToInt32(reader["Default value (tickets)"]) : 0 });
        }
    }

    public static void Get_GameTickets(SQLiteConnection db_Connection, String Engine_Name, ref Label label)
    {
        Get_GameTickets(db_Connection, Engine_Name);
        if (game_tickets == null)
            return;

        if (game_tickets.Default_value == 0)
        {
            label.Text = String.Format("Tickets: {0}", "N/A");
        }
        else
        {
            label.Text = String.Format("Tickets: {0}", game_tickets.Default_value);
        }
    }
    #endregion

    public static Game_Ticket_v2 game_tickets_v2 { get; set; }

    #region Game Tickets V2
    public static void Get_GameTickets_v2(SQLiteConnection db_Connection, String Table_Name, String Engine_Name)
    {
        String table_name = "[main].[BF4 PC ";
        if (Table_Name == "Elimination0" || Table_Name == "Obliteration")
        {
            game_tickets_v2 = new Game_Ticket_v2() { Engine_Name = Engine_Name, Engine_Name_ = Table_Name, Default_value = 0 };
            return;
        }
        else
        {
            if (Table_Name == "CarrierAssaultSmall0" || Table_Name == "CarrierAssaultLarge0")
                table_name += "CarrierAssaultLarge/Small0";
            else
                table_name += Table_Name;
        }
        table_name += "]";
        String col_name = String.Empty;
        if (!String.IsNullOrEmpty(Engine_Name)) { col_name = "[Engine Name] = '"; col_name += Engine_Name; col_name += "'"; } else { col_name = "1"; }
        string sql = "SELECT [Engine Name], [Human-Readable Name], [Tickets] FROM " + table_name + " WHERE " + col_name + "";
        SQLiteCommand command = new SQLiteCommand(sql, db_Connection);
        SQLiteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            game_tickets_v2 = (new Game_Ticket_v2() { Engine_Name = reader["Engine name"].ToString(), Engine_Name_ = Table_Name, Human_readable_name = reader["Human-readable name"].ToString(), Default_value = (reader["Tickets"] != DBNull.Value) ? Convert.ToInt32(reader["Tickets"]) : 0 });
        }
    }

    public static void Get_GameTickets_v2(SQLiteConnection db_Connection, String Table_Name, String Engine_Name, ref Label label)
    {
        Get_GameTickets_v2(db_Connection, Table_Name, Engine_Name);
        if (game_tickets_v2 == null)
            return;

        if (game_tickets_v2.Default_value == 0)
        {
            label.Text = String.Format("Tickets: {0}", "N/A");
        }
        else
        {
            label.Text = String.Format("Tickets: {0}", game_tickets_v2.Default_value);
        }
    }
    #endregion

    public static Game_RoundTime game_roundtime { get; set; }

    #region Game Round Time
    public static void Get_GameRoundTime(SQLiteConnection db_Connection, String Engine_Name)
    {
        String col_name = String.Empty;
        if (!String.IsNullOrEmpty(Engine_Name)) { col_name = "[Engine Name] = '"; col_name += Engine_Name; col_name += "'"; } else { col_name = "1"; }
        string sql = "SELECT [Engine Name], [Human-Readable Name], [Default value (seconds)] FROM [main].[BF4 PC Game Round Time] WHERE " + col_name + "";
        SQLiteCommand command = new SQLiteCommand(sql, db_Connection);
        SQLiteDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            game_roundtime = (new Game_RoundTime() { Engine_Name = reader["Engine name"].ToString(), Human_readable_name = reader["Human-readable name"].ToString(), Default_value = (reader["Default value (seconds)"] != DBNull.Value) ? Convert.ToInt32(reader["Default value (seconds)"]) : 0 });
        }
    }

    public static void Get_GameRoundTime(SQLiteConnection db_Connection, String Engine_Name, ref Label label)
    {
        Get_GameRoundTime(db_Connection, Engine_Name);
        if (game_roundtime == null)
            return;

        if (game_roundtime.Default_value == 0)
        {
            label.Text = String.Format("Round time: {0} seconds", "N/A");
        }
        else
        {
            label.Text = String.Format("Round time: {0} seconds ({1} minutes)", game_roundtime.Default_value, (game_roundtime.Default_value / 60));
        }
    }
    #endregion
}

public class Game_Faction
{
    public enum Factions
    {
        US,
        RU,
        CN
    };

    public String Engine_Name { get; set; }
    public String Human_readable_name { get; set; }
    public Factions Team_1 { get; set; }
    public Factions Team_2 { get; set; }
}

public class Game_Mode
{
    public String Engine_Name { get; set; }
    public String Human_readable_name { get; set; }
    public Int32 Intended_max_player_count { get; set; }
}

public class Game_Ticket
{
    public String Engine_Name { get; set; }
    public String Human_readable_name { get; set; }
    public Int32 Default_value { get; set; }
}

public class Game_Ticket_v2
{
    public String Engine_Name { get; set; }
    public String Engine_Name_ { get; set; }
    public String Human_readable_name { get; set; }
    public String Human_readable_name_ { get; set; }
    public Int32 Default_value { get; set; }
}

public class Game_RoundTime
{
    public String Engine_Name { get; set; }
    public String Human_readable_name { get; set; }
    public Int32 Default_value { get; set; }
}

