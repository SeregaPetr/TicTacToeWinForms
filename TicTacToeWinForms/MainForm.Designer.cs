namespace TicTacToeWinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.StLbLevel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StLbComputer = new System.Windows.Forms.ToolStripStatusLabel();
            this.StLbPlayer = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.смениьУровеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLevel1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLevel2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLevel3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.moveBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.button5, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button8, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 379);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button5.Location = new System.Drawing.Point(334, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(161, 120);
            this.button5.TabIndex = 5;
            this.button5.Tag = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button4.Location = new System.Drawing.Point(168, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 120);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.Location = new System.Drawing.Point(3, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 120);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(334, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 120);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(168, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 120);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button0.Location = new System.Drawing.Point(3, 3);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(159, 120);
            this.button0.TabIndex = 0;
            this.button0.Tag = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button6.Location = new System.Drawing.Point(3, 255);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 121);
            this.button6.TabIndex = 6;
            this.button6.Tag = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button7.Location = new System.Drawing.Point(168, 255);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(160, 121);
            this.button7.TabIndex = 8;
            this.button7.Tag = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button8.Location = new System.Drawing.Point(334, 255);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(161, 121);
            this.button8.TabIndex = 7;
            this.button8.Tag = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StLbLevel,
            this.StLbComputer,
            this.StLbPlayer});
            this.statusStrip.Location = new System.Drawing.Point(0, 407);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(498, 24);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // StLbLevel
            // 
            this.StLbLevel.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.StLbLevel.Name = "StLbLevel";
            this.StLbLevel.Size = new System.Drawing.Size(53, 19);
            this.StLbLevel.Text = "Уровень";
            // 
            // StLbComputer
            // 
            this.StLbComputer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.StLbComputer.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.StLbComputer.Margin = new System.Windows.Forms.Padding(70, 3, 0, 2);
            this.StLbComputer.Name = "StLbComputer";
            this.StLbComputer.Size = new System.Drawing.Size(75, 19);
            this.StLbComputer.Text = "Компьютер";
            // 
            // StLbPlayer
            // 
            this.StLbPlayer.Name = "StLbPlayer";
            this.StLbPlayer.Size = new System.Drawing.Size(12, 19);
            this.StLbPlayer.Text = "_";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.moveBackToolStripMenuItem,
            this.menuItemInformation,
            this.MenuItemAboutProgram});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(498, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNewGame,
            this.смениьУровеньToolStripMenuItem,
            this.MenuItemChangeUser});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // MenuItemNewGame
            // 
            this.MenuItemNewGame.Name = "MenuItemNewGame";
            this.MenuItemNewGame.Size = new System.Drawing.Size(200, 22);
            this.MenuItemNewGame.Text = "Новая игра";
            this.MenuItemNewGame.Click += new System.EventHandler(this.MenuItemNewGame_Click);
            // 
            // смениьУровеньToolStripMenuItem
            // 
            this.смениьУровеньToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLevel1,
            this.MenuItemLevel2,
            this.MenuItemLevel3});
            this.смениьУровеньToolStripMenuItem.Name = "смениьУровеньToolStripMenuItem";
            this.смениьУровеньToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.смениьУровеньToolStripMenuItem.Text = "Смениь уровень";
            // 
            // MenuItemLevel1
            // 
            this.MenuItemLevel1.Name = "MenuItemLevel1";
            this.MenuItemLevel1.Size = new System.Drawing.Size(128, 22);
            this.MenuItemLevel1.Tag = "1";
            this.MenuItemLevel1.Text = "1 уровень";
            this.MenuItemLevel1.Click += new System.EventHandler(this.MenuItemLevel_Click);
            // 
            // MenuItemLevel2
            // 
            this.MenuItemLevel2.Name = "MenuItemLevel2";
            this.MenuItemLevel2.Size = new System.Drawing.Size(128, 22);
            this.MenuItemLevel2.Tag = "2";
            this.MenuItemLevel2.Text = "2 уровень";
            this.MenuItemLevel2.Click += new System.EventHandler(this.MenuItemLevel_Click);
            // 
            // MenuItemLevel3
            // 
            this.MenuItemLevel3.Name = "MenuItemLevel3";
            this.MenuItemLevel3.Size = new System.Drawing.Size(128, 22);
            this.MenuItemLevel3.Tag = "3";
            this.MenuItemLevel3.Text = "3 уровень";
            this.MenuItemLevel3.Click += new System.EventHandler(this.MenuItemLevel_Click);
            // 
            // MenuItemChangeUser
            // 
            this.MenuItemChangeUser.Name = "MenuItemChangeUser";
            this.MenuItemChangeUser.Size = new System.Drawing.Size(200, 22);
            this.MenuItemChangeUser.Text = "Сменить пользователя";
            this.MenuItemChangeUser.Click += new System.EventHandler(this.MenuItemChangeUser_Click);
            // 
            // moveBackToolStripMenuItem
            // 
            this.moveBackToolStripMenuItem.Name = "moveBackToolStripMenuItem";
            this.moveBackToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.moveBackToolStripMenuItem.Text = "Ход назад";
            this.moveBackToolStripMenuItem.Click += new System.EventHandler(this.moveBackToolStripMenuItem_Click);
            // 
            // menuItemInformation
            // 
            this.menuItemInformation.Name = "menuItemInformation";
            this.menuItemInformation.Size = new System.Drawing.Size(93, 20);
            this.menuItemInformation.Text = "Информация";
            this.menuItemInformation.Click += new System.EventHandler(this.menuItemInformation_Click);
            // 
            // MenuItemAboutProgram
            // 
            this.MenuItemAboutProgram.Name = "MenuItemAboutProgram";
            this.MenuItemAboutProgram.Size = new System.Drawing.Size(97, 20);
            this.MenuItemAboutProgram.Text = " О программе";
            this.MenuItemAboutProgram.Click += new System.EventHandler(this.MenuItemAboutProgram_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 431);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крестики нолики";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StLbComputer;
        private System.Windows.Forms.ToolStripStatusLabel StLbPlayer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNewGame;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAboutProgram;
        private System.Windows.Forms.ToolStripMenuItem menuItemInformation;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem MenuItemChangeUser;
        private System.Windows.Forms.ToolStripMenuItem смениьУровеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLevel1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLevel2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLevel3;
        private System.Windows.Forms.ToolStripStatusLabel StLbLevel;
        private System.Windows.Forms.ToolStripMenuItem moveBackToolStripMenuItem;
    }
}


