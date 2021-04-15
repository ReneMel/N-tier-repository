using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Program.Negocio;
using Tulpep.NotificationWindow;

namespace Program.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            refreshdata();
        }

        private void refreshdata() {
            BindingSource bs = new BindingSource();
            Npersona np = new Npersona();

            bs.DataSource = np.Listar();
            UserDataView.ReadOnly = true;
            UserDataView.DataSource = bs;
        }



        private void PersonForm_Load (Object sender, EventArgs e) {
            refreshdata();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

            Npersona np = new Negocio.Npersona();

            string res =np.insertarData(NombreBox.Text, ApellidoBox.Text, Convert.ToInt32(EdadBox.Text), TelBox.Text);
            refreshdata();

            PopupNotifier popup = new PopupNotifier();
            popup.TitleText = "Exito";

            if (res == "Insertado con Exito")
            {
                popup.TitleText = "Exito";
                popup.ContentText = res;
                popup.Popup();
            }
            else {
                popup.TitleText = "Error";
                popup.ContentText = res;
                popup.Popup();
            }
            
         
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
