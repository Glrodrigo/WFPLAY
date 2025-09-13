using WFPLAY.Services;

namespace WFPLAY
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            FileService service = new FileService();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm(service));
        }
    }
}