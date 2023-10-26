using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ARAS_Click(object sender, EventArgs e)
        {
            WEB.GoBack();

        }

        private void ADELANTE_Click(object sender, EventArgs e)
        {
            WEB.GoForward();
        }

        private void PARAR_Click(object sender, EventArgs e)
        {
            WEB.Stop();
        }

        private void ACTUALIZAR_Click(object sender, EventArgs e)
        {
            WEB.Refresh();

        }

        private void INICIO_Click(object sender, EventArgs e)
        {
            WEB.Navigate("www.google.com.pe");

        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            WEB.Navigate(DIRECCION.Text);

        }

        private void WEB_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WEB.ScriptErrorsSuppressed = true;
        }
    }
}
