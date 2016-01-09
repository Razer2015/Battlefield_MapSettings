using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Battlefield_MapSettings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Get the Database Version
            lbl_database_version.Text = String.Format("Database Version: {0}", Database_Version);
            // Connect to database
            SQLite_Connect();
            // Get all the maps
            Maps.Get_Maps(db_Connection, ref cBox_map_name, ref rTBox_log);
            // Create ticket tables (Need to do only once)
            //Create_Ticket_Tables(db_Connection);
        }

        String Database_Version = "R55 Build: 176744";
        SQLiteConnection db_Connection;

        private Boolean SQLite_Connect(string database_path = "map_defaults.db3")
        {
            if (!File.Exists(database_path))
                return (false);

            db_Connection = new SQLiteConnection("Data Source=" + database_path + ";Version=3;");
            db_Connection.Open();

            return (true);
        }

        private Boolean SQLite_Close(SQLiteConnection con)
        {
            try
            {
                con.Close();
                return (true);
            }
            catch
            {
                return (false);
            }
        }

        private void cBox_map_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get Game Modes List
            Map_Info selected_map = Maps.maps[cBox_map_name.SelectedIndex];
            Game.Get_GameModes(db_Connection, selected_map.Game_modes, ref cBox_game_mode, ref rTBox_log);

            // Logging
            rTBox_log.Text = rTBox_log.Text.Insert(0, String.Format("Selected map: {0} - {1}", selected_map.Engine_Name, selected_map.Human_readable_name) + "\n");

            gBox_map_settings_wanted.Enabled = false;
        }

        private void cBox_game_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Selected Variables
            Map_Info selected_map = Maps.maps[cBox_map_name.SelectedIndex];
            Game_Mode selected_game_mode = Game.game_modes[cBox_game_mode.SelectedIndex];

            // Logging
            rTBox_log.Text = rTBox_log.Text.Insert(0, String.Format("Selected game mode: {0} - {1}", selected_game_mode.Engine_Name, selected_game_mode.Human_readable_name) + "\n");

            // Get Game Factions
            Game.Get_GameFaction(db_Connection, selected_map.Engine_Name, selected_game_mode, ref lbl_faction);

            // Get Game Tickets
            //Game.Get_GameTickets(db_Connection, selected_game_mode.Engine_Name, ref lbl_tickets);

            // Get Game Tickets V2
            Game.Get_GameTickets_v2(db_Connection, selected_game_mode.Engine_Name, selected_map.Engine_Name, ref lbl_tickets);

            // Get Game Round Time
            Game.Get_GameRoundTime(db_Connection, selected_game_mode.Engine_Name, ref lbl_roundtime);

            // Get Game Player Respawn Time
            // TODO:

            // Update the Custom values
            gBox_map_settings_wanted.Enabled = true;
            nUD_map_percentage_ValueChanged(this, EventArgs.Empty);
            nUD_map_tick_count_ValueChanged(this, EventArgs.Empty);
        }

        private void nUD_map_percentage_ValueChanged(object sender, EventArgs e)
        {
            if (Game.game_tickets_v2 != null)
            {
                if (Game.game_tickets_v2.Default_value == 0)
                {
                    gBox_new_tickets.Text = String.Format("Tickets ({0} %)", nUD_map_percentage.Value);
                    lbl_new_tickets.Text = String.Format("Tickets: {0}", "N/A");
                }
                else
                {
                    gBox_new_tickets.Text = String.Format("Tickets ({0} %)", nUD_map_percentage.Value);
                    lbl_new_tickets.Text = String.Format("Tickets: {0}", (int)(Game.game_tickets_v2.Default_value * (nUD_map_percentage.Value / 100)));
                }
            }
            else if (Game.game_tickets != null)
            {
                if (Game.game_tickets.Default_value == 0)
                {
                    gBox_new_tickets.Text = String.Format("Tickets ({0} %)", nUD_map_percentage.Value);
                    lbl_new_tickets.Text = String.Format("Tickets: {0}", "N/A");
                }
                else
                {
                    gBox_new_tickets.Text = String.Format("Tickets ({0} %)", nUD_map_percentage.Value);
                    lbl_new_tickets.Text = String.Format("Tickets: {0}", (int)(Game.game_tickets.Default_value * (nUD_map_percentage.Value / 100)));
                }
            }
            else
                return;
        }

        private void nUD_map_tick_count_ValueChanged(object sender, EventArgs e)
        {
            if (Game.game_tickets_v2 != null)
            {
                if (Game.game_tickets_v2.Default_value == 0)
                {
                    gBox_new_tickets2.Text = String.Format("Tickets ({0})", nUD_map_tick_count.Value);
                    lbl_new_tickets2.Text = String.Format("Ticket Percentage: {0} %", "N/A");
                }
                else
                {
                    gBox_new_tickets2.Text = String.Format("Tickets ({0})", nUD_map_tick_count.Value);
                    lbl_new_tickets2.Text = String.Format("Ticket Percentage: {0} %", (int)((nUD_map_tick_count.Value * 100) / (Game.game_tickets_v2.Default_value * (nUD_map_percentage.Value / 100))));
                }
            }
            else if (Game.game_tickets != null)
            {
                if (Game.game_tickets.Default_value == 0)
                {
                    gBox_new_tickets2.Text = String.Format("Tickets ({0})", nUD_map_tick_count.Value);
                    lbl_new_tickets2.Text = String.Format("Ticket Percentage: {0} %", "N/A");
                }
                else
                {
                    gBox_new_tickets2.Text = String.Format("Tickets ({0})", nUD_map_tick_count.Value);
                    lbl_new_tickets2.Text = String.Format("Ticket Percentage: {0} %", (int)((nUD_map_tick_count.Value * 100) / (Game.game_tickets.Default_value * (nUD_map_percentage.Value / 100))));
                }
            }
            else
                return;
        }

        #region Create Ticket Tables

        private void Create_Ticket_Tables(SQLiteConnection db_Connection)
        {
            Maps.Get_Maps(db_Connection);
            Game.Get_GameModes(db_Connection, String.Empty);
            Map_Info[] maps = Maps.maps;
            foreach (Game_Mode g_mode in Game.game_modes)
            {
                String Engine_Name = g_mode.Engine_Name;
                if(Engine_Name == "CarrierAssaultLarge0" || Engine_Name == "Elimination0" || Engine_Name == "Obliteration")
                {
                    // Skip
                }
                else
                {
                    if (Engine_Name == "CarrierAssaultSmall0")
                        Engine_Name = "CarrierAssaultLarge/Small0";

                    // Create SQLite table to store the maps inside the memory database
                    using (SQLiteCommand command = new SQLiteCommand(db_Connection))
                    {
                        command.CommandText =
                          "CREATE TABLE IF NOT EXISTS [BF4 PC " + Engine_Name + "]([Engine Name] TEXT PRIMARY KEY, [Human-Readable Name] TEXT, [Tickets] INTEGER);";
                        command.Connection = db_Connection;
                        command.ExecuteNonQuery();
                    }

                    // Get the ticket count
                    Game.Get_GameTickets(db_Connection, g_mode.Engine_Name);

                    // Insert Maps
                    using (SQLiteCommand command = new SQLiteCommand(db_Connection))
                    {
                        using (SQLiteTransaction transaction = db_Connection.BeginTransaction())
                        {
                            for (int i = 0; i < maps.Length; i++)
                            {
                                // Execute query which inserts the maps
                                command.CommandText =
                                  "INSERT INTO [BF4 PC " + Engine_Name + "]([Engine Name], [Human-Readable Name], [Tickets]) VALUES(@engine_name, @human_readable_name, @tickets);";
                                command.Parameters.Add("@engine_name", DbType.String).Value = maps[i].Engine_Name;
                                command.Parameters.Add("@human_readable_name", DbType.String).Value = maps[i].Human_readable_name;
                                command.Parameters.Add("@tickets", DbType.String).Value = Game.game_tickets.Default_value;
                                command.Connection = db_Connection;
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();
                        }
                    }
                }
            }
        }

        #endregion

        #region ToolStrips
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coded by xfileFIN");
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
        #endregion
    }
}
