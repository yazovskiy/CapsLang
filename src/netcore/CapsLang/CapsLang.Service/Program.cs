using System.ServiceProcess;

namespace CapsLang.Service
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new CapsLangService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
