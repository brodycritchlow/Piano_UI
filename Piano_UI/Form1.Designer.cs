namespace Piano_UI
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            current_playlist_label = new Label();
            playlist_entry = new ComboBox();
            load = new Button();
            save = new Button();
            Clear = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label2 = new Label();
            trackBar1 = new TrackBar();
            comboBox1 = new ComboBox();
            button8 = new Button();
            label3 = new Label();
            SongEntry = new TextBox();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            button25 = new Button();
            button26 = new Button();
            button27 = new Button();
            button28 = new Button();
            button29 = new Button();
            button30 = new Button();
            button31 = new Button();
            button32 = new Button();
            button33 = new Button();
            checkBox1 = new CheckBox();
            timerMetronome = new System.Windows.Forms.Timer(components);
            button34 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // current_playlist_label
            // 
            current_playlist_label.AutoSize = true;
            current_playlist_label.BackColor = Color.Transparent;
            current_playlist_label.FlatStyle = FlatStyle.Flat;
            current_playlist_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            current_playlist_label.Location = new Point(9, 9);
            current_playlist_label.Name = "current_playlist_label";
            current_playlist_label.Size = new Size(172, 21);
            current_playlist_label.TabIndex = 0;
            current_playlist_label.Text = "Current Playlist Entry";
            // 
            // playlist_entry
            // 
            playlist_entry.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            playlist_entry.FormattingEnabled = true;
            playlist_entry.ItemHeight = 21;
            playlist_entry.Location = new Point(12, 34);
            playlist_entry.Name = "playlist_entry";
            playlist_entry.Size = new Size(249, 29);
            playlist_entry.TabIndex = 1;
            playlist_entry.SelectedIndexChanged += playlist_entry_SelectedIndexChanged;
            // 
            // load
            // 
            load.FlatStyle = FlatStyle.Flat;
            load.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            load.Location = new Point(141, 71);
            load.Name = "load";
            load.Size = new Size(129, 36);
            load.TabIndex = 2;
            load.Text = "Load Playlist";
            load.UseVisualStyleBackColor = true;
            load.Click += load_Click;
            // 
            // save
            // 
            save.FlatStyle = FlatStyle.Flat;
            save.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            save.Location = new Point(141, 113);
            save.Name = "save";
            save.Size = new Size(129, 36);
            save.TabIndex = 3;
            save.Text = "Save Playlist";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // Clear
            // 
            Clear.FlatStyle = FlatStyle.Flat;
            Clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(9, 113);
            Clear.Name = "Clear";
            Clear.Size = new Size(129, 36);
            Clear.TabIndex = 4;
            Clear.Text = "Clear Playlist";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(513, 9);
            button1.Name = "button1";
            button1.Size = new Size(89, 86);
            button1.TabIndex = 5;
            button1.Text = "⏮️";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(608, 9);
            button2.Name = "button2";
            button2.Size = new Size(89, 86);
            button2.TabIndex = 6;
            button2.Text = "▶️";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(703, 9);
            button3.Name = "button3";
            button3.Size = new Size(89, 86);
            button3.TabIndex = 7;
            button3.Text = "⏹️";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlText;
            button4.Location = new Point(798, 9);
            button4.Name = "button4";
            button4.Size = new Size(89, 86);
            button4.TabIndex = 8;
            button4.Text = "⏭️";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.ImageAlign = ContentAlignment.TopCenter;
            button5.Location = new Point(993, 9);
            button5.Name = "button5";
            button5.Size = new Size(89, 86);
            button5.TabIndex = 9;
            button5.Text = "● ";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlText;
            button6.Location = new Point(1088, 12);
            button6.Name = "button6";
            button6.Size = new Size(89, 86);
            button6.TabIndex = 10;
            button6.Text = "✎";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlText;
            button7.Location = new Point(1183, 15);
            button7.Name = "button7";
            button7.Size = new Size(89, 86);
            button7.TabIndex = 11;
            button7.Text = "❌";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(516, 103);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 12;
            label2.Text = "TEMPO: 120";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(655, 101);
            trackBar1.Maximum = 240;
            trackBar1.Minimum = 20;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(232, 45);
            trackBar1.TabIndex = 13;
            trackBar1.Value = 20;
            trackBar1.Scroll += trackBar1_Scroll;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sixteenth", "Eigth", "Quarter", "Half", "Whole", "Dotted Sixteenth", "Dotted Eigth", "Dotted Quarter", "Dotted Half", "Dotted Whole" });
            comboBox1.Location = new Point(993, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(153, 29);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(1183, 98);
            button8.Name = "button8";
            button8.Size = new Size(102, 32);
            button8.TabIndex = 15;
            button8.Text = "Add Rest";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 171);
            label3.Name = "label3";
            label3.Size = new Size(110, 21);
            label3.TabIndex = 16;
            label3.Text = "Current Song";
            // 
            // SongEntry
            // 
            SongEntry.Location = new Point(11, 203);
            SongEntry.Multiline = true;
            SongEntry.Name = "SongEntry";
            SongEntry.Size = new Size(1303, 130);
            SongEntry.TabIndex = 17;
            SongEntry.TextChanged += SongEntry_TextChanged;
            // 
            // button9
            // 
            button9.BackColor = Color.GhostWhite;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.ImageAlign = ContentAlignment.BottomCenter;
            button9.Location = new Point(91, 352);
            button9.Name = "button9";
            button9.Size = new Size(71, 174);
            button9.TabIndex = 18;
            button9.Text = "C4";
            button9.TextAlign = ContentAlignment.BottomCenter;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            button9.MouseDown += button9_MouseDown_1;
            button9.MouseUp += button9_MouseUp_1;
            // 
            // button10
            // 
            button10.BackColor = Color.GhostWhite;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.ImageAlign = ContentAlignment.BottomCenter;
            button10.Location = new Point(168, 352);
            button10.Name = "button10";
            button10.Size = new Size(71, 174);
            button10.TabIndex = 19;
            button10.Text = "D4";
            button10.TextAlign = ContentAlignment.BottomCenter;
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            button10.MouseDown += button10_MouseDown;
            button10.MouseUp += button10_MouseUp;
            // 
            // button11
            // 
            button11.BackColor = Color.GhostWhite;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.ImageAlign = ContentAlignment.BottomCenter;
            button11.Location = new Point(245, 352);
            button11.Name = "button11";
            button11.Size = new Size(71, 174);
            button11.TabIndex = 20;
            button11.Text = "E4";
            button11.TextAlign = ContentAlignment.BottomCenter;
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            button11.MouseDown += button11_MouseDown;
            button11.MouseUp += button11_MouseUp;
            // 
            // button12
            // 
            button12.BackColor = Color.GhostWhite;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.ImageAlign = ContentAlignment.BottomCenter;
            button12.Location = new Point(322, 352);
            button12.Name = "button12";
            button12.Size = new Size(71, 174);
            button12.TabIndex = 21;
            button12.Text = "F4";
            button12.TextAlign = ContentAlignment.BottomCenter;
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            button12.MouseDown += button12_MouseDown;
            button12.MouseUp += button12_MouseUp;
            // 
            // button13
            // 
            button13.BackColor = Color.GhostWhite;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.ImageAlign = ContentAlignment.BottomCenter;
            button13.Location = new Point(399, 352);
            button13.Name = "button13";
            button13.Size = new Size(71, 174);
            button13.TabIndex = 22;
            button13.Text = "G4";
            button13.TextAlign = ContentAlignment.BottomCenter;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            button13.MouseDown += button13_MouseDown;
            button13.MouseUp += button13_MouseUp;
            // 
            // button14
            // 
            button14.BackColor = Color.GhostWhite;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.ImageAlign = ContentAlignment.BottomCenter;
            button14.Location = new Point(476, 352);
            button14.Name = "button14";
            button14.Size = new Size(71, 174);
            button14.TabIndex = 23;
            button14.Text = "A4";
            button14.TextAlign = ContentAlignment.BottomCenter;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            button14.MouseDown += button14_MouseDown;
            button14.MouseUp += button14_MouseUp;
            // 
            // button15
            // 
            button15.BackColor = Color.GhostWhite;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.ImageAlign = ContentAlignment.BottomCenter;
            button15.Location = new Point(553, 352);
            button15.Name = "button15";
            button15.Size = new Size(71, 174);
            button15.TabIndex = 24;
            button15.Text = "B4";
            button15.TextAlign = ContentAlignment.BottomCenter;
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            button15.MouseDown += button15_MouseDown;
            button15.MouseUp += button15_MouseUp;
            // 
            // button16
            // 
            button16.BackColor = Color.GhostWhite;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.ImageAlign = ContentAlignment.BottomCenter;
            button16.Location = new Point(630, 352);
            button16.Name = "button16";
            button16.Size = new Size(71, 174);
            button16.TabIndex = 25;
            button16.Text = "C5";
            button16.TextAlign = ContentAlignment.BottomCenter;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            button16.MouseDown += button16_MouseDown;
            button16.MouseUp += button16_MouseUp;
            // 
            // button17
            // 
            button17.BackColor = Color.GhostWhite;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.ImageAlign = ContentAlignment.BottomCenter;
            button17.Location = new Point(707, 352);
            button17.Name = "button17";
            button17.Size = new Size(71, 174);
            button17.TabIndex = 26;
            button17.Text = "D5";
            button17.TextAlign = ContentAlignment.BottomCenter;
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            button17.MouseDown += button17_MouseDown;
            button17.MouseUp += button17_MouseUp;
            // 
            // button18
            // 
            button18.BackColor = Color.GhostWhite;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.ImageAlign = ContentAlignment.BottomCenter;
            button18.Location = new Point(784, 352);
            button18.Name = "button18";
            button18.Size = new Size(71, 174);
            button18.TabIndex = 27;
            button18.Text = "E5";
            button18.TextAlign = ContentAlignment.BottomCenter;
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            button18.MouseDown += button18_MouseDown;
            button18.MouseUp += button18_MouseUp;
            // 
            // button19
            // 
            button19.BackColor = Color.GhostWhite;
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatStyle = FlatStyle.Flat;
            button19.ImageAlign = ContentAlignment.BottomCenter;
            button19.Location = new Point(861, 352);
            button19.Name = "button19";
            button19.Size = new Size(71, 174);
            button19.TabIndex = 28;
            button19.Text = "F5";
            button19.TextAlign = ContentAlignment.BottomCenter;
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            button19.MouseDown += button19_MouseDown;
            button19.MouseUp += button19_MouseUp;
            // 
            // button20
            // 
            button20.BackColor = Color.GhostWhite;
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatStyle = FlatStyle.Flat;
            button20.ImageAlign = ContentAlignment.BottomCenter;
            button20.Location = new Point(938, 352);
            button20.Name = "button20";
            button20.Size = new Size(71, 174);
            button20.TabIndex = 29;
            button20.Text = "G5";
            button20.TextAlign = ContentAlignment.BottomCenter;
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            button20.MouseDown += button20_MouseDown;
            button20.MouseUp += button20_MouseUp;
            // 
            // button21
            // 
            button21.BackColor = Color.GhostWhite;
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatStyle = FlatStyle.Flat;
            button21.ImageAlign = ContentAlignment.BottomCenter;
            button21.Location = new Point(1015, 352);
            button21.Name = "button21";
            button21.Size = new Size(71, 174);
            button21.TabIndex = 30;
            button21.Text = "A5";
            button21.TextAlign = ContentAlignment.BottomCenter;
            button21.UseVisualStyleBackColor = false;
            button21.Click += button21_Click;
            button21.MouseDown += button21_MouseDown;
            button21.MouseUp += button21_MouseUp;
            // 
            // button22
            // 
            button22.BackColor = Color.GhostWhite;
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatStyle = FlatStyle.Flat;
            button22.ImageAlign = ContentAlignment.BottomCenter;
            button22.Location = new Point(1092, 352);
            button22.Name = "button22";
            button22.Size = new Size(71, 174);
            button22.TabIndex = 31;
            button22.Text = "B5";
            button22.TextAlign = ContentAlignment.BottomCenter;
            button22.UseVisualStyleBackColor = false;
            button22.Click += button22_Click;
            button22.MouseDown += button22_MouseDown;
            button22.MouseUp += button22_MouseUp;
            // 
            // button23
            // 
            button23.BackColor = Color.GhostWhite;
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatStyle = FlatStyle.Flat;
            button23.ImageAlign = ContentAlignment.BottomCenter;
            button23.Location = new Point(1169, 352);
            button23.Name = "button23";
            button23.Size = new Size(71, 174);
            button23.TabIndex = 32;
            button23.Text = "C6";
            button23.TextAlign = ContentAlignment.BottomCenter;
            button23.UseVisualStyleBackColor = false;
            button23.Click += button23_Click;
            button23.MouseDown += button23_MouseDown;
            button23.MouseUp += button23_MouseUp;
            // 
            // button24
            // 
            button24.BackColor = Color.Black;
            button24.FlatStyle = FlatStyle.Flat;
            button24.ForeColor = SystemColors.ControlText;
            button24.Location = new Point(148, 352);
            button24.Name = "button24";
            button24.Size = new Size(42, 122);
            button24.TabIndex = 33;
            button24.Text = "  ";
            button24.UseVisualStyleBackColor = false;
            button24.Click += button24_Click;
            button24.MouseDown += button24_MouseDown;
            button24.MouseUp += button24_MouseUp;
            // 
            // button25
            // 
            button25.BackColor = Color.Black;
            button25.FlatStyle = FlatStyle.Flat;
            button25.ForeColor = SystemColors.ControlText;
            button25.Location = new Point(219, 352);
            button25.Name = "button25";
            button25.Size = new Size(42, 122);
            button25.TabIndex = 34;
            button25.Text = "  ";
            button25.UseVisualStyleBackColor = false;
            button25.Click += button25_Click;
            button25.MouseDown += button25_MouseDown;
            button25.MouseUp += button25_MouseUp;
            // 
            // button26
            // 
            button26.BackColor = Color.Black;
            button26.FlatStyle = FlatStyle.Flat;
            button26.ForeColor = SystemColors.ControlText;
            button26.Location = new Point(379, 352);
            button26.Name = "button26";
            button26.Size = new Size(42, 122);
            button26.TabIndex = 35;
            button26.Text = "  ";
            button26.UseVisualStyleBackColor = false;
            button26.Click += button26_Click;
            button26.MouseDown += button26_MouseDown;
            button26.MouseUp += button26_MouseUp;
            // 
            // button27
            // 
            button27.BackColor = Color.Black;
            button27.FlatStyle = FlatStyle.Flat;
            button27.ForeColor = SystemColors.ControlText;
            button27.Location = new Point(457, 352);
            button27.Name = "button27";
            button27.Size = new Size(42, 122);
            button27.TabIndex = 36;
            button27.Text = "  ";
            button27.UseVisualStyleBackColor = false;
            button27.Click += button27_Click;
            button27.MouseDown += button27_MouseDown;
            button27.MouseUp += button27_MouseUp;
            // 
            // button28
            // 
            button28.BackColor = Color.Black;
            button28.FlatStyle = FlatStyle.Flat;
            button28.ForeColor = SystemColors.ControlText;
            button28.Location = new Point(536, 352);
            button28.Name = "button28";
            button28.Size = new Size(42, 122);
            button28.TabIndex = 37;
            button28.Text = "  ";
            button28.UseVisualStyleBackColor = false;
            button28.Click += button28_Click;
            button28.MouseDown += button28_MouseDown;
            button28.MouseUp += button28_MouseUp;
            // 
            // button29
            // 
            button29.BackColor = Color.Black;
            button29.FlatStyle = FlatStyle.Flat;
            button29.ForeColor = SystemColors.ControlText;
            button29.Location = new Point(687, 352);
            button29.Name = "button29";
            button29.Size = new Size(42, 122);
            button29.TabIndex = 38;
            button29.Text = "  ";
            button29.UseVisualStyleBackColor = false;
            button29.Click += button29_Click;
            button29.MouseDown += button29_MouseDown;
            button29.MouseUp += button29_MouseUp;
            // 
            // button30
            // 
            button30.BackColor = Color.Black;
            button30.FlatStyle = FlatStyle.Flat;
            button30.ForeColor = SystemColors.ControlText;
            button30.Location = new Point(769, 352);
            button30.Name = "button30";
            button30.Size = new Size(42, 122);
            button30.TabIndex = 39;
            button30.Text = "  ";
            button30.UseVisualStyleBackColor = false;
            button30.Click += button30_Click;
            button30.MouseDown += button30_MouseDown;
            button30.MouseUp += button30_MouseUp;
            // 
            // button31
            // 
            button31.BackColor = Color.Black;
            button31.FlatStyle = FlatStyle.Flat;
            button31.ForeColor = SystemColors.ControlText;
            button31.Location = new Point(916, 352);
            button31.Name = "button31";
            button31.Size = new Size(42, 122);
            button31.TabIndex = 40;
            button31.Text = "  ";
            button31.UseVisualStyleBackColor = false;
            button31.Click += button31_Click;
            button31.MouseDown += button31_MouseDown;
            button31.MouseUp += button31_MouseUp;
            // 
            // button32
            // 
            button32.BackColor = Color.Black;
            button32.FlatStyle = FlatStyle.Flat;
            button32.ForeColor = SystemColors.ControlText;
            button32.Location = new Point(993, 352);
            button32.Name = "button32";
            button32.Size = new Size(42, 122);
            button32.TabIndex = 41;
            button32.Text = "  ";
            button32.UseVisualStyleBackColor = false;
            button32.Click += button32_Click;
            button32.MouseDown += button32_MouseDown;
            button32.MouseUp += button32_MouseUp;
            // 
            // button33
            // 
            button33.BackColor = Color.Black;
            button33.FlatStyle = FlatStyle.Flat;
            button33.ForeColor = SystemColors.ControlText;
            button33.Location = new Point(1075, 352);
            button33.Name = "button33";
            button33.Size = new Size(42, 122);
            button33.TabIndex = 42;
            button33.Text = "  ";
            button33.UseVisualStyleBackColor = false;
            button33.Click += button33_Click;
            button33.MouseDown += button33_MouseDown;
            button33.MouseUp += button33_MouseUp;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(516, 152);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 34);
            checkBox1.TabIndex = 43;
            checkBox1.Text = "Use tempo";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // timerMetronome
            // 
            timerMetronome.Enabled = true;
            timerMetronome.Interval = 55;
            timerMetronome.Tick += timerMetronome_Tick;
            // 
            // button34
            // 
            button34.FlatStyle = FlatStyle.Flat;
            button34.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button34.Location = new Point(9, 71);
            button34.Name = "button34";
            button34.Size = new Size(129, 36);
            button34.TabIndex = 44;
            button34.Text = "New Song";
            button34.UseVisualStyleBackColor = true;
            button34.Click += button34_Click;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(1320, 538);
            Controls.Add(button34);
            Controls.Add(checkBox1);
            Controls.Add(button33);
            Controls.Add(button32);
            Controls.Add(button31);
            Controls.Add(button30);
            Controls.Add(button29);
            Controls.Add(button28);
            Controls.Add(button27);
            Controls.Add(button26);
            Controls.Add(button25);
            Controls.Add(button24);
            Controls.Add(button23);
            Controls.Add(button22);
            Controls.Add(button21);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(SongEntry);
            Controls.Add(label3);
            Controls.Add(button8);
            Controls.Add(comboBox1);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Clear);
            Controls.Add(save);
            Controls.Add(load);
            Controls.Add(playlist_entry);
            Controls.Add(current_playlist_label);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label current_playlist_label;
        private ComboBox playlist_entry;
        private Button load;
        private Button save;
        private Button Clear;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label2;
        private TrackBar trackBar1;
        private ComboBox comboBox1;
        private Button button8;
        private Label label3;
        private TextBox SongEntry;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button27;
        private Button button28;
        private Button button29;
        private Button button30;
        private Button button31;
        private Button button32;
        private Button button33;
        private CheckBox checkBox1;
        private System.Windows.Forms.Timer timerMetronome;
        private Button button34;
    }
}