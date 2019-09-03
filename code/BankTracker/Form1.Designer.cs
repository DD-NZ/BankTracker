namespace BankTracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Background = new System.Windows.Forms.Panel();
            this.loading = new System.Windows.Forms.Panel();
            this.loadTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.loadButtonPanel = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.mainpage = new System.Windows.Forms.Panel();
            this.mainpageTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ascendingButton = new System.Windows.Forms.RadioButton();
            this.descendingButton = new System.Windows.Forms.RadioButton();
            this.searchInput = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.statsButton = new System.Windows.Forms.Button();
            this.displayBackPanel = new System.Windows.Forms.Panel();
            this.displayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Statspanel = new System.Windows.Forms.Panel();
            this.statsText = new System.Windows.Forms.RichTextBox();
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.loadingProgress = new System.Windows.Forms.ProgressBar();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.Background.SuspendLayout();
            this.loading.SuspendLayout();
            this.loadTableLayout.SuspendLayout();
            this.loadButtonPanel.SuspendLayout();
            this.mainpage.SuspendLayout();
            this.mainpageTableLayout.SuspendLayout();
            this.panel1.SuspendLayout();
            this.displayBackPanel.SuspendLayout();
            this.Statspanel.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.loading);
            this.Background.Controls.Add(this.mainpage);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(584, 561);
            this.Background.TabIndex = 0;
            // 
            // loading
            // 
            this.loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.loading.Controls.Add(this.loadTableLayout);
            this.loading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loading.Location = new System.Drawing.Point(0, 0);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(584, 561);
            this.loading.TabIndex = 0;
            // 
            // loadTableLayout
            // 
            this.loadTableLayout.ColumnCount = 1;
            this.loadTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.loadTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.loadTableLayout.Controls.Add(this.loadButtonPanel, 0, 1);
            this.loadTableLayout.Controls.Add(this.logoPanel, 0, 0);
            this.loadTableLayout.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadTableLayout.Location = new System.Drawing.Point(0, 0);
            this.loadTableLayout.Name = "loadTableLayout";
            this.loadTableLayout.RowCount = 2;
            this.loadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.loadTableLayout.Size = new System.Drawing.Size(584, 561);
            this.loadTableLayout.TabIndex = 0;
            // 
            // loadButtonPanel
            // 
            this.loadButtonPanel.Controls.Add(this.loadButton);
            this.loadButtonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadButtonPanel.Location = new System.Drawing.Point(3, 283);
            this.loadButtonPanel.Name = "loadButtonPanel";
            this.loadButtonPanel.Size = new System.Drawing.Size(578, 275);
            this.loadButtonPanel.TabIndex = 0;
            // 
            // loadButton
            // 
            this.loadButton.AutoSize = true;
            this.loadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.loadButton.FlatAppearance.BorderSize = 0;
            this.loadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.ForeColor = System.Drawing.Color.White;
            this.loadButton.Image = global::BankTracker.Properties.Resources.folderIcon;
            this.loadButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.loadButton.Location = new System.Drawing.Point(209, 94);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(175, 99);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load Statement";
            this.loadButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.loadButton.UseVisualStyleBackColor = false;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // mainpage
            // 
            this.mainpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.mainpage.Controls.Add(this.mainpageTableLayout);
            this.mainpage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpage.Location = new System.Drawing.Point(0, 0);
            this.mainpage.Name = "mainpage";
            this.mainpage.Size = new System.Drawing.Size(584, 561);
            this.mainpage.TabIndex = 1;
            // 
            // mainpageTableLayout
            // 
            this.mainpageTableLayout.ColumnCount = 2;
            this.mainpageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainpageTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.mainpageTableLayout.Controls.Add(this.panel1, 0, 0);
            this.mainpageTableLayout.Controls.Add(this.displayBackPanel, 1, 0);
            this.mainpageTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpageTableLayout.Location = new System.Drawing.Point(0, 0);
            this.mainpageTableLayout.Name = "mainpageTableLayout";
            this.mainpageTableLayout.RowCount = 1;
            this.mainpageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainpageTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 561F));
            this.mainpageTableLayout.Size = new System.Drawing.Size(584, 561);
            this.mainpageTableLayout.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ascendingButton);
            this.panel1.Controls.Add(this.descendingButton);
            this.panel1.Controls.Add(this.searchInput);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.toDate);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.fromDate);
            this.panel1.Controls.Add(this.statsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 541);
            this.panel1.TabIndex = 1;
            // 
            // ascendingButton
            // 
            this.ascendingButton.AutoSize = true;
            this.ascendingButton.Checked = true;
            this.ascendingButton.ForeColor = System.Drawing.Color.Transparent;
            this.ascendingButton.Location = new System.Drawing.Point(91, 197);
            this.ascendingButton.Name = "ascendingButton";
            this.ascendingButton.Size = new System.Drawing.Size(75, 17);
            this.ascendingButton.TabIndex = 8;
            this.ascendingButton.TabStop = true;
            this.ascendingButton.Text = "Ascending";
            this.ascendingButton.UseVisualStyleBackColor = true;
            this.ascendingButton.CheckedChanged += new System.EventHandler(this.AscendingButton_CheckedChanged);
            // 
            // descendingButton
            // 
            this.descendingButton.AutoSize = true;
            this.descendingButton.ForeColor = System.Drawing.Color.Transparent;
            this.descendingButton.Location = new System.Drawing.Point(0, 197);
            this.descendingButton.Name = "descendingButton";
            this.descendingButton.Size = new System.Drawing.Size(82, 17);
            this.descendingButton.TabIndex = 7;
            this.descendingButton.Text = "Descending";
            this.descendingButton.UseVisualStyleBackColor = true;
            this.descendingButton.CheckedChanged += new System.EventHandler(this.DescendingButton_CheckedChanged);
            // 
            // searchInput
            // 
            this.searchInput.Location = new System.Drawing.Point(0, 29);
            this.searchInput.Name = "searchInput";
            this.searchInput.Size = new System.Drawing.Size(184, 20);
            this.searchInput.TabIndex = 6;
            this.searchInput.TextChanged += new System.EventHandler(this.SearchInput_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Transparent;
            this.textBox3.Location = new System.Drawing.Point(0, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 19);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Search";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(0, 146);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(184, 20);
            this.toDate.TabIndex = 4;
            this.toDate.ValueChanged += new System.EventHandler(this.ToDate_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Transparent;
            this.textBox2.Location = new System.Drawing.Point(0, 121);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(184, 19);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "To Date";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Transparent;
            this.textBox1.Location = new System.Drawing.Point(0, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(184, 19);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "From Date";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(2, 85);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(184, 20);
            this.fromDate.TabIndex = 1;
            this.fromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // statsButton
            // 
            this.statsButton.FlatAppearance.BorderSize = 0;
            this.statsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsButton.ForeColor = System.Drawing.Color.Transparent;
            this.statsButton.Image = global::BankTracker.Properties.Resources.stat_32;
            this.statsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statsButton.Location = new System.Drawing.Point(0, 260);
            this.statsButton.Name = "statsButton";
            this.statsButton.Size = new System.Drawing.Size(184, 40);
            this.statsButton.TabIndex = 0;
            this.statsButton.Text = "Stats";
            this.statsButton.UseVisualStyleBackColor = true;
            this.statsButton.Click += new System.EventHandler(this.statsButton_Click);
            // 
            // displayBackPanel
            // 
            this.displayBackPanel.Controls.Add(this.displayPanel);
            this.displayBackPanel.Controls.Add(this.Statspanel);
            this.displayBackPanel.Controls.Add(this.loadingPanel);
            this.displayBackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayBackPanel.Location = new System.Drawing.Point(207, 3);
            this.displayBackPanel.Name = "displayBackPanel";
            this.displayBackPanel.Size = new System.Drawing.Size(374, 555);
            this.displayBackPanel.TabIndex = 2;
            // 
            // displayPanel
            // 
            this.displayPanel.AutoScroll = true;
            this.displayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.displayPanel.Location = new System.Drawing.Point(0, 0);
            this.displayPanel.Name = "displayPanel";
            this.displayPanel.Size = new System.Drawing.Size(374, 555);
            this.displayPanel.TabIndex = 0;
            this.displayPanel.WrapContents = false;
            // 
            // Statspanel
            // 
            this.Statspanel.Controls.Add(this.statsText);
            this.Statspanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Statspanel.Location = new System.Drawing.Point(0, 0);
            this.Statspanel.Name = "Statspanel";
            this.Statspanel.Size = new System.Drawing.Size(374, 555);
            this.Statspanel.TabIndex = 1;
            // 
            // statsText
            // 
            this.statsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.statsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsText.ForeColor = System.Drawing.Color.White;
            this.statsText.Location = new System.Drawing.Point(0, 0);
            this.statsText.Name = "statsText";
            this.statsText.Size = new System.Drawing.Size(374, 555);
            this.statsText.TabIndex = 0;
            this.statsText.Text = "";
            // 
            // loadingPanel
            // 
            this.loadingPanel.Controls.Add(this.textBox4);
            this.loadingPanel.Controls.Add(this.loadingProgress);
            this.loadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(374, 555);
            this.loadingPanel.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(51)))), ((int)(((byte)(65)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(125, 242);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 0;
            this.textBox4.Text = "Processing";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loadingProgress
            // 
            this.loadingProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(170)))), ((int)(((byte)(224)))));
            this.loadingProgress.Location = new System.Drawing.Point(93, 280);
            this.loadingProgress.MarqueeAnimationSpeed = 10;
            this.loadingProgress.Name = "loadingProgress";
            this.loadingProgress.Size = new System.Drawing.Size(172, 23);
            this.loadingProgress.TabIndex = 1;
            // 
            // logoPanel
            // 
            this.logoPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPanel.BackgroundImage")));
            this.logoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPanel.Location = new System.Drawing.Point(3, 3);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(578, 274);
            this.logoPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.Background);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Background.ResumeLayout(false);
            this.loading.ResumeLayout(false);
            this.loadTableLayout.ResumeLayout(false);
            this.loadButtonPanel.ResumeLayout(false);
            this.loadButtonPanel.PerformLayout();
            this.mainpage.ResumeLayout(false);
            this.mainpageTableLayout.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.displayBackPanel.ResumeLayout(false);
            this.Statspanel.ResumeLayout(false);
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Background;
        private System.Windows.Forms.Panel mainpage;
        private System.Windows.Forms.TableLayoutPanel loadTableLayout;
        private System.Windows.Forms.Panel loadButtonPanel;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Panel loading;
        private System.Windows.Forms.TableLayoutPanel mainpageTableLayout;
        private System.Windows.Forms.FlowLayoutPanel displayPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button statsButton;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox searchInput;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton ascendingButton;
        private System.Windows.Forms.RadioButton descendingButton;
        private System.Windows.Forms.Panel displayBackPanel;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.ProgressBar loadingProgress;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel Statspanel;
        private System.Windows.Forms.RichTextBox statsText;
        private System.Windows.Forms.Panel logoPanel;
    }
}

