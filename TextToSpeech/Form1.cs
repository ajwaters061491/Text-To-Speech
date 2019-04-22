using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer(); //new instance of the sythesizer object
            synth.SetOutputToDefaultAudioDevice(); //setting playback device


            synth.Speak(TextBoxEntry.Text); //this should read the text box' content
            TextBoxEntry.Text = ""; //clears text
        }
    }
}
