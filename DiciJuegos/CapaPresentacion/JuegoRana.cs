using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.IO;

namespace CapaPresentacion
{
    public partial class JuegoRana : UserControl
    {
        private SpeechRecognitionEngine escucha = new SpeechRecognitionEngine();
        int puntos = 0;
        public JuegoRana()
        {            
            InitializeComponent();
            Choices lista = new Choices();
            lista.Add(new string[] { "a" });
            Grammar gramatica = new Grammar(lista);
            try
            {
                escucha.SetInputToDefaultAudioDevice();
                escucha.LoadGrammar(gramatica);
                escucha.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Reconocedor);
                escucha.RecognizeAsync(RecognizeMode.Multiple);

                escucha.AudioLevelUpdated += nivel_audio;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: Debe conectar el microfono ");
            }
        }

        public void Reconocedor(object sender, SpeechRecognizedEventArgs e)
        {
            //if (e.Result.Text == "a")
            //{
            //    int CambioCoches = (carro1.Location.X == 182) ? 27 : 182;
            //    carro1.Location = new Point(CambioCoches, carro1.Location.Y);
            //}
        }

        public void nivel_audio(object sender, AudioLevelUpdatedEventArgs e)
        {
            int audio = e.AudioLevel;
            if (audio<=30)
            {
                Pb1.Size = new Size(audio * 20, Pb1.Size.Height);
            }
        }

        public void movimientoMosca()
        {
            Random rnd = new Random();
            int posX = rnd.Next(223, 600);
            PtrBxMosca.Location = new Point(posX, PtrBxMosca.Location.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movimientoMosca();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {       
            if (Pb1.Size.Width > PtrBxMosca.Location.X && Pb1.Size.Width < PtrBxMosca.Location.X + 55)
            {
                movimientoMosca();
                puntos ++;
                LbPuntos.Text = "Puntos: " + puntos.ToString();
            }
        }

        private void PtrBxRana_Click(object sender, EventArgs e)
        {

        }
    }
}
