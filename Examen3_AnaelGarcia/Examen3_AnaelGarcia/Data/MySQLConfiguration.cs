namespace Examen3_AnaelGarcia.Data
{
    public class MySQLConfiguration
    {
        public string CadenaConexion { get; }

        public MySQLConfiguration(string codenaConexion)
        {
            CadenaConexion = codenaConexion;
        }

    }
}
