using WFPLAY.Services;

namespace WFPLAY
{
    public partial class MainForm : Form
    {
        public FileService _service;

        public MainForm(FileService service)
        {
            _service = service;

            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            progBar.Visible = false;

            toolTipDesc.AutoPopDelay = 5000;
            toolTipDesc.InitialDelay = 500;
            toolTipDesc.ReshowDelay = 200;
            toolTipDesc.ShowAlways = true;

            toolTipDesc.SetToolTip(btnImport, "Arquivos suportados (*.webm;*.mp4;*.mkv;*.avi)");
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            string inputFile = _service.SelectFile();
            if (string.IsNullOrEmpty(inputFile)) return;

            string outputFile = _service.outputPath(inputFile);

            try
            {
                btnImport.Enabled = false;
                progBar.Visible = true;

                await _service.ConvertFileAsync(inputFile, outputFile);

                MessageBox.Show($"Arquivo convertido com sucesso!\nSalvo em: {outputFile}",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao converter arquivo: " + ex.Message,
                                "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                btnImport.Enabled = true;
                progBar.Visible = false;
            }
        }
    }
}
