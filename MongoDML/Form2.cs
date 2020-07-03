using MongoDML.Components;
using MongoDML.Core;
using MongoDML.Core.Helpers;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;

namespace MongoDML
{
    public partial class Form2 : XForm
    {
        GPSEntry gpsEntry = null;
        AsmontecEntry asmontecEntry = null;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var configHelper = ConfigHelper.GetInstance();
            ucVField1.FieldContent = configHelper.Get("host");
            ucVField2.FieldContent = configHelper.Get("port");
            ucVField3.FieldContent = string.Format("Empresa_1_{0}", DateTime.Today.ToString("yyyyMM")); //configHelper.Get("database");
            ucVField4.FieldContent = string.Format("dia_{0}", DateTime.Today.ToString("dd")); //configHelper.Get("collection");
            xCheckBox1.Checked = bool.Parse(configHelper.Get("askConfirmation"));

            var veiculos = Veiculo.GetAll();
            xComboBox1.ValueMember = "Id";
            xComboBox1.DisplayMember = "Prefixo";
            xComboBox1.DataSource = veiculos;

            var cercas = Cerca.GetAll();
            xComboBox2.ValueMember = "Id";
            xComboBox2.DisplayMember = "Descricao";
            xComboBox2.DataSource = cercas;
            
            xDateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (xCheckBox1.Checked && MessageBox.Show("Confirma a operação?", "Adicionar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }

                var host = ucVField1.FieldContent;
                var port = int.Parse(ucVField2.FieldContent);
                var dbSGO = ucVField3.FieldContent;
                var colSGO = ucVField4.FieldContent;
                var dbAsmontec = dbSGO.Replace("Empresa_1", "gpsreal");
                var colAsmontec = colSGO.Replace("dia", "gps");
                MongoHelper.InsertSGO(host, port, dbSGO, colSGO, JsonConvert.SerializeObject(gpsEntry));
                MongoHelper.InsertAsmontec(host, port, dbAsmontec, colAsmontec, JsonConvert.SerializeObject(asmontecEntry));
                MessageBox.Show("Operação concluída com sucesso", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void xComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void xComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cerc = (Cerca)xComboBox2.SelectedItem;
            if (cerc.Tipo == "GARAGEM")
            {
                xTextBox2.Text = cerc.LatitudeGaragem?.ToString();
                xTextBox3.Text = cerc.LongitudeGaragem?.ToString();
            }
            RefreshPreview();
        }

        private void xRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void xRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void xDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void xTextBox2_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void xTextBox3_TextChanged(object sender, EventArgs e)
        {
            RefreshPreview();
        }

        private void RefreshPreview()
        {
            var veic = (Veiculo)xComboBox1.SelectedItem;
            var cerc = (Cerca)xComboBox2.SelectedItem;
            var cLat = double.TryParse(xTextBox2.Text, out double lat);
            var cLng = double.TryParse(xTextBox3.Text, out double lng);
            if (veic != null && cerc != null && cLat && cLng)
            {
                var dtHr = xDateTimePicker1.Value.ToUniversalTime();
                gpsEntry = new GPSEntry()
                {
                    v = veic.Prefixo,
                    dtg = dtHr,
                    dtl = dtHr,
                    dtp = dtHr,
                    l = new LocationEntry() { t = "Point", c = new[] { lat, lng } },
                    /*
                    pcs = new[]
                    {
                        new PassagemCercaEntry()
                        {
                            _id = cerc.Id,
                            d = cerc.Descricao,
                            tc = cerc.Tipo,
                            te = xRadioButton1.Checked ? "E" : "S"
                        }
                    }.ToList()
                    */
                };
                asmontecEntry = new AsmontecEntry()
                {
                    _id = gpsEntry._id,
                    tid = veic.IdentificacaoGPS,
                    tm = dtHr,
                    stm = dtHr,
                    gps = new[] { lat, lng }
                };
                xTextBox1.Text = JsonConvert.SerializeObject(gpsEntry);
            }
            else
            {
                xTextBox1.Text = string.Empty;
            }
        }
    }
}
