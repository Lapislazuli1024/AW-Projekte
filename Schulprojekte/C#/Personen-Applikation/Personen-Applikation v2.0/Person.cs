using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personen_Applikation_v2._0
{
   [Serializable()]
    public class Person
    {
        //Membervariablen
        private int m_EintrittsJahr;
        private double m_Salaer;
        private int m_PersNr;

        //Konstanten
        private const int min_Eintrittsjahr = 1975;
        private const double max_Salaer = 99999.95;

        //Statische Eigenschaften
        private static int sAnzahlPersonen = 0;

        public Person()
        {
            PersNr = ++sAnzahlPersonen;
            Anrede = "Frau";
            Name = "Neue Person";
            Vorname = "";
            Plz = "6000";
            Ort = "Luzern";
            EintrittsJahr = DateTime.Now.Year;
            Salaer = 5000.0;
            Pensum = 100.0;
        }

        public Person(string anrede, string name, string vorname)
        {
            PersNr = ++sAnzahlPersonen;
            Anrede = anrede;
            Name = name;
            Vorname = vorname;

        }

        public Person(string name, string vorname, int eintrittsJahr)
        {
            PersNr = ++sAnzahlPersonen;
            Name = name;
            Vorname = vorname;
            EintrittsJahr = eintrittsJahr;

        }

        //Get-Setter
        public int PersNr
        {
            get
            {
                return m_PersNr;
            }
            private set
            {
                m_PersNr = value;
            }
        }

        public double Salaer
        {
            get { return m_Salaer; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                    MessageBox.Show("Sie haben ein ungültiges Salaer eingegeben:\n" +
                       "Das mindest Salaer ist 0\n" +
                       "Das Salaer wurde auf 0 gesetzt!", "Ungültiges Salaer");
                }
                else if (value > max_Salaer)
                {
                    value = max_Salaer;
                    MessageBox.Show("Sie haben ein ungültiges Salaer eingegeben:\n" +
                       "Das maximale Salaer ist 99999.95\n" +
                       "Das Salaer wurde auf 99999.95 gesetzt!", "Ungültiges Salaer");
                }
                m_Salaer = value;
            }
        }
        public int EintrittsJahr
        {
            get { return m_EintrittsJahr; }
            set
            {
                if (value < min_Eintrittsjahr)
                {
                    value = min_Eintrittsjahr;
                    MessageBox.Show("Sie haben ein ungültiges Datum eingegben!" +
                       "\nDas minimale Datum ist 1975" +
                       "\nDas Eintrittsjahr wurde auf 1975 gesetzt.");
                }
                else if (value > DateTime.Now.Year)
                {
                    value = DateTime.Now.Year;
                    MessageBox.Show("Sie haben ein ungültiges Datum eingegben!" +
                       "\nDas maximale Datum ist " + DateTime.Now.Year +
                       "\nDas Eintrittsjahr wurde auf " + DateTime.Now.Year + " gesetzt.");
                }
                m_EintrittsJahr = value;
            }

        }

        public string Anrede
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public string Vorname
        {
            get;
            set;
        }

        public string Plz
        {
            get;
            set;
        }

        public string Ort
        {
            get;
            set;
        }

        public double Pensum
        {
            get;
            set;
        }

        //Funktionen
        public double CalculateLohn()
        {
            return Salaer * Pensum / 100;
        }



        //Statische Funktionen
        public static double CalculateLohn(double salaer, double pensum)
        {
            return salaer * pensum / 100;
        }

    }
}
