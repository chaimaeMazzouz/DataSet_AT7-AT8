namespace learn_dataSet
{
    partial class Home
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
            this.chauffeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheVoyageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheVéhucilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véhiculesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheVoyagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheVéhiculesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chauffeurToolStripMenuItem,
            this.véhiculesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chauffeurToolStripMenuItem
            // 
            this.chauffeurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.rechercheVoyageToolStripMenuItem,
            this.rechercheVéhucilesToolStripMenuItem});
            this.chauffeurToolStripMenuItem.Name = "chauffeurToolStripMenuItem";
            this.chauffeurToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chauffeurToolStripMenuItem.Text = "Chauffeurs";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.navigationToolStripMenuItem.Text = "Navigation";
            this.navigationToolStripMenuItem.Click += new System.EventHandler(this.navigationToolStripMenuItem_Click);
            // 
            // rechercheVoyageToolStripMenuItem
            // 
            this.rechercheVoyageToolStripMenuItem.Name = "rechercheVoyageToolStripMenuItem";
            this.rechercheVoyageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rechercheVoyageToolStripMenuItem.Text = "Recherche Voyages";
            // 
            // rechercheVéhucilesToolStripMenuItem
            // 
            this.rechercheVéhucilesToolStripMenuItem.Name = "rechercheVéhucilesToolStripMenuItem";
            this.rechercheVéhucilesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rechercheVéhucilesToolStripMenuItem.Text = "Recherche Véhicules";
            // 
            // véhiculesToolStripMenuItem
            // 
            this.véhiculesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem1,
            this.rechercheVoyagesToolStripMenuItem,
            this.rechercheVéhiculesToolStripMenuItem});
            this.véhiculesToolStripMenuItem.Name = "véhiculesToolStripMenuItem";
            this.véhiculesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.véhiculesToolStripMenuItem.Text = "Véhicules";
            // 
            // navigationToolStripMenuItem1
            // 
            this.navigationToolStripMenuItem1.Name = "navigationToolStripMenuItem1";
            this.navigationToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.navigationToolStripMenuItem1.Text = "Navigation";
            this.navigationToolStripMenuItem1.Click += new System.EventHandler(this.navigationToolStripMenuItem1_Click);
            // 
            // rechercheVoyagesToolStripMenuItem
            // 
            this.rechercheVoyagesToolStripMenuItem.Name = "rechercheVoyagesToolStripMenuItem";
            this.rechercheVoyagesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rechercheVoyagesToolStripMenuItem.Text = "Recherche Voyages";
            // 
            // rechercheVéhiculesToolStripMenuItem
            // 
            this.rechercheVéhiculesToolStripMenuItem.Name = "rechercheVéhiculesToolStripMenuItem";
            this.rechercheVéhiculesToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.rechercheVéhiculesToolStripMenuItem.Text = "Recherche Véhicules";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Home";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chauffeurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheVoyageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheVéhucilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem véhiculesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rechercheVoyagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercheVéhiculesToolStripMenuItem;
    }
}

