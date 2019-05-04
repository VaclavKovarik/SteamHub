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
            this.Users = new MetroFramework.Controls.MetroTabPage();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.Favourite = new MetroFramework.Controls.MetroTabPage();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.OvladaciPanel.SuspendLayout();
            this.Users.SuspendLayout();
            this.Favourite.SuspendLayout();
            this.SuspendLayout();
            // 
            // OvladaciPanel
            // 
            this.OvladaciPanel.Controls.Add(this.Users);
            this.OvladaciPanel.Controls.Add(this.Favourite);
            this.OvladaciPanel.Location = new System.Drawing.Point(0, 63);
            this.OvladaciPanel.Name = "OvladaciPanel";
            this.OvladaciPanel.SelectedIndex = 0;
            this.OvladaciPanel.Size = new System.Drawing.Size(677, 287);
            this.OvladaciPanel.Style = MetroFramework.MetroColorStyle.Black;
            this.OvladaciPanel.TabIndex = 0;
            this.OvladaciPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OvladaciPanel.UseSelectable = true;
            // 
            // Users
            // 
            this.Users.BackColor = System.Drawing.SystemColors.WindowText;
            this.Users.Controls.Add(this.metroButton1);
            this.Users.HorizontalScrollbarBarColor = true;
            this.Users.HorizontalScrollbarHighlightOnWheel = false;
            this.Users.HorizontalScrollbarSize = 10;
            this.Users.Location = new System.Drawing.Point(4, 38);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(669, 245);
            this.Users.Style = MetroFramework.MetroColorStyle.Black;
            this.Users.TabIndex = 0;
            this.Users.Text = "Users";
            this.Users.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Users.VerticalScrollbarBarColor = true;
            this.Users.VerticalScrollbarHighlightOnWheel = false;
            this.Users.VerticalScrollbarSize = 10;
            this.Users.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(157, 55);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(149, 66);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Tlačidlo na straně 1";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // Favourite
            // 
            this.Favourite.Controls.Add(this.metroButton2);
            this.Favourite.HorizontalScrollbarBarColor = true;
            this.Favourite.HorizontalScrollbarHighlightOnWheel = false;
            this.Favourite.HorizontalScrollbarSize = 10;
            this.Favourite.Location = new System.Drawing.Point(4, 38);
            this.Favourite.Name = "Favourite";
            this.Favourite.Size = new System.Drawing.Size(669, 245);
            this.Favourite.TabIndex = 1;
            this.Favourite.Text = "Favourite";
            this.Favourite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Favourite.VerticalScrollbarBarColor = true;
            this.Favourite.VerticalScrollbarHighlightOnWheel = false;
            this.Favourite.VerticalScrollbarSize = 10;
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
            // SteamHubMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OvladaciPanel);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "SteamHubMenu";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "SteamHub";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.LavenderBlush;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.OvladaciPanel.ResumeLayout(false);
            this.Users.ResumeLayout(false);
            this.Favourite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl OvladaciPanel;
        private MetroFramework.Controls.MetroTabPage Users;
        private MetroFramework.Controls.MetroTabPage Favourite;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}

