namespace CyberBot
{
    static class DbConfig
    {
        private const string Server   = "localhost";
        private const string Port     = "3306";
        private const string Database = "cyberbot_db";
        private const string UserId   = "root";
        private const string Password = "Thabang07!";

        public static string ConnectionString =>
            $"Server={Server};Port={Port};Database={Database};Uid={UserId};Pwd={Password};";
    }
}
