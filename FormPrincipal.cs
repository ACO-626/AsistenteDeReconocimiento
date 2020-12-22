
//System.Speech.Synthesis funciones que permiten hablar al usuario
//System.Speech.Recognoized funciones que permiten escuchar al usuario
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;


namespace AsistenteDeReconocimiento
{
    public partial class FormPrincipal : Form
    {
        #region Variables globales
        string word;
        int aleatorio;
        Random random = new Random();

        #region orejadelPrograma
        SpeechRecognitionEngine oreja = new SpeechRecognitionEngine();
        #endregion
        #region bocadelPrograma
        SpeechSynthesizer boca = new SpeechSynthesizer();
        List<VoiceInfo> voiceInfos = new List<VoiceInfo>();
        #endregion

        #endregion

        #region Inicialización
        public FormPrincipal()
        {
            InitializeComponent();
            foreach (InstalledVoice voz in boca.GetInstalledVoices())
            {
                voiceInfos.Add(voz.VoiceInfo);
            }
            boca.Volume = 100;
            boca.Rate = 2;
            oreja.SetInputToDefaultAudioDevice();
            oreja.LoadGrammar(new DictationGrammar());
            oreja.SpeechRecognized += Lenguaje;
            oreja.RecognizeAsync(RecognizeMode.Multiple);            
        }
        #endregion|

        #region MétodoDetection
        private void Lenguaje(object sender, SpeechRecognizedEventArgs e)
        {
            
            textBox1.Text = e.Result.Text;           
            if (e.Result.Text == "hola" || e.Result.Text == "ola" || e.Result.Text == "o la")
            {
                boca.Rate = 2;
                boca.SpeakAsync("Hola jefe, ¿Cómo va todo?");
            }
            else if (e.Result.Text == "bien" || e.Result.Text == "estoy bien")
            {
                boca.SpeakAsync("Me alegra oir eso");
            }
            else if (e.Result.Text == "mal" || e.Result.Text == "estoy mal")
            {
                boca.SpeakAsync("¿por qué?");
            }
            else if (e.Result.Text == "activa señas" || e.Result.Text == "señas")
            {
                boca.SpeakAsync("Activando modo de accesibilidad");
                pictureSimpleOne.Visible = true;
                pictureSimple2.Visible = true;
            }
            else if (e.Result.Text == "adiós" || e.Result.Text == "a Dios" || e.Result.Text == "el avion" || e.Result.Text=="avión se") 
            {
                GeneraRespuestaSincrona("adios", "Nos vemos", "Cerrando", "Hasta luego, jefe", "Cuidate", "Siempre es un placer ayudarlo");
                this.Close();

            }
        }
        #endregion

        #region Accesibilidad
        private void btnSign_Click(object sender, EventArgs e)
        {
            if(pictureSimple2.Visible==true)
            {
                pictureSimpleOne.Visible = false;
                pictureSimple2.Visible = false;
            }
            else
            {
                pictureSimpleOne.Visible = true;
                pictureSimple2.Visible = true;
            }
            
        }
        #endregion

        #region LoadPrincipal
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            GeneraRespuestaAsincrona("hola", "hola", "hola estoy lista para trabajar", "Saludos jefe", "Me alegra verte","hola, No has cambiado nada");
        }
        #endregion

        #region GenerarRespuestaSincrona5
        private void GeneraRespuestaSincrona(string frase, string uno, string dos, string tres, string cuatro, string cinco)
        {
            aleatorio = random.Next(1, 5);
            switch (aleatorio)
            {
                case 1:
                    boca.Speak(uno.ToString());
                    break;
                case 2:
                    boca.Speak(dos.ToString());
                    break;
                case 3:
                    boca.Speak(tres.ToString());
                    break;
                case 4:
                    boca.Speak(cuatro.ToString());
                    break;
                case 5:
                    boca.Speak(cinco.ToString());
                    break;
            }
        }
        #endregion

        #region GenerarRespuestaAsincrona5
        private void GeneraRespuestaAsincrona(string frase, string uno, string dos, string tres, string cuatro, string cinco)
        {
            aleatorio = random.Next(1, 5);
            switch (aleatorio)
            {
                case 1:
                    boca.SpeakAsync(uno.ToString());
                    break;
                case 2:
                    boca.SpeakAsync(dos.ToString());
                    break;
                case 3:
                    boca.SpeakAsync(tres.ToString());
                    break;
                case 4:
                    boca.SpeakAsync(cuatro.ToString());
                    break;
                case 5:
                    boca.SpeakAsync(cinco.ToString());
                    break;
            }
        }
        #endregion

    }
}
