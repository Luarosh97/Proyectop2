using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;
using Entity;


namespace VeterinariaGUI
{    
    public partial class MenuMascotasFrm : Form
    {


        MascotaService mascotaService;
        ResponseConsultaMascota respuestaconsulta;
        string TotalPerros;
        string TotalGatos;
        string TotalLoros;
        string Total;
    
        public MenuMascotasFrm()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["ConnectionRochety"].ConnectionString;
            mascotaService = new MascotaService(connectionString);
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AgregarMascotaBtn_Click(object sender, EventArgs e)
        {
            RegistroMascotaFrm registroMascotaFrm = new RegistroMascotaFrm();
            registroMascotaFrm.Show();
        }

        private void MinimizarBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscarMascotaBtn_Click(object sender, EventArgs e)
        {
            MascotaDtg.DataSource = null;
            respuestaconsulta = mascotaService.Consultar();
            Total = mascotaService.Totalizar().Cuenta.ToString();
            TotalPerros = mascotaService.TotalizarTipo("Perro").Cuenta.ToString();
            TotalGatos = mascotaService.TotalizarTipo("Gato").Cuenta.ToString();
            TotalLoros= mascotaService.TotalizarTipo("Loro").Cuenta.ToString();

            consultar();
        }

        private void consultar()
        {
            if (Mascotacmb.SelectedIndex == 0)
            {
                MascotaDtg.DataSource = respuestaconsulta.mascotas;
            }
            else if (Mascotacmb.SelectedIndex==1) {
                MascotaDtg.DataSource = mascotaService.ConsultarPerros();
                TotalPerros = mascotaService.TotalizarTipo("Perro").Cuenta.ToString();
                TotalGatos = "0";
                TotalLoros = "0";
                Total = TotalPerros;

            }
            else if (Mascotacmb.SelectedIndex==2) {
                MascotaDtg.DataSource = mascotaService.ConsultarLoros();
                TotalLoros = mascotaService.TotalizarTipo("Loro").Cuenta.ToString();
                TotalGatos = "0";
                TotalPerros = "0";
                Total = TotalLoros;

            }
            else if (Mascotacmb.SelectedIndex==3) {
                MascotaDtg.DataSource = mascotaService.ConsultarGatos();
                TotalGatos= mascotaService.TotalizarTipo("Gato").Cuenta.ToString();
                TotalPerros = "0";
                TotalLoros = "0";
                Total = TotalGatos;

            }
            Llenar();
        }

        private void Llenar()
        {
            TotalPerrostxt.Text = TotalPerros;
            TotalLorostxt.Text = TotalLoros;
            TotalGatostxt.Text = TotalGatos;
            totaltxt.Text = Total;
        }

        private void MascotaDtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
