using System;
using System.Windows.Forms;
using FacebookWrapper;

// $G$ THE-001 (-13) Your grade on diagrams document is - 87. Please see comments inside the document. (40% of your grade).
// $G$ CSS-999 (-5) Coding Standards errors.

namespace BasicFacebookFeatures
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
