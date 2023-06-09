using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace Piano_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var s in noteWav)
            {
                s.Load();
            }
        }

        struct noteDetails
        {
            public int streamIndex;
            public int tickTime;
            public int tempoChange;
        }

        List<noteDetails> noteQueue = new List<noteDetails>();

        static Dictionary<char, int> durations = new Dictionary<char, int>
        {
            {'s', 2},
            {'e', 4},
            {'q', 8},
            {'h', 16},
            {'w', 32},
            {'S', 3},
            {'E', 6},
            {'Q', 12},
            {'H', 24},
            {'W', 48},
        };

        bool editMode_On = false;
        bool recordMode_On = false;

        public long startTickCount = 0;

        private string[] noteDurationStrings = new string[10] { "s ", "e ", "q ", "h ", "w ", "S ", "E ", "Q ", "H ", "W " };

        List<SoundPlayer> noteWav = new List<SoundPlayer>()
        {
            new SoundPlayer(Piano_UI.Properties.Resources.A4),    // 0
            new SoundPlayer(Piano_UI.Properties.Resources.A4_),   // 1
            new SoundPlayer(Piano_UI.Properties.Resources.B4),    // 2
            new SoundPlayer(Piano_UI.Properties.Resources.C4),    // 3
            new SoundPlayer(Piano_UI.Properties.Resources.C4_),   // 4
            new SoundPlayer(Piano_UI.Properties.Resources.D4),    // 5
            new SoundPlayer(Piano_UI.Properties.Resources.D4_),   // 6
            new SoundPlayer(Piano_UI.Properties.Resources.E4),    // 7
            new SoundPlayer(Piano_UI.Properties.Resources.F4),    // 8
            new SoundPlayer(Piano_UI.Properties.Resources.F4_),   // 9
            new SoundPlayer(Piano_UI.Properties.Resources.G4),    // 10
            new SoundPlayer(Piano_UI.Properties.Resources.G4_),   // 11
            new SoundPlayer(Piano_UI.Properties.Resources.A5),    // 12
            new SoundPlayer(Piano_UI.Properties.Resources.A5_),   // 13
            new SoundPlayer(Piano_UI.Properties.Resources.B5),    // 14
            new SoundPlayer(Piano_UI.Properties.Resources.C5),    // 15
            new SoundPlayer(Piano_UI.Properties.Resources.C5_),   // 16
            new SoundPlayer(Piano_UI.Properties.Resources.D5),    // 17
            new SoundPlayer(Piano_UI.Properties.Resources.D5_),   // 18
            new SoundPlayer(Piano_UI.Properties.Resources.E5),    // 19
            new SoundPlayer(Piano_UI.Properties.Resources.F5),    // 20
            new SoundPlayer(Piano_UI.Properties.Resources.F5_),   // 21
            new SoundPlayer(Piano_UI.Properties.Resources.G5),    // 22
            new SoundPlayer(Piano_UI.Properties.Resources.G5_),   // 23
            new SoundPlayer(Piano_UI.Properties.Resources.C6)     // 24
        };

        SoundPlayer soundOut = new SoundPlayer(Piano_UI.Properties.Resources.C4);

        private string Quantize(long duration)
        {
            string noteLength = string.Empty;
            if (checkBox1.Checked)
            {
                duration = (long)(duration * (trackBar1.Value / 120f));
            }
            if (duration < 72) noteLength = "s";
            else if (duration < 102) noteLength = "S";
            else if (duration < 141) noteLength = "e";
            else if (duration < 204) noteLength = "E";
            else if (duration < 281) noteLength = "q";
            else if (duration < 406) noteLength = "Q";
            else if (duration < 576) noteLength = "h";
            else if (duration < 826) noteLength = "H";
            else if (duration < 1126) noteLength = "w";
            else noteLength = "W";
            return noteLength + " ";
        }

        private void WriteNote(string note)
        {
            if (editMode_On && note != null)
            {
                SongEntry.AppendText(note + noteDurationStrings[comboBox1.SelectedIndex]);
            }
        }

        private void StringToQueue(string song, bool clearQueue = true)
        {
            int newTempo;

            if (clearQueue)
            {
                noteeQueue.Clear();
            }

            for (int i = 0; i < song.Length; i += 4)
            {
                noteDetails nd = new noteDetails();
                int octave = song[i + 1] - '4';
                if (octave < 0 || octave > 2)
                {
                    octave = 0;
                }
                if (song[i] >= 'a' && song[i] <= 'g')
                {
                    nd.streamIndex = (song[i] - 'a') + 7 * octave;
                    int.TryParse(song.Substring(i, 3), out newTempo);
                }
                else if (song[i] >= 'A' && song[i] <= 'G')
                {
                    nd.streamIndex = (song[i] - 'A') + 7 * octave;
                    int.TryParse(song.Substring(i, 3), out newTempo);
                }
                else
                {
                    nd.streamIndex = -999;
                }
                nd.tickTime = durations[song[i + 2]];
                noteeQueue.Add(nd);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // edit mode
            editMode_On = !editMode_On;

            if (editMode_On)
            {
                if (recordMode_On)
                {
                    recordMode_On = false;
                    button5.BackColor = Color.White;
                }

                button6.BackColor = Color.Red;
            }
            else
            {
                button6.BackColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // record mode
            recordMode_On = !recordMode_On;

            if (recordMode_On)
            {
                if (editMode_On)
                {
                    editMode_On = false;
                    button6.BackColor = Color.White;
                }

                button5.BackColor = Color.Red;
            }
            else
            {
                button5.BackColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // back
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // play
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // stop
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // forward
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // X
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // c4
            WriteNote("c4");
            SoundPlayer soundOut = noteWav[3];
            soundOut.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // d4
            WriteNote("d4");
            SoundPlayer soundOut = noteWav[5];
            soundOut.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // e4
            WriteNote("e4");
            SoundPlayer soundOut = noteWav[7];
            soundOut.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // f4
            WriteNote("f4");
            SoundPlayer soundOut = noteWav[8];
            soundOut.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            // g4
            WriteNote("g4");
            SoundPlayer soundOut = noteWav[10];
            soundOut.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // a4
            WriteNote("a4");
            SoundPlayer soundOut = noteWav[0];
            soundOut.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // b4
            WriteNote("b4");
            SoundPlayer soundOut = noteWav[2];
            soundOut.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // c5
            WriteNote("c5");
            SoundPlayer soundOut = noteWav[15];
            soundOut.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // d5
            WriteNote("d5");
            SoundPlayer soundOut = noteWav[17];
            soundOut.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            // e5
            WriteNote("e5");
            SoundPlayer soundOut = noteWav[19];
            soundOut.Play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            // f5
            WriteNote("f5");
            SoundPlayer soundOut = noteWav[20];
            soundOut.Play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            // g5
            WriteNote("g5");
            SoundPlayer soundOut = noteWav[22];
            soundOut.Play();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // a5
            WriteNote("a5");
            SoundPlayer soundOut = noteWav[12];
            soundOut.Play();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            // b5
            WriteNote("b5");
            SoundPlayer soundOut = noteWav[14];
            soundOut.Play();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            // c6
            WriteNote("c6");
            SoundPlayer soundOut = noteWav[24];
            soundOut.Play();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            // C4#
            WriteNote("C4");
            SoundPlayer soundOut = noteWav[4];
            soundOut.Play();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // D4#
            WriteNote("D4");
            SoundPlayer soundOut = noteWav[6];
            soundOut.Play();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            // F4#
            WriteNote("F4");
            SoundPlayer soundOut = noteWav[9];
            soundOut.Play();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            // G4#
            WriteNote("G4");
            SoundPlayer soundOut = noteWav[11];
            soundOut.Play();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            // A4#
            WriteNote("A4");
            SoundPlayer soundOut = noteWav[1];
            soundOut.Play();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            // C5#
            WriteNote("C5");
            SoundPlayer soundOut = noteWav[16];
            soundOut.Play();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            // D5#
            WriteNote("D5");
            SoundPlayer soundOut = noteWav[18];
            soundOut.Play();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            // F5#
            WriteNote("F5");
            SoundPlayer soundOut = noteWav[21];
            soundOut.Play();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            // G5#
            WriteNote("G5");
            SoundPlayer soundOut = noteWav[23];
            soundOut.Play();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            // A5#
            WriteNote("A5");
            SoundPlayer soundOut = noteWav[13];
            soundOut.Play();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void SongEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = "TEMPO: " + trackBar1.Value.ToString("D3"); 
        }

        private void button9_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (editMode_On) { return; }
            if (recordMode_On)
            {
                startTickCount = Environment.TickCount + Int32.MaxValue;
            }

            soundOut.Stop();
            soundOut = new SoundPlayer(Piano_UI.Properties.Resources.C4);
            soundOut.Play();
        }

        private void button9_MouseUp_1(object sender, MouseEventArgs e)
        {
            soundOut.Stop();
            if (recordMode_On)
            {
                long endTick = Environment.TickCount + Int32.MaxValue;
                long length = endTick - startTickCount;
                SongEntry.AppendText("c4" + Quantize(length));
            }
        }
    }
}