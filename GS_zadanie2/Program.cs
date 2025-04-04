using RegonAPI.GUS;
using System;
using System.Windows.Forms;

namespace RegonAPI
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var searchService = new Services.BusinessSearchService(new UslugaBIRzewnPublClient());
            Application.Run(new BIR1(searchService));
        }
    }
}
