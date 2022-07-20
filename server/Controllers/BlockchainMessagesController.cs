namespace server.Controllers;

using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class BlockchainMessagesController : ControllerBase {
  private readonly ILogger<BlockchainMessagesController> _logger;

  public BlockchainMessagesController(ILogger<BlockchainMessagesController> logger) {
    _logger = logger;
  }

  [HttpGet(Name = "LatestMessages")]
  public string Get() {
    return "hiiiii";
  }
}