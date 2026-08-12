namespace CRUD_Sql_Server_y_Entity_Framework
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