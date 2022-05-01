using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace TextToSpeechConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Initializes new object of SpeechSynthesizer Class that provides access to the functionality of already installed speech synthesis software
        SpeechSynthesizer speechSynthesizerObj;

        private void Button_Speak_Click(object sender, EventArgs e)
        {
            //Dispose current SpeechSynthesizer object
            speechSynthesizerObj.Dispose();
            if (speakBox.Text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                //Asynchronously speaks contents currently in speakBox
                speechSynthesizerObj.SpeakAsync(speakBox.Text);
                Button_Pause.Enabled = true;
                Button_Stop.Enabled = true;
            }
        }

        private void Button_Pause_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                //Get current speaking state for SpeechSynthesizer object and acts appropiately
                if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                {
                    //Stop the speaking object
                    speechSynthesizerObj.Pause();
                    Button_Resume.Enabled = true;
                    Button_Speak.Enabled = false;
                    Button_Pause.Enabled = false;
                }
            }
        }

        private void Button_Resume_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                //Get current speaking state for SpeechSynthesizer object and acts appropiately
                if (speechSynthesizerObj.State == SynthesizerState.Paused)
                {
                    //Resume the speaking object if it's been paused
                    speechSynthesizerObj.Resume();
                    Button_Resume.Enabled = false;
                    Button_Speak.Enabled = true;
                    Button_Pause.Enabled = true;
                }
            }
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                //Dispose current SpeechSynthesizer object
                speechSynthesizerObj.Dispose();
                Button_Speak.Enabled = true;
                Button_Resume.Enabled = false;
                Button_Pause.Enabled = false;
                Button_Stop.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Setting each button to their desired state at start
            speechSynthesizerObj = new SpeechSynthesizer();
            Button_Speak.Enabled = true;
            Button_Resume.Enabled = false;
            Button_Pause.Enabled = false;
            Button_Stop.Enabled = false;
        }
    }
}
