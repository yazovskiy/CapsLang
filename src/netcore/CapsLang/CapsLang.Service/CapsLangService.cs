using System.ServiceProcess;
using System.Windows.Forms;

namespace CapsLang.Service
{
    public partial class CapsLangService : ServiceBase
    {
        public CapsLangService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //MessageBox.Show("start");
            LangSwitcher.LangSwitcher.Run();
        }

        protected override void OnStop()
        {
            LangSwitcher.LangSwitcher.Release();
        }
    }
}
