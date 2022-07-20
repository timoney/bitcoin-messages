namespace server.Models;

public class BlockchainMessage {
  public long blockHeight { get; set; }
  public string transactionId { get; set; }
  public string message { get; set; }

  public BlockchainMessage(long blockHeight, string transactionId, string message) {
    this.blockHeight = blockHeight;
    this.transactionId = transactionId;
    this.message = message;
  }
}