using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessFollowerApp
{
    class ChessApplicationContext : ApplicationContext
    {
        // Singleton ApplicationContext
        private static ChessApplicationContext context;

        /// <summary>
        /// Private constructor for singleton pattern
        /// </summary>
        private ChessApplicationContext()
        {
        }

        /// <summary>
        /// Returns the one DemoApplicationContext.
        /// </summary>
        public static ChessApplicationContext GetContext()
        {
            if (context == null)
            {
                context = new ChessApplicationContext();
            }
            return context;
        }

        /// <summary>
        /// Runs a form in this application context
        /// </summary>
        public void RunNew()
        {
            // Create the window and the controller
            ChessForm window = new ChessForm();
            new Controller(window);

            // Run the form
            window.Show();
        }
    }
}
