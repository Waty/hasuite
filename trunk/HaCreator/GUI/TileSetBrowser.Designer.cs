namespace HaCreator
{
    partial class TileSetBrowser
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
            this.styleManager = new DevComponents.DotNetBar.StyleManager();
            this.koolkLVContainer = new HaCreator.KoolkLVContainer();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            // 
            // koolkLVContainer
            // 
            this.koolkLVContainer.AutoScroll = true;
            this.koolkLVContainer.BackColor = System.Drawing.Color.White;
            this.koolkLVContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.koolkLVContainer.Location = new System.Drawing.Point(0, 0);
            this.koolkLVContainer.Name = "koolkLVContainer";
            this.koolkLVContainer.Size = new System.Drawing.Size(600, 267);
            this.koolkLVContainer.TabIndex = 0;
            // 
            // TileSetBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 267);
            this.Controls.Add(this.koolkLVContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TileSetBrowser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TileSetBrowser";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private KoolkLVContainer koolkLVContainer;
    }
}