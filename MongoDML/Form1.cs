using MongoDML.Components;
using MongoDML.Core.Helpers;
using System;
using System.Windows.Forms;

namespace MongoDML
{
    public partial class Form1 : XForm
    {
        public Form1()
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
                MongoHelper.InsertSGO(host, port, database, collection, record);
                MessageBox.Show("Operação concluída com sucesso", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
