namespace Battlefield_MapSettings
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gBox_map_settings_wanted = new System.Windows.Forms.GroupBox();
            this.gBox_new_tickets2 = new System.Windows.Forms.GroupBox();
            this.lbl_new_tickets2 = new System.Windows.Forms.Label();
            this.nUD_map_tick_count = new System.Windows.Forms.NumericUpDown();
            this.gBox_new_tickets = new System.Windows.Forms.GroupBox();
            this.lbl_new_tickets = new System.Windows.Forms.Label();
            this.nUD_map_percentage = new System.Windows.Forms.NumericUpDown();
            this.gBox_map_settings = new System.Windows.Forms.GroupBox();
            this.gBox_def_presptime = new System.Windows.Forms.GroupBox();
            this.lbl_palyer_respawn = new System.Windows.Forms.Label();
            this.gBox_def_faction = new System.Windows.Forms.GroupBox();
            this.lbl_faction = new System.Windows.Forms.Label();
            this.gBox_def_roundtime = new System.Windows.Forms.GroupBox();
            this.lbl_roundtime = new System.Windows.Forms.Label();
            this.gBox_def_tickets = new System.Windows.Forms.GroupBox();
            this.lbl_tickets = new System.Windows.Forms.Label();
            this.gBox_logging = new System.Windows.Forms.GroupBox();
            this.rTBox_log = new System.Windows.Forms.RichTextBox();
            this.gBox_map_select = new System.Windows.Forms.GroupBox();
            this.cBox_game_mode = new System.Windows.Forms.ComboBox();
            this.cBox_map_name = new System.Windows.Forms.ComboBox();
            this.lbl_database_version = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBox_map_settings_wanted.SuspendLayout();
            this.gBox_new_tickets2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_map_tick_count)).BeginInit();
            this.gBox_new_tickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_map_percentage)).BeginInit();
            this.gBox_map_settings.SuspendLayout();
            this.gBox_def_presptime.SuspendLayout();
            this.gBox_def_faction.SuspendLayout();
            this.gBox_def_roundtime.SuspendLayout();
            this.gBox_def_tickets.SuspendLayout();
            this.gBox_logging.SuspendLayout();
            this.gBox_map_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 463);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gBox_map_settings_wanted);
            this.tabPage1.Controls.Add(this.gBox_map_settings);
            this.tabPage1.Controls.Add(this.gBox_logging);
            this.tabPage1.Controls.Add(this.gBox_map_select);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gBox_map_settings_wanted
            // 
            this.gBox_map_settings_wanted.Controls.Add(this.gBox_new_tickets2);
            this.gBox_map_settings_wanted.Controls.Add(this.gBox_new_tickets);
            this.gBox_map_settings_wanted.Enabled = false;
            this.gBox_map_settings_wanted.Location = new System.Drawing.Point(6, 275);
            this.gBox_map_settings_wanted.Name = "gBox_map_settings_wanted";
            this.gBox_map_settings_wanted.Size = new System.Drawing.Size(329, 159);
            this.gBox_map_settings_wanted.TabIndex = 3;
            this.gBox_map_settings_wanted.TabStop = false;
            this.gBox_map_settings_wanted.Text = "Map Settings (Wanted)";
            // 
            // gBox_new_tickets2
            // 
            this.gBox_new_tickets2.Controls.Add(this.lbl_new_tickets2);
            this.gBox_new_tickets2.Controls.Add(this.nUD_map_tick_count);
            this.gBox_new_tickets2.Location = new System.Drawing.Point(6, 89);
            this.gBox_new_tickets2.Name = "gBox_new_tickets2";
            this.gBox_new_tickets2.Size = new System.Drawing.Size(317, 64);
            this.gBox_new_tickets2.TabIndex = 6;
            this.gBox_new_tickets2.TabStop = false;
            this.gBox_new_tickets2.Text = "Tickets (100)";
            // 
            // lbl_new_tickets2
            // 
            this.lbl_new_tickets2.AutoSize = true;
            this.lbl_new_tickets2.Location = new System.Drawing.Point(6, 42);
            this.lbl_new_tickets2.Name = "lbl_new_tickets2";
            this.lbl_new_tickets2.Size = new System.Drawing.Size(45, 13);
            this.lbl_new_tickets2.TabIndex = 1;
            this.lbl_new_tickets2.Text = "Tickets:";
            // 
            // nUD_map_tick_count
            // 
            this.nUD_map_tick_count.Location = new System.Drawing.Point(6, 19);
            this.nUD_map_tick_count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_map_tick_count.Name = "nUD_map_tick_count";
            this.nUD_map_tick_count.Size = new System.Drawing.Size(305, 20);
            this.nUD_map_tick_count.TabIndex = 0;
            this.nUD_map_tick_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_map_tick_count.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUD_map_tick_count.ValueChanged += new System.EventHandler(this.nUD_map_tick_count_ValueChanged);
            // 
            // gBox_new_tickets
            // 
            this.gBox_new_tickets.Controls.Add(this.lbl_new_tickets);
            this.gBox_new_tickets.Controls.Add(this.nUD_map_percentage);
            this.gBox_new_tickets.Location = new System.Drawing.Point(6, 19);
            this.gBox_new_tickets.Name = "gBox_new_tickets";
            this.gBox_new_tickets.Size = new System.Drawing.Size(317, 64);
            this.gBox_new_tickets.TabIndex = 5;
            this.gBox_new_tickets.TabStop = false;
            this.gBox_new_tickets.Text = "Tickets (100%)";
            // 
            // lbl_new_tickets
            // 
            this.lbl_new_tickets.AutoSize = true;
            this.lbl_new_tickets.Location = new System.Drawing.Point(6, 42);
            this.lbl_new_tickets.Name = "lbl_new_tickets";
            this.lbl_new_tickets.Size = new System.Drawing.Size(45, 13);
            this.lbl_new_tickets.TabIndex = 1;
            this.lbl_new_tickets.Text = "Tickets:";
            // 
            // nUD_map_percentage
            // 
            this.nUD_map_percentage.Location = new System.Drawing.Point(6, 19);
            this.nUD_map_percentage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUD_map_percentage.Name = "nUD_map_percentage";
            this.nUD_map_percentage.Size = new System.Drawing.Size(305, 20);
            this.nUD_map_percentage.TabIndex = 0;
            this.nUD_map_percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nUD_map_percentage.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nUD_map_percentage.ValueChanged += new System.EventHandler(this.nUD_map_percentage_ValueChanged);
            // 
            // gBox_map_settings
            // 
            this.gBox_map_settings.Controls.Add(this.gBox_def_presptime);
            this.gBox_map_settings.Controls.Add(this.gBox_def_faction);
            this.gBox_map_settings.Controls.Add(this.gBox_def_roundtime);
            this.gBox_map_settings.Controls.Add(this.gBox_def_tickets);
            this.gBox_map_settings.Location = new System.Drawing.Point(6, 86);
            this.gBox_map_settings.Name = "gBox_map_settings";
            this.gBox_map_settings.Size = new System.Drawing.Size(329, 183);
            this.gBox_map_settings.TabIndex = 2;
            this.gBox_map_settings.TabStop = false;
            this.gBox_map_settings.Text = "Map Settings (Default)";
            // 
            // gBox_def_presptime
            // 
            this.gBox_def_presptime.Controls.Add(this.lbl_palyer_respawn);
            this.gBox_def_presptime.Enabled = false;
            this.gBox_def_presptime.Location = new System.Drawing.Point(6, 142);
            this.gBox_def_presptime.Name = "gBox_def_presptime";
            this.gBox_def_presptime.Size = new System.Drawing.Size(317, 35);
            this.gBox_def_presptime.TabIndex = 5;
            this.gBox_def_presptime.TabStop = false;
            this.gBox_def_presptime.Text = "Player Respawn Time";
            // 
            // lbl_palyer_respawn
            // 
            this.lbl_palyer_respawn.AutoSize = true;
            this.lbl_palyer_respawn.Location = new System.Drawing.Point(6, 16);
            this.lbl_palyer_respawn.Name = "lbl_palyer_respawn";
            this.lbl_palyer_respawn.Size = new System.Drawing.Size(110, 13);
            this.lbl_palyer_respawn.TabIndex = 3;
            this.lbl_palyer_respawn.Text = "Player Respawn Time";
            // 
            // gBox_def_faction
            // 
            this.gBox_def_faction.Controls.Add(this.lbl_faction);
            this.gBox_def_faction.Location = new System.Drawing.Point(6, 19);
            this.gBox_def_faction.Name = "gBox_def_faction";
            this.gBox_def_faction.Size = new System.Drawing.Size(317, 35);
            this.gBox_def_faction.TabIndex = 3;
            this.gBox_def_faction.TabStop = false;
            this.gBox_def_faction.Text = "Faction";
            // 
            // lbl_faction
            // 
            this.lbl_faction.AutoSize = true;
            this.lbl_faction.Location = new System.Drawing.Point(6, 16);
            this.lbl_faction.Name = "lbl_faction";
            this.lbl_faction.Size = new System.Drawing.Size(45, 13);
            this.lbl_faction.TabIndex = 0;
            this.lbl_faction.Text = "Faction:";
            // 
            // gBox_def_roundtime
            // 
            this.gBox_def_roundtime.Controls.Add(this.lbl_roundtime);
            this.gBox_def_roundtime.Location = new System.Drawing.Point(6, 101);
            this.gBox_def_roundtime.Name = "gBox_def_roundtime";
            this.gBox_def_roundtime.Size = new System.Drawing.Size(317, 35);
            this.gBox_def_roundtime.TabIndex = 4;
            this.gBox_def_roundtime.TabStop = false;
            this.gBox_def_roundtime.Text = "Round Time";
            // 
            // lbl_roundtime
            // 
            this.lbl_roundtime.AutoSize = true;
            this.lbl_roundtime.Location = new System.Drawing.Point(6, 16);
            this.lbl_roundtime.Name = "lbl_roundtime";
            this.lbl_roundtime.Size = new System.Drawing.Size(68, 13);
            this.lbl_roundtime.TabIndex = 2;
            this.lbl_roundtime.Text = "Round Time:";
            // 
            // gBox_def_tickets
            // 
            this.gBox_def_tickets.Controls.Add(this.lbl_tickets);
            this.gBox_def_tickets.Location = new System.Drawing.Point(6, 60);
            this.gBox_def_tickets.Name = "gBox_def_tickets";
            this.gBox_def_tickets.Size = new System.Drawing.Size(317, 35);
            this.gBox_def_tickets.TabIndex = 4;
            this.gBox_def_tickets.TabStop = false;
            this.gBox_def_tickets.Text = "Tickets (100%)";
            // 
            // lbl_tickets
            // 
            this.lbl_tickets.AutoSize = true;
            this.lbl_tickets.Location = new System.Drawing.Point(6, 16);
            this.lbl_tickets.Name = "lbl_tickets";
            this.lbl_tickets.Size = new System.Drawing.Size(45, 13);
            this.lbl_tickets.TabIndex = 1;
            this.lbl_tickets.Text = "Tickets:";
            // 
            // gBox_logging
            // 
            this.gBox_logging.Controls.Add(this.rTBox_log);
            this.gBox_logging.Dock = System.Windows.Forms.DockStyle.Right;
            this.gBox_logging.Location = new System.Drawing.Point(341, 3);
            this.gBox_logging.Name = "gBox_logging";
            this.gBox_logging.Size = new System.Drawing.Size(597, 431);
            this.gBox_logging.TabIndex = 1;
            this.gBox_logging.TabStop = false;
            this.gBox_logging.Text = "Logging";
            // 
            // rTBox_log
            // 
            this.rTBox_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBox_log.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBox_log.Location = new System.Drawing.Point(3, 16);
            this.rTBox_log.Name = "rTBox_log";
            this.rTBox_log.Size = new System.Drawing.Size(591, 412);
            this.rTBox_log.TabIndex = 0;
            this.rTBox_log.Text = "";
            // 
            // gBox_map_select
            // 
            this.gBox_map_select.Controls.Add(this.cBox_game_mode);
            this.gBox_map_select.Controls.Add(this.cBox_map_name);
            this.gBox_map_select.Location = new System.Drawing.Point(6, 6);
            this.gBox_map_select.Name = "gBox_map_select";
            this.gBox_map_select.Size = new System.Drawing.Size(329, 74);
            this.gBox_map_select.TabIndex = 0;
            this.gBox_map_select.TabStop = false;
            this.gBox_map_select.Text = "Map Selector";
            // 
            // cBox_game_mode
            // 
            this.cBox_game_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_game_mode.FormattingEnabled = true;
            this.cBox_game_mode.Location = new System.Drawing.Point(6, 46);
            this.cBox_game_mode.Name = "cBox_game_mode";
            this.cBox_game_mode.Size = new System.Drawing.Size(317, 21);
            this.cBox_game_mode.TabIndex = 1;
            this.cBox_game_mode.SelectedIndexChanged += new System.EventHandler(this.cBox_game_mode_SelectedIndexChanged);
            // 
            // cBox_map_name
            // 
            this.cBox_map_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_map_name.FormattingEnabled = true;
            this.cBox_map_name.Location = new System.Drawing.Point(6, 19);
            this.cBox_map_name.Name = "cBox_map_name";
            this.cBox_map_name.Size = new System.Drawing.Size(317, 21);
            this.cBox_map_name.TabIndex = 0;
            this.cBox_map_name.SelectedIndexChanged += new System.EventHandler(this.cBox_map_name_SelectedIndexChanged);
            // 
            // lbl_database_version
            // 
            this.lbl_database_version.AutoSize = true;
            this.lbl_database_version.Location = new System.Drawing.Point(457, 6);
            this.lbl_database_version.Name = "lbl_database_version";
            this.lbl_database_version.Size = new System.Drawing.Size(97, 13);
            this.lbl_database_version.TabIndex = 3;
            this.lbl_database_version.Text = "Database Version: ";
            this.lbl_database_version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 509);
            this.Controls.Add(this.lbl_database_version);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battlefield 4 Map Settings";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gBox_map_settings_wanted.ResumeLayout(false);
            this.gBox_new_tickets2.ResumeLayout(false);
            this.gBox_new_tickets2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_map_tick_count)).EndInit();
            this.gBox_new_tickets.ResumeLayout(false);
            this.gBox_new_tickets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_map_percentage)).EndInit();
            this.gBox_map_settings.ResumeLayout(false);
            this.gBox_def_presptime.ResumeLayout(false);
            this.gBox_def_presptime.PerformLayout();
            this.gBox_def_faction.ResumeLayout(false);
            this.gBox_def_faction.PerformLayout();
            this.gBox_def_roundtime.ResumeLayout(false);
            this.gBox_def_roundtime.PerformLayout();
            this.gBox_def_tickets.ResumeLayout(false);
            this.gBox_def_tickets.PerformLayout();
            this.gBox_logging.ResumeLayout(false);
            this.gBox_map_select.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gBox_map_select;
        private System.Windows.Forms.ComboBox cBox_game_mode;
        private System.Windows.Forms.ComboBox cBox_map_name;
        private System.Windows.Forms.GroupBox gBox_map_settings;
        private System.Windows.Forms.GroupBox gBox_logging;
        private System.Windows.Forms.RichTextBox rTBox_log;
        private System.Windows.Forms.GroupBox gBox_def_presptime;
        private System.Windows.Forms.Label lbl_palyer_respawn;
        private System.Windows.Forms.GroupBox gBox_def_faction;
        private System.Windows.Forms.Label lbl_faction;
        private System.Windows.Forms.GroupBox gBox_def_roundtime;
        private System.Windows.Forms.Label lbl_roundtime;
        private System.Windows.Forms.GroupBox gBox_def_tickets;
        private System.Windows.Forms.Label lbl_tickets;
        private System.Windows.Forms.GroupBox gBox_map_settings_wanted;
        private System.Windows.Forms.NumericUpDown nUD_map_percentage;
        private System.Windows.Forms.GroupBox gBox_new_tickets;
        private System.Windows.Forms.Label lbl_new_tickets;
        private System.Windows.Forms.GroupBox gBox_new_tickets2;
        private System.Windows.Forms.Label lbl_new_tickets2;
        private System.Windows.Forms.NumericUpDown nUD_map_tick_count;
        private System.Windows.Forms.Label lbl_database_version;
    }
}

