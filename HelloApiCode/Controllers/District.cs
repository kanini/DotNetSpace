using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

[ApiController]
[Route("[controller]")]
public class DistrictController: ControllerBase
{
    List<string> libraryNames = new List<string>{"LIBRARY OF CONGRESS — WASHINGTON D.C., USA","BODLEIAN LIBRARY — OXFORD, UNITED KINGDOM","READING ROOM AT THE BRITISH MUSEUM — LONDON, ENGLAND"};

    private readonly ILogger<DistrictController> _logger;

    public DistrictController(ILogger<DistrictController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetLibrary")]
    public IEnumerable<String> Get()
    {
       
       return libraryNames;
    }
}
