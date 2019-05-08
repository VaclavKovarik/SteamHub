namespace SteamHub
{
    partial class SteamHubMenu
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
            this.OvladaciPanel = new MetroFramework.Controls.MetroTabControl();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Favourite = new MetroFramework.Controls.MetroTabPage();
            this.Users = new MetroFramework.Controls.MetroTabPage();
            this.Friendlist = new MetroFramework.Controls.MetroTabPage();
            this.OwnedGames = new MetroFramework.Controls.MetroTabPage();
            this.Achievements = new MetroFramework.Controls.MetroTabPage();
            this.Statistics = new MetroFramework.Controls.MetroTabPage();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.OvladaciPanel.SuspendLayout();
            this.Favourite.SuspendLayout();
            this.Users.SuspendLayout();
            this.SuspendLayout();
            // 
            // OvladaciPanel
            // 
            this.OvladaciPanel.Controls.Add(this.Users);
            this.OvladaciPanel.Controls.Add(this.Favourite);
            this.OvladaciPanel.Controls.Add(this.Friendlist);
            this.OvladaciPanel.Controls.Add(this.OwnedGames);
            this.OvladaciPanel.Controls.Add(this.Achievements);
            this.OvladaciPanel.Controls.Add(this.Statistics);
            this.OvladaciPanel.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.OvladaciPanel.HotTrack = true;
            this.OvladaciPanel.ItemSize = new System.Drawing.Size(60, 37);
            this.OvladaciPanel.Location = new System.Drawing.Point(5, 63);
            this.OvladaciPanel.Name = "OvladaciPanel";
            this.OvladaciPanel.SelectedIndex = 0;
            this.OvladaciPanel.Size = new System.Drawing.Size(760, 384);
            this.OvladaciPanel.Style = MetroFramework.MetroColorStyle.Silver;
            this.OvladaciPanel.TabIndex = 0;
            this.OvladaciPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OvladaciPanel.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(275, 43);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(149, 66);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Tlačidlo na straně 2";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            // 
            // Favourite
            // 
            this.Favourite.AutoScroll = true;
            this.Favourite.Controls.Add(this.metroButton2);
            this.Favourite.HorizontalScrollbar = true;
            this.Favourite.HorizontalScrollbarBarColor = true;
            this.Favourite.HorizontalScrollbarHighlightOnWheel = false;
            this.Favourite.HorizontalScrollbarSize = 10;
            this.Favourite.Location = new System.Drawing.Point(4, 41);
            this.Favourite.Name = "Favourite";
            this.Favourite.Size = new System.Drawing.Size(752, 339);
            this.Favourite.TabIndex = 1;
            this.Favourite.Text = "Favourite";
            this.Favourite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Favourite.VerticalScrollbar = true;
            this.Favourite.VerticalScrollbarBarColor = true;
            this.Favourite.VerticalScrollbarHighlightOnWheel = false;
            this.Favourite.VerticalScrollbarSize = 10;
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.SystemColors.MenuText;
            this.Users.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Users.Controls.Add(this.metroCheckBox1);
            this.Users.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Users.HorizontalScrollbarBarColor = true;
            this.Users.HorizontalScrollbarHighlightOnWheel = false;
            this.Users.HorizontalScrollbarSize = 10;
            this.Users.Location = new System.Drawing.Point(4, 41);
            this.Users.Name = "Users";
            this.Users.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Users.Size = new System.Drawing.Size(752, 339);
            this.Users.Style = MetroFramework.MetroColorStyle.Black;
            this.Users.TabIndex = 0;
            this.Users.Text = "Users";
            this.Users.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Users.VerticalScrollbarBarColor = true;
            this.Users.VerticalScrollbarHighlightOnWheel = true;
            this.Users.VerticalScrollbarSize = 10;
            this.Users.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // Friendlist
            // 
            this.Friendlist.HorizontalScrollbarBarColor = true;
            this.Friendlist.HorizontalScrollbarHighlightOnWheel = false;
            this.Friendlist.HorizontalScrollbarSize = 10;
            this.Friendlist.Location = new System.Drawing.Point(4, 41);
            this.Friendlist.Name = "Friendlist";
            this.Friendlist.Size = new System.Drawing.Size(752, 339);
            this.Friendlist.TabIndex = 2;
            this.Friendlist.Text = "Friendlist";
            this.Friendlist.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Friendlist.VerticalScrollbarBarColor = true;
            this.Friendlist.VerticalScrollbarHighlightOnWheel = false;
            this.Friendlist.VerticalScrollbarSize = 10;
            // 
            // OwnedGames
            // 
            this.OwnedGames.HorizontalScrollbarBarColor = true;
            this.OwnedGames.HorizontalScrollbarHighlightOnWheel = false;
            this.OwnedGames.HorizontalScrollbarSize = 10;
            this.OwnedGames.Location = new System.Drawing.Point(4, 41);
            this.OwnedGames.Name = "OwnedGames";
            this.OwnedGames.Size = new System.Drawing.Size(752, 339);
            this.OwnedGames.TabIndex = 3;
            this.OwnedGames.Text = "Owned games";
            this.OwnedGames.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OwnedGames.VerticalScrollbarBarColor = true;
            this.OwnedGames.VerticalScrollbarHighlightOnWheel = false;
            this.OwnedGames.VerticalScrollbarSize = 10;
            // 
            // Achievements
            // 
            this.Achievements.HorizontalScrollbarBarColor = true;
            this.Achievements.HorizontalScrollbarHighlightOnWheel = false;
            this.Achievements.HorizontalScrollbarSize = 10;
            this.Achievements.Location = new System.Drawing.Point(4, 41);
            this.Achievements.Name = "Achievements";
            this.Achievements.Size = new System.Drawing.Size(752, 339);
            this.Achievements.TabIndex = 4;
            this.Achievements.Text = "Achievements";
            this.Achievements.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Achievements.VerticalScrollbarBarColor = true;
            this.Achievements.VerticalScrollbarHighlightOnWheel = false;
            this.Achievements.VerticalScrollbarSize = 10;
            // 
            // Statistics
            // 
            this.Statistics.HorizontalScrollbarBarColor = true;
            this.Statistics.HorizontalScrollbarHighlightOnWheel = false;
            this.Statistics.HorizontalScrollbarSize = 10;
            this.Statistics.Location = new System.Drawing.Point(4, 41);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(752, 339);
            this.Statistics.TabIndex = 5;
            this.Statistics.Text = "Statistics";
            this.Statistics.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Statistics.VerticalScrollbarBarColor = true;
            this.Statistics.VerticalScrollbarHighlightOnWheel = false;
            this.Statistics.VerticalScrollbarSize = 10;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(38, 25);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(113, 15);
            this.metroCheckBox1.TabIndex = 7;
            this.metroCheckBox1.Text = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // SteamHubMenu
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OvladaciPanel);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "SteamHubMenu";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SteamHub";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OvladaciPanel.ResumeLayout(false);
            this.Favourite.ResumeLayout(false);
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl OvladaciPanel;
        public MetroFramework.Controls.MetroTabPage Users;
        private MetroFramework.Controls.MetroTabPage Favourite;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTabPage Friendlist;
        private MetroFramework.Controls.MetroTabPage OwnedGames;
        private MetroFramework.Controls.MetroTabPage Achievements;
        private MetroFramework.Controls.MetroTabPage Statistics;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
    }
}

