namespace server.Database;

using System.Data.SQLite;
using server.Models;

public class Database {
  
  static string connectionString = "Data Source=../../MyDatabase.sqlite;Version=3;";

  public List<BlockchainMessage> select() {
    SQLiteConnection conn = new SQLiteConnection(connectionString);
    conn.Open();

    string sql = "select * from blockMessage order by blockHeight desc";
    SQLiteCommand command = new SQLiteCommand(sql, conn);
    SQLiteDataReader reader = command.ExecuteReader();
    List<BlockchainMessage> messages = new List<BlockchainMessage>();
    Console.WriteLine("blockMessage table:");
    while (reader.Read()) {
      long blockHeight = (long) reader["blockHeight"];
      string transactionId = (string) reader["transactionId"];
      string message = (string) reader["message"];
      Console.WriteLine("------------------------------------------------------------------");
      Console.WriteLine($"blockHeight: {blockHeight} \ntransactionId: {transactionId} \nmessage: {message}");
      messages.Add(new BlockchainMessage(blockHeight, transactionId, message));
    }

    conn.Close();
    return messages;
  }
}