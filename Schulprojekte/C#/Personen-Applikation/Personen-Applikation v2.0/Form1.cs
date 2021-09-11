using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personen_Applikation_v2._0
{
	public partial class Personen_Applikation : Form
	{
		public Personen_Applikation()
		{
			InitializeComponent();
		}
		//Variablen
		List<Person> m_Personen = new List<Person>();
		private int m_Position = 0;


		private void Personen_Applikation_Load(object sender, EventArgs e)
		{
			Einlesen();
			m_Position = 1;
			FillForm();
		}

		private void Personen_Applikation_FormClosed(object sender, FormClosedEventArgs e)
		{
			string sPfad = Application.StartupPath + "\\MyObject.pd7";
			DialogResult result = MessageBox.Show("Möchte Sie die Daten im Applikationsverzeichnis speichern?", "Speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (DialogResult.No == result)
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "pd7 files (*.pd7)|*.pd7|All files(*.*)|*";
				sfd.DefaultExt = "pd7";
				if (DialogResult.OK == sfd.ShowDialog())
					sPfad = sfd.FileName;
				else
					return;
			}
			FileStream myStream = new FileStream(sPfad, FileMode.Create);
			BinaryFormatter binFormatter = new BinaryFormatter();
			binFormatter.Serialize(myStream, m_Personen);
			myStream.Close();


		}

		//Navigation
		private void btn_OnFirst_Click(object sender, EventArgs e)
		{
			m_Position = 1;
			FillForm();
		}

		private void btn_Previous_Click(object sender, EventArgs e)
		{
			if (m_Position > 1)
			{
				m_Position--;
				FillForm();
			}
		}

		private void btn_OnNext_Click(object sender, EventArgs e)
		{
			if (m_Position < m_Personen.Count)
			{
				m_Position++;
				FillForm();
			}
		}

		private void btn_OnLast_Click(object sender, EventArgs e)
		{
			m_Position = m_Personen.Count;
			FillForm();
		}


		//Hinzufügen Entfernen
		private void btn_Plus_Click(object sender, EventArgs e)
		{
			FormNeu f = new FormNeu();
			f.ShowDialog();
			if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				Person p = f.getNeuePerson();
				m_Personen.Add(p);
				btn_OnLast_Click(this, null);
			}
		}

		private void btn_Minus_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Sind sie sicher, dass sie diesen Datensatz löschen möchten?", "Löschung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				m_Personen.RemoveAt(m_Position - 1);
				if (m_Position > m_Personen.Count)
					m_Position--;
				FillForm();
			}
		}

		//Form ausfüllen

		private void FillForm()
		{
			tbx_Anzahl.Text = Convert.ToString(m_Position) + "/" + Convert.ToString(m_Personen.Count);
			if (m_Personen.Count == 0)
				return;
			Person p = m_Personen[m_Position - 1];
			tbx_PNr.Text = Convert.ToString(p.PersNr);
			tbx_Namen.Text = p.Name;
			tbx_Vornamen.Text = p.Vorname;
			tbx_Plz.Text = p.Plz;
			tbx_Ort.Text = p.Ort;
			tbx_Eintrittsjahr.Text = Convert.ToString(p.EintrittsJahr);
			tbx_Salaer.Text = Convert.ToString(p.Salaer);
			tbx_Pensum.Text = Convert.ToString(p.Pensum);
		}

		private void btn_DiscardChanges_Click(object sender, EventArgs e)
		{
			FillForm();
		}

		private void btn_SaveChanges_Click(object sender, EventArgs e)
		{
			Person p = m_Personen[m_Position - 1];
			p.Name = tbx_Namen.Text;
			p.Vorname = tbx_Vornamen.Text;
			p.Plz = tbx_Plz.Text;
			p.Ort = tbx_Ort.Text;
			p.EintrittsJahr = Convert.ToInt32(tbx_Eintrittsjahr.Text);
			p.Salaer = Convert.ToDouble(tbx_Salaer.Text);
			p.Pensum = Convert.ToDouble(tbx_Pensum.Text);

			FillForm();
		}

		private void Einlesen()
		{

			DialogResult result = MessageBox.Show("Möchten sie Daten aus einer Datei laden?", "Laden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.No)
			{
				for (int i = 1; i <= 3; i++)
				{
					Person p = new Person();
					p.Name = ("Neue Person (" + Convert.ToString(i) + ")");
					m_Personen.Add(p);
				}
			}
			else
			{
				string sPfad = Application.StartupPath + "\\MyObject.pd7";
				result = MessageBox.Show("Möchten Sie die Datei im Applikationsverzeichnis lesen?", "Informationen einlesen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.No == result)
				{
					OpenFileDialog ofd = new OpenFileDialog();
					ofd.Filter = "pd7 files (*.pd7)|*.pd7|All files(*.*)|*";
					if (DialogResult.OK == ofd.ShowDialog())
					{
						sPfad = ofd.FileName;
					}
					else
						return;
				}


				try
				{
					FileStream myStream = new FileStream(sPfad, FileMode.Open);
					BinaryFormatter binFormatter = new BinaryFormatter();
					m_Personen = (List<Person>)binFormatter.Deserialize(myStream);
					myStream.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
