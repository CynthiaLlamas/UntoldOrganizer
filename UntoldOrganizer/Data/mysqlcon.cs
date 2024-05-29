using MySql.Data.MySqlClient;

public class SQLConnection {
    MySqlConnection conn;
    string connString = "server=127.0.0.1;uid=root;"+"pwd=root;database=untoldadventures";
    public void addCharacter(Character character){
        string characterId = Guid.NewGuid().ToString();

        try {
            conn = new MySqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            string sql = $"INSERT characterId, name, role, motivation, iconicRole INTO 'untoldadventures'.'character' VALUES ({characterId},{character.name},{character.role}, {character.motivation}, {character.iconicRole})";
            MySqlCommand command = new MySqlCommand(sql,conn);
            
        }catch(MySqlException exc){
            System.Console.WriteLine(exc.Message);
        }
        
    }
}