namespace CapsLang.Service
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.capsLangProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.capsLangInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // capsLangProcessInstaller
            // 
            this.capsLangProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.capsLangProcessInstaller.Password = null;
            this.capsLangProcessInstaller.Username = null;
            // 
            // capsLangInstaller
            // 
            this.capsLangInstaller.Description = "This is a simple tool for switch language by CapsLock button.";
            this.capsLangInstaller.DisplayName = "CapsLang";
            this.capsLangInstaller.ServiceName = "CapsLang";
            this.capsLangInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.capsLangProcessInstaller,
            this.capsLangInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller capsLangProcessInstaller;
        private System.ServiceProcess.ServiceInstaller capsLangInstaller;
    }
}