﻿namespace MemoryCards
{
    partial class FormMemory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMemory));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_game = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_game_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_game_s1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_game_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.munu_help_rules = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_s1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_game,
            this.menu_help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(434, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menu_game
            // 
            this.menu_game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_game_new,
            this.menu_game_s1,
            this.menu_game_exit});
            this.menu_game.Name = "menu_game";
            this.menu_game.Size = new System.Drawing.Size(46, 20);
            this.menu_game.Text = "Игра";
            // 
            // menu_game_new
            // 
            this.menu_game_new.Name = "menu_game_new";
            this.menu_game_new.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menu_game_new.Size = new System.Drawing.Size(155, 22);
            this.menu_game_new.Text = "Новая игра";
            this.menu_game_new.Click += new System.EventHandler(this.menu_game_new_Click);
            // 
            // menu_game_s1
            // 
            this.menu_game_s1.Name = "menu_game_s1";
            this.menu_game_s1.Size = new System.Drawing.Size(152, 6);
            // 
            // menu_game_exit
            // 
            this.menu_game_exit.Name = "menu_game_exit";
            this.menu_game_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.menu_game_exit.Size = new System.Drawing.Size(155, 22);
            this.menu_game_exit.Text = "Выход";
            this.menu_game_exit.Click += new System.EventHandler(this.menu_game_exit_Click);
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.munu_help_rules,
            this.menu_help_s1,
            this.menu_help_about});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(68, 20);
            this.menu_help.Text = "Помощь";
            // 
            // munu_help_rules
            // 
            this.munu_help_rules.Name = "munu_help_rules";
            this.munu_help_rules.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.munu_help_rules.Size = new System.Drawing.Size(195, 22);
            this.munu_help_rules.Text = "Правила игры";
            this.munu_help_rules.Click += new System.EventHandler(this.munu_help_rules_Click);
            // 
            // menu_help_s1
            // 
            this.menu_help_s1.Name = "menu_help_s1";
            this.menu_help_s1.Size = new System.Drawing.Size(192, 6);
            // 
            // menu_help_about
            // 
            this.menu_help_about.Name = "menu_help_about";
            this.menu_help_about.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.menu_help_about.Size = new System.Drawing.Size(195, 22);
            this.menu_help_about.Text = "О программе";
            this.menu_help_about.Click += new System.EventHandler(this.menu_help_about_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.pictureBox15, 3, 3);
            this.tableLayoutPanel.Controls.Add(this.pictureBox14, 2, 3);
            this.tableLayoutPanel.Controls.Add(this.pictureBox13, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.pictureBox12, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.pictureBox11, 3, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBox10, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBox9, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBox8, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.pictureBox7, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBox6, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBox5, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBox4, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.pictureBox3, 3, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.pictureBox0, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(434, 388);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox15.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox15.Location = new System.Drawing.Point(330, 294);
            this.pictureBox15.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(98, 88);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox15.TabIndex = 15;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "15";
            this.pictureBox15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox14.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox14.Location = new System.Drawing.Point(222, 294);
            this.pictureBox14.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(97, 88);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox14.TabIndex = 14;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "14";
            this.pictureBox14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox13.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox13.Location = new System.Drawing.Point(114, 294);
            this.pictureBox13.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(97, 88);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "13";
            this.pictureBox13.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox12.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox12.Location = new System.Drawing.Point(6, 294);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(97, 88);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "12";
            this.pictureBox12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox11.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox11.Location = new System.Drawing.Point(330, 198);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(98, 85);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 11;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "11";
            this.pictureBox11.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox10.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox10.Location = new System.Drawing.Point(222, 198);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(97, 85);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "10";
            this.pictureBox10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox9.Location = new System.Drawing.Point(114, 198);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(97, 85);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "9";
            this.pictureBox9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox8.Location = new System.Drawing.Point(6, 198);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(97, 85);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "8";
            this.pictureBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox7.Location = new System.Drawing.Point(330, 102);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(98, 85);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "7";
            this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox6.Location = new System.Drawing.Point(222, 102);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(97, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "6";
            this.pictureBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox5.Location = new System.Drawing.Point(114, 102);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(97, 85);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "5";
            this.pictureBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox4.Location = new System.Drawing.Point(6, 102);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(97, 85);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "4";
            this.pictureBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox3.Location = new System.Drawing.Point(330, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(98, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "3";
            this.pictureBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(222, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(97, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "2";
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox1.Location = new System.Drawing.Point(114, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "1";
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // pictureBox0
            // 
            this.pictureBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox0.Image = global::MemoryCards.Properties.Resources._0;
            this.pictureBox0.Location = new System.Drawing.Point(6, 6);
            this.pictureBox0.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(97, 85);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox0.TabIndex = 0;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Tag = "0";
            this.pictureBox0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // FormMemory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "FormMemory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карточки памяти";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_game;
        private System.Windows.Forms.ToolStripMenuItem menu_game_new;
        private System.Windows.Forms.ToolStripSeparator menu_game_s1;
        private System.Windows.Forms.ToolStripMenuItem menu_game_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem munu_help_rules;
        private System.Windows.Forms.ToolStripSeparator menu_help_s1;
        private System.Windows.Forms.ToolStripMenuItem menu_help_about;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

