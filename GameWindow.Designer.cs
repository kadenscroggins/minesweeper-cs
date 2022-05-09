namespace minesweeper_cs
{
    partial class GameWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mineGrid = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // mineGrid
            // 
            this.mineGrid.AutoSize = true;
            this.mineGrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mineGrid.ColumnCount = 2;
            this.mineGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mineGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mineGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mineGrid.Location = new System.Drawing.Point(0, 0);
            this.mineGrid.Margin = new System.Windows.Forms.Padding(0);
            this.mineGrid.Name = "mineGrid";
            this.mineGrid.RowCount = 2;
            this.mineGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mineGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mineGrid.Size = new System.Drawing.Size(488, 467);
            this.mineGrid.TabIndex = 0;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 467);
            this.Controls.Add(this.mineGrid);
            this.Name = "GameWindow";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal TableLayoutPanel mineGrid;
    }
}