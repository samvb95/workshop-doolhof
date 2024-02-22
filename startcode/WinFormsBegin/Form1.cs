using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoolhofApp
{
    public partial class Form1 : Form
    {
        private static Random _generator = new Random();

        private int _rijIngang = -1;
        private int _kolomIngang = -1;
        private int _rijUitgang = -1;
        private int _kolomUitgang = -1;
        private int _rijSpeler = -1;
        private int _kolomSpeler = -1;

        // hoe doolhof bijhouden?

        public Form1()
        {
            InitializeComponent();
            EnableDisable(SpelStatus.Initieel);
        }

        /// <summary>
        /// Procedure die uitgevoerd wordt als de waarde van nudAantalRijen of nudAantalkolommen gewijzigd wordt
        /// </summary>
        /// <param name="sender">nudAantalRijen of nudAantalKolommen</param>
        /// <param name="e">Extra info over het event (niet interessant indien type EventArgs is).</param>
        private void nudAantal_ValueChanged(object sender, EventArgs e)
        {
            EnableDisable(SpelStatus.DimensiesGewijzigd);
        }

        /// <summary>
        /// Procedure die uitgevoerd wordt als btnCreëer geklikt wordt.
        /// </summary>
        /// <param name="sender">btnCreëer</param>
        /// <param name="e">Extra info over het event (niet interessant indien type EventArgs is).</param>
        private void btnCreëer_Click(object sender, EventArgs e)
        {
            EnableDisable(SpelStatus.Gecreëerd);

            Creëer();
        }

        /// <summary>
        /// Deze procedure maakt het doolhof
        /// </summary>
        private void Creëer()
        {
            //maak een doolhof met de gevraagde afmetingen
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procedure die uitgevoerd wordt als btnInitialiseer geklikt wordt.
        /// </summary>
        /// <param name="sender">btnInitialiseer</param>
        /// <param name="e">Extra info over het event (niet interessant indien type EventArgs is).</param>
        private void btnInitialiseer_Click(object sender, EventArgs e)
        {
            EnableDisable(SpelStatus.Geïnitialiseerd);

            Initialiseer();
            TekenDoolhof();
        }

        /// <summary>
        /// Deze procedure vult het doolhof met cellen die oorspronkelijk allemaal muren bevatten
        /// </summary>
        private void Initialiseer()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Procedure die uitgevoerd wordt als btnGenereer geklikt wordt.
        /// Deze procedure roept de methode Genereer op die het doolhof zal genereren.
        /// </summary>
        /// <param name="sender">btnGenereer</param>
        /// <param name="e">Extra info over het event (niet interessant indien type EventArgs is).</param>
        private void btnGenereer_Click(object sender, EventArgs e)
        {
            EnableDisable(SpelStatus.Gegenereerd);

            //genereer het doolhof
            throw new NotImplementedException();

            TekenDoolhof();
        }

        /// <summary>
        /// Deze methode "schudt" de elementen van een gegeven array in een willekeurige volgorde.
        /// De elementen van de array worden in-place gewisseld. 
        /// </summary>
        /// <param name="rng">Random number generator die gebruikt wordt om de array te schudden</param>
        /// <param name="array">De array waarvan de elementen moeten geschud worden</param>
        public static void Shuffle<T>(Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }


        /// <summary>
        /// Deze functie controleert of een geveven rij/kolom-positie binnen het doolhof ligt.
        /// </summary>
        /// <param name="rij">De rij-positie.</param>
        /// <param name="kolom">De kolom-positie.</param>
        /// <returns>Waar indien de rij/kolom-positie binnen het doolhof ligt.</returns>
        private bool LigtPositieInDoolhof(int rij, int kolom)
        {
            throw new NotImplementedException();
        }


        private void btnStartZoektocht_Click(object sender, EventArgs e)
        {
            EnableDisable(SpelStatus.ZoektochtGestart);

            StartZoektocht();
        }

        /// <summary>
        /// Deze methode maakt het systeem klaar om vertrekkende vanuit een ingang naar een uitgang te gaan.
        /// </summary>
        private void StartZoektocht()
        {
            //bepaal random coördinaten voor ingang en uitgang
            //laat speler bij ingang starten
            //teken beide cellen opnieuw
            throw new NotImplementedException();

        }

        /// <summary>
        /// Reset zoektocht instellingen
        /// </summary>
        private void ResetZoektocht()
        {
            //reset coördinaten van ingang, uitgang en speler naar -1
        }

        /// <summary>
        /// Procedure die uitgevoerd wordt als een van de beweeg-buttons geklikt wordt.
        /// Deze procedure probeert de 'speler' te bewegen in de gevraagde richting.
        /// </summary>
        /// <param name="sender">btnGaNoord of btnGaOost of btnGaZuid of btnGaWest of btnGaAutomatisch</param>
        /// <param name="e">Extra info over het event (niet interessant indien type EventArgs is).</param>
        private void btnBeweeg_Click(object sender, EventArgs e)
        {
            string buttonTekst = (sender as Button).Text;

            switch (buttonTekst)
            {
                case "N":
                    VerplaatsSpeler(Richting.Noord);
                    break;
                case "O":
                    VerplaatsSpeler(Richting.Oost);
                    break;
                case "Z":
                    VerplaatsSpeler(Richting.Zuid);
                    break;
                case "W":
                    VerplaatsSpeler(Richting.West);
                    break;
            }
        }

        /// <summary>
        /// Deze procedure reageert in het scherm op toetsen van het toetsenbord.
        /// Ze probeert de 'speler' te bewegen in de gevraagde richting.
        /// </summary>
        /// <param name="sender">De Form.</param>
        /// <param name="e">Extra info over het event (niet interessant indien type EventArgs is).</param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Als not niet aan de uitgang
            if (!UitgangGevonden())
            {
                bool toetsAfgehandeld = true;
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        VerplaatsSpeler(Richting.Noord);
                        break;
                    case Keys.Down:
                        VerplaatsSpeler(Richting.Zuid);
                        break;
                    case Keys.Left:
                        VerplaatsSpeler(Richting.West);
                        break;
                    case Keys.Right:
                        VerplaatsSpeler(Richting.Oost);
                        break;
                    default:
                        toetsAfgehandeld = false;
                        break;
                }
                // heeft deze routine de toets afgehandeld?
                e.Handled = toetsAfgehandeld;
            }
        }

        /// <summary>
        /// Probeer de speler te verplaatsen naar een andere cel in het doolhof.
        /// </summary>
        /// <param name="richting">De richting waar de speler naartoe wil gaan.</param>
        /// <returns>waar: als de verplaatsing gelukt is.</returns>
        private bool VerplaatsSpeler(Richting richting)
        {
            bool geldig = false;

            //controleer of gewenste verplaating geldig is
            //indien ja: voer verplaatsing uit
            //vergeet cellen niet te hertekenen!
            throw new NotImplementedException();

            if (UitgangGevonden())
                EnableDisable(SpelStatus.UitgangGevonden);

            return geldig;
        }



        /// <summary>
        /// Functie die aangeeft of de uitgang gevonden werd.
        /// </summary>
        /// <returns>Waar indien de uitgang gevonden werd.</returns>
        private bool UitgangGevonden()
        {
            //controleer of de speler de uitgang heeft gewonnen
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enable / disable controls & Reset zoektochtinstellingen
        /// </summary>
        /// <param name="deel"></param>
        private void EnableDisable(SpelStatus status)
        {
            switch (status)
            {
                case SpelStatus.Initieel:
                    nudAantalRijen.Enabled =
                        nudAantalKolommen.Enabled =
                        btnCreëer.Enabled = true;
                    btnInitialiseer.Enabled =
                        btnGenereer.Enabled =
                        btnStartZoektocht.Enabled =
                        btnGaNoord.Enabled =
                        btnGaOost.Enabled =
                        btnGaZuid.Enabled =
                        btnGaWest.Enabled =
                        nudPauze.Enabled = false;
                    ResetZoektocht();
                    break;
                case SpelStatus.DimensiesGewijzigd:
                    btnCreëer.Enabled = true;
                    btnInitialiseer.Enabled =
                        btnGenereer.Enabled =
                        btnStartZoektocht.Enabled =
                        btnGaNoord.Enabled =
                        btnGaOost.Enabled =
                        btnGaZuid.Enabled =
                        btnGaWest.Enabled =
                        nudPauze.Enabled = false;
                    ResetZoektocht();
                    break;
                case SpelStatus.Gecreëerd:
                    btnCreëer.Enabled = false;
                    btnInitialiseer.Enabled = true;
                    ResetZoektocht();
                    break;
                case SpelStatus.Geïnitialiseerd:
                    nudPauze.Enabled =
                        btnGenereer.Enabled = true;
                    btnStartZoektocht.Enabled =
                        btnGaNoord.Enabled =
                        btnGaOost.Enabled =
                        btnGaZuid.Enabled =
                        btnGaWest.Enabled = false;
                    ResetZoektocht();
                    break;
                case SpelStatus.Gegenereerd:
                    btnStartZoektocht.Enabled = true;
                    btnGenereer.Enabled =
                        btnGaNoord.Enabled =
                        btnGaOost.Enabled =
                        btnGaZuid.Enabled =
                        btnGaWest.Enabled = false;
                    ResetZoektocht();
                    break;
                case SpelStatus.ZoektochtGestart:
                    btnStartZoektocht.Enabled = false;
                    btnGaNoord.Enabled =
                        btnGaOost.Enabled =
                        btnGaZuid.Enabled =
                        btnGaWest.Enabled = true;
                    ResetZoektocht();
                    break;
                case SpelStatus.UitgangGevonden:
                    btnGaNoord.Enabled =
                        btnGaOost.Enabled =
                        btnGaZuid.Enabled =
                        btnGaWest.Enabled =
                        nudPauze.Enabled = false;
                    ResetZoektocht();
                    break;
            }
        }

        #region Teken methoden

        /// <summary>
        /// Teken het volledige doolhof in de PictureBox
        /// </summary>
        /// <param name="graphics">De graphics van de PictureBox.</param>
        private void TekenDoolhof(Graphics graphics = null)
        {
            if (/* als het doolhof geïnitialiseerd is */)
            {
                if (graphics == null)
                    graphics = picDoolhof.CreateGraphics();

                graphics.Clear(picDoolhof.BackColor);

                // overloop alle cellen in het doolhoof
                // voor elke cel: roep TekenCel-methode aan

                graphics.Dispose();
            }
        }

        /// <summary>
        /// Teken 1 cel in de PictureBox
        /// </summary>
        /// <param name="rij">De rijpositie van de cel.</param>
        /// <param name="kolom">De kolompositie van de cel.</param>
        /// <param name="graphics">De graphics van de PictureBox.</param>
        /// <param name="pauze">Geeft aan hoeveel milliseconden moet gepauzeerd worden. 0 = geen pauze</param>
        private void TekenCel(int rij, int kolom, Graphics graphics = null, Decimal pauze = 0)
        {
            int celGrootte = Math.Min((picDoolhof.Width - 1) / (/* aantal kolommen */), (picDoolhof.Height - 1) / (/* aantal rijen */));
            int x1 = kolom * celGrootte;
            int y1 = rij * celGrootte;

            if (graphics == null)
            {
                graphics = picDoolhof.CreateGraphics();
            }

            Brush vulKleur;

            if ((rij == _rijIngang && kolom == _kolomIngang) || (rij == _rijUitgang && kolom == _kolomUitgang))
            {
                vulKleur = Brushes.LightGreen;
            }
            else if (/* is cel bezocht? */)
            {
                vulKleur = Brushes.LimeGreen;
            }
            else
            {
                vulKleur = Brushes.LightCoral;
            }

            Pen muurKleur = Pens.Black;

            graphics.FillRectangle(
                vulKleur,
                x1,
                y1,
                celGrootte,
                celGrootte
                );

            if (/* als geen enkele muur gesloopt is */)
            {
                graphics.DrawRectangle(
                    muurKleur,
                    x1,
                    y1,
                    celGrootte,
                    celGrootte
                    );
            }
            else
            {
                if (/* indien muur in het noorden */)
                    graphics.DrawLine(muurKleur, x1, y1, x1 + celGrootte - 1, y1);
                if (/* indien muur in het zuiden */)
                    graphics.DrawLine(muurKleur, x1, y1 + celGrootte - 1, x1 + celGrootte - 1, y1 + celGrootte - 1);
                if (/* indien muur in het oosten */)
                    graphics.DrawLine(muurKleur, x1 + celGrootte - 1, y1, x1 + celGrootte - 1, y1 + celGrootte - 1);
                if (/* indien muur in het westen */)
                    graphics.DrawLine(muurKleur, x1, y1, x1, y1 + celGrootte - 1);
            }

            //Toon vakje van speler in een andere kleur
            if (rij == _rijSpeler && kolom == _kolomSpeler)
            {
                int celMarge = celGrootte / 5;
                graphics.FillRectangle(
                    rij == _rijUitgang && kolom == _kolomUitgang ? Brushes.Gold : Brushes.GhostWhite,
                    x1 + celMarge,
                    y1 + celMarge,
                    celGrootte - celMarge * 2,
                    celGrootte - celMarge * 2
                    );
            }
            Thread.Sleep((int)pauze);
        }

        #endregion
    }
}
