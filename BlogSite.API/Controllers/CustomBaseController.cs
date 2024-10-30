using Core.Tokens.Services;
using Microsoft.AspNetCore.Mvc;
namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CustomBaseController(DecoderService decoderService) : ControllerBase
{
    protected string GetUser()
    {
        return decoderService.GetUserId();
    }
}