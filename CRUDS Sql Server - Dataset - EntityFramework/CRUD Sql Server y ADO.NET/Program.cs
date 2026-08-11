namespace CRUD_Sql_Server_y_ADO.NET
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmFormularioPrincipal());
        }
    }
}