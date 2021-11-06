using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using WarehouseRemittance.App.Forms;
using WarehouseRemittance.App.Forms.Settings;

namespace WarehouseRemittance.App
{
    static class Program
    {
        public static ServiceProvider ServiceProvider;
        /// <summary>
        ///  The main entry point for the application.
        ///  Comment by Sajad
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            
            services.AddScoped<Form1>();
            services.AddScoped<frmProduct>();
            services.AddScoped<frmUsers>();
            services.AddScoped<frmProductGroups>();
            services.AddScoped<Settings>();
            
            IoC.Container container = new IoC.Container();            
            ServiceProvider = container.Register(services);


            
            Application.Run(ServiceProvider.GetService<Form1>());

            //Application.Run(new Form1());
        }
    }
}
