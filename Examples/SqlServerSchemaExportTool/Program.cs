namespace SqlServerSchemaExportTool
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add loggin
            // Send email
            // Zip Path
            var exportScripts = new ExportScripts();
            exportScripts.CreateScriptDataBase();
        }
    }
}