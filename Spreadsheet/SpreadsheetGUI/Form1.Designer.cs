﻿namespace SS
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
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnName = new System.Windows.Forms.Label();
            this.columnValue = new System.Windows.Forms.TextBox();
            this.rowName = new System.Windows.Forms.Label();
            this.rowValue = new System.Windows.Forms.TextBox();
            this.cellName = new System.Windows.Forms.Label();
            this.cellNameValue = new System.Windows.Forms.TextBox();
            this.cellValueName = new System.Windows.Forms.Label();
            this.cellValueBox = new System.Windows.Forms.TextBox();
            this.cellContentsName = new System.Windows.Forms.Label();
            this.cellContentsValue = new System.Windows.Forms.TextBox();
            this.contentsInsert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.spreadsheetPanel1 = new SS.SpreadsheetPanel();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1917, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(187, 36);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // columnName
            // 
            this.columnName.AutoSize = true;
            this.columnName.Location = new System.Drawing.Point(13, 53);
            this.columnName.Name = "columnName";
            this.columnName.Size = new System.Drawing.Size(91, 25);
            this.columnName.TabIndex = 2;
            this.columnName.Text = "Column:";
            // 
            // columnValue
            // 
            this.columnValue.Location = new System.Drawing.Point(111, 47);
            this.columnValue.Name = "columnValue";
            this.columnValue.ReadOnly = true;
            this.columnValue.Size = new System.Drawing.Size(100, 31);
            this.columnValue.TabIndex = 3;
            // 
            // rowName
            // 
            this.rowName.AutoSize = true;
            this.rowName.Location = new System.Drawing.Point(268, 53);
            this.rowName.Name = "rowName";
            this.rowName.Size = new System.Drawing.Size(60, 25);
            this.rowName.TabIndex = 4;
            this.rowName.Text = "Row:";
            // 
            // rowValue
            // 
            this.rowValue.Location = new System.Drawing.Point(335, 47);
            this.rowValue.Name = "rowValue";
            this.rowValue.ReadOnly = true;
            this.rowValue.Size = new System.Drawing.Size(100, 31);
            this.rowValue.TabIndex = 5;
            // 
            // cellName
            // 
            this.cellName.AutoSize = true;
            this.cellName.Location = new System.Drawing.Point(13, 90);
            this.cellName.Name = "cellName";
            this.cellName.Size = new System.Drawing.Size(117, 25);
            this.cellName.TabIndex = 6;
            this.cellName.Text = "Cell Name:";
            // 
            // cellNameValue
            // 
            this.cellNameValue.Location = new System.Drawing.Point(142, 85);
            this.cellNameValue.Name = "cellNameValue";
            this.cellNameValue.ReadOnly = true;
            this.cellNameValue.Size = new System.Drawing.Size(100, 31);
            this.cellNameValue.TabIndex = 7;
            // 
            // cellValueName
            // 
            this.cellValueName.AutoSize = true;
            this.cellValueName.Location = new System.Drawing.Point(268, 92);
            this.cellValueName.Name = "cellValueName";
            this.cellValueName.Size = new System.Drawing.Size(113, 25);
            this.cellValueName.TabIndex = 8;
            this.cellValueName.Text = "Cell value:";
            // 
            // cellValueBox
            // 
            this.cellValueBox.Location = new System.Drawing.Point(388, 84);
            this.cellValueBox.Name = "cellValueBox";
            this.cellValueBox.ReadOnly = true;
            this.cellValueBox.Size = new System.Drawing.Size(399, 31);
            this.cellValueBox.TabIndex = 9;
            this.cellValueBox.WordWrap = false;
            // 
            // cellContentsName
            // 
            this.cellContentsName.AutoSize = true;
            this.cellContentsName.Location = new System.Drawing.Point(13, 128);
            this.cellContentsName.Name = "cellContentsName";
            this.cellContentsName.Size = new System.Drawing.Size(147, 25);
            this.cellContentsName.TabIndex = 10;
            this.cellContentsName.Text = "Cell Contents:";
            // 
            // cellContentsValue
            // 
            this.cellContentsValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cellContentsValue.Location = new System.Drawing.Point(167, 121);
            this.cellContentsValue.Name = "cellContentsValue";
            this.cellContentsValue.Size = new System.Drawing.Size(397, 31);
            this.cellContentsValue.TabIndex = 11;
            this.cellContentsValue.WordWrap = false;
            this.cellContentsValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cellContentsValue_KeyDown);
            // 
            // contentsInsert
            // 
            this.contentsInsert.Location = new System.Drawing.Point(611, 128);
            this.contentsInsert.Name = "contentsInsert";
            this.contentsInsert.Size = new System.Drawing.Size(94, 43);
            this.contentsInsert.TabIndex = 12;
            this.contentsInsert.Text = "Insert";
            this.contentsInsert.UseVisualStyleBackColor = true;
            this.contentsInsert.Click += new System.EventHandler(this.contentsInsert_Click);
            this.contentsInsert.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contentsInsert_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusName,
            this.statusValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 858);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1917, 38);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusName
            // 
            this.statusName.Name = "statusName";
            this.statusName.Size = new System.Drawing.Size(85, 32);
            this.statusName.Text = "Status:";
            // 
            // statusValue
            // 
            this.statusValue.Name = "statusValue";
            this.statusValue.Size = new System.Drawing.Size(125, 33);
            this.statusValue.Text = "Successful";
            this.statusValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spreadsheetPanel1
            // 
            this.spreadsheetPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spreadsheetPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.spreadsheetPanel1.Location = new System.Drawing.Point(0, 203);
            this.spreadsheetPanel1.Name = "spreadsheetPanel1";
            this.spreadsheetPanel1.Size = new System.Drawing.Size(2006, 639);
            this.spreadsheetPanel1.TabIndex = 0;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(244, 36);
            this.controlsToolStripMenuItem.Text = "Controls";
            this.controlsToolStripMenuItem.Click += new System.EventHandler(this.controlsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1917, 896);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.contentsInsert);
            this.Controls.Add(this.cellContentsValue);
            this.Controls.Add(this.cellContentsName);
            this.Controls.Add(this.cellValueBox);
            this.Controls.Add(this.cellValueName);
            this.Controls.Add(this.cellNameValue);
            this.Controls.Add(this.cellName);
            this.Controls.Add(this.rowValue);
            this.Controls.Add(this.rowName);
            this.Controls.Add(this.columnValue);
            this.Controls.Add(this.columnName);
            this.Controls.Add(this.spreadsheetPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spreadsheet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SS.SpreadsheetPanel spreadsheetPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label columnName;
        private System.Windows.Forms.TextBox columnValue;
        private System.Windows.Forms.Label rowName;
        private System.Windows.Forms.TextBox rowValue;
        private System.Windows.Forms.Label cellName;
        private System.Windows.Forms.TextBox cellNameValue;
        private System.Windows.Forms.Label cellValueName;
        private System.Windows.Forms.TextBox cellValueBox;
        private System.Windows.Forms.Label cellContentsName;
        private System.Windows.Forms.TextBox cellContentsValue;
        private System.Windows.Forms.Button contentsInsert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusName;
        private System.Windows.Forms.ToolStripStatusLabel statusValue;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;



    }
}

