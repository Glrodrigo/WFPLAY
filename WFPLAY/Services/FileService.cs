using System.Diagnostics;

namespace WFPLAY.Services;

public sealed class FileService
{
    private readonly OpenFileDialog _openFileDialog;

    public FileService()
    {
        _openFileDialog = new OpenFileDialog();
    }

    public string SelectFile()
    {
        _openFileDialog.Filter = "Arquivos de Vídeo (*.webm;*.mp4;*.mkv;*.avi)|*.webm;*.mp4;*.mkv;*.avi";
        _openFileDialog.Title = "Selecione um arquivo .webm";

        if (_openFileDialog.ShowDialog() == DialogResult.OK)
            return _openFileDialog.FileName;

        return string.Empty;
    }

    public string outputPath(string inputFile)
    {
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        return Path.Combine(desktopPath, Path.GetFileNameWithoutExtension(inputFile) + ".mp3");
    }

    public Task ConvertFileAsync(string inputFile, string outputFile)
    {
        return Task.Run(() =>
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = $"-i \"{inputFile}\" -vn -ar 44100 -ac 2 -b:a 192k \"{outputFile}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process())
            {
                process.StartInfo = psi;
                process.Start();
                process.WaitForExit();
            }
        });
    }
}
