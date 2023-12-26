using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDiscos
{
    public partial class Cancionero : Form
    {
        private List<Disco> listaDisco;
        public Cancionero()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            DiscosNegocio Negocio = new DiscosNegocio();
            listaDisco = Negocio.listar();
            dgvDiscos.DataSource = listaDisco;
            ocultarColumnas();
            cargarImagen(listaDisco[0].UrlImagenTapa);

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAlbum.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxAlbum.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
        private void ocultarColumnas()
        {
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagenTapa);
            }
        }
    }
}
