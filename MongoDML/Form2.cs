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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var configHelper = ConfigHelper.GetInstance();
            ucVField1.FieldContent = configHelper.Get("host");
            ucVField2.FieldContent = configHelper.Get("port");
            ucVField3.FieldContent = configHelper.Get("database");
            ucVField4.FieldContent = configHelper.Get("collection");

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
                var database = ucVField3.FieldContent;
                var collection = ucVField4.FieldContent;
                var record = xTextBox1.Text;
                MongoHelper.InsertOne(host, port, database, collection, record);
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
                var record = new GPSEntry()
                {
                    v = veic.Prefixo,
                    dtg = dtHr,
                    dtl = dtHr,
                    dtp = dtHr,
                    l = new LocationEntry() { t = "Point", c = new[] { lat, lng } },
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
                };
                xTextBox1.Text = JsonConvert.SerializeObject(record);
            }
            else
            {
                xTextBox1.Text = string.Empty;
            }
        }
    }
}
