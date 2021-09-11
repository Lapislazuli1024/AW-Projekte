using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personen_Applikation_v2._0
{
    public partial class FormNeu : Form
    {
        public FormNeu()
        {
            InitializeComponent();
        }

        //Membervariablen
        private Person m_NeuePerson = null;


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }

        private void tbn_Save_Click(object sender, EventArgs e)
        {

            m_NeuePerson = new Person();
            m_NeuePerson.Name = tbx_Namen.Text;
            m_NeuePerson.Vorname = tbx_Vornamen.Text;
            DialogResult = DialogResult.OK;
        }

        public Person getNeuePerson()
        {
            return m_NeuePerson;
        }
    }
}
