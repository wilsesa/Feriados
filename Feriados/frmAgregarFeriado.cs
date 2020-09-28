using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Feriados.ENT;
using Feriados.DAL;
using Feriados.NEG;

namespace Feriados
{
    public partial class frmAgregarFeriado : Form
    {
        NTipo nTipo             = new NTipo();
        NPais nPais             = new NPais();
        NEstado nEstado         = new NEstado();
        NMunicipio nMunicipio   = new NMunicipio();

        NFeriado nFer = new NFeriado();
        EFeriado eFer = new EFeriado();

        public frmAgregarFeriado()
        {
            InitializeComponent();
        }

        private void AgregarFeriado_Load(object sender, EventArgs e)
        {
            cargarTipo();
        }

        public void cargarTipo()
        {
            cbxTipo.DisplayMember = "tipoNome";
            cbxTipo.ValueMember = "IdTipo";
            cbxTipo.DataSource = nTipo.listarTipo();
        }

        public void cargarPais(int tipId)
        {
            cbxPais.DisplayMember = "paisNome";
            cbxPais.ValueMember = "IdPais";
            cbxPais.DataSource = nPais.listarPais(tipId);
        }

        public void cargarEstado(int estId)
        {
            cbxEstado.DisplayMember = "estadoNome";
            cbxEstado.ValueMember = "IdEstado";
            cbxEstado.DataSource = nEstado.listarEstado(estId);
        }

        public void cargarMunicipio(int munId)
        {
            cbxMunicipio.DisplayMember = "municipioNome";
            cbxMunicipio.ValueMember = "IdMunicipio";
            cbxMunicipio.DataSource = nMunicipio.listarMunicipio(munId);
        }
        string tipId;
        string paiId;
        string estId;
        string munId;

        int tiId, paId, esId, muId;

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipId = cbxTipo.SelectedValue.ToString();
            tiId = Convert  .ToInt32(tipId);
            cargarTipo();
        }
        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            paiId = cbxPais.SelectedValue.ToString();
            paId = Convert.ToInt32(paiId);
            cargarEstado(paId);
        }
        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            estId = cbxEstado.SelectedValue.ToString();
            esId = Convert.ToInt32(estId);
            cargarMunicipio(esId);
        }
        private void cbxMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            munId = cbxMunicipio.SelectedValue.ToString();
            muId = Convert.ToInt32(munId);

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            eFer.FerData = dtpData.Text;
            eFer.FerDataCad = dtpDCadastro.Text;

            int resultado = nFer.registrarFeriado(eFer);
            if(resultado > 0)
            {
                MessageBox.Show("datos guardados correctamente", "Datos Feriados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCajas();
            }
        }
        public void limpiarCajas()
        {
            dtpData.Text = "";
            dtpDCadastro.Text = "";
        }
    }
}
