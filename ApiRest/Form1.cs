using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApiRest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DBApi datos = new DBApi();
                dynamic resultados = datos.Get("https://api.nasa.gov/planetary/earth/assets?lon=" + tbLongitud.Text + "&lat=" + tbLatitud.Text + "&date=2018-01-01&&dim=0.10&api_key=hzk4Tt8dm0wsur8fdFFf8W7o8IAfzn6l2KnxTnwy");
                pbImagen.ImageLocation = resultados.url;
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
