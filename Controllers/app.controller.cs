using Microsoft.AspNetCore.Mvc;
[ApiController]
[Route("api/[controller]")]
public class CipherController : ControllerBase
{
    private readonly CipherService _cipherService;

    public CipherController()
    {
        _cipherService = new CipherService();
    }

    [HttpPost("encrypt")]
    public ActionResult<string> Encrypt([FromBody] string input)
    {
        int shift = 3; // Exempel på Caesar-chiffer
        var encrypted = _cipherService.Encrypt(input, shift);
        return Ok(encrypted);
    }

    [HttpPost("decrypt")]
    public ActionResult<string> Decrypt([FromBody] string input)
    {
        int shift = 3;
        var decrypted = _cipherService.Decrypt(input, shift);
        return Ok(decrypted);
    }
}