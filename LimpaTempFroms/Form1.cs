using System;
using System.Drawing;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace LimpaTempFroms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AtualTempFiles();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.Delete(LocalDatas.TempDirectory(), true);
            }
            catch (UnauthorizedAccessException)
            {
                labelStatus.ForeColor = Color.Green;
                labelStatus.Text = "TOTALMENTE LIMPO";
            }
            catch (System.IO.IOException exc)
            {
                labelStatus.ForeColor = Color.Blue;
                labelStatus.Text = "LIMPO";
            }
            catch(Exception exc)
            {
                labelStatus.ForeColor = Color.Red;
                labelStatus.Text = "FALHA";
            }

            FormMain_Load(sender,e);
        }

        private void AtualTempFiles()
        {
            labelQtdTempFiles.Text = LocalDatas.QtdTempFiles().ToString();
        }
    }
}
