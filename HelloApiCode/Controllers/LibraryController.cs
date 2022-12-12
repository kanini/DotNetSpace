using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

[ApiController]
[Route("[controller]")]
public class LibraryController: ControllerBase
{
    private static readonly string[] BookNames = new[]
    {
        "Absalom, Absalom!",
        "A Time to Kill by John Grisham. ",
        "The House of Mirth by Edith Wharton. ",
        "East of Eden by John Steinbeck. ",
        "The Sun Also Rises by Ernest Hemingway. ",
        "Vile Bodies by Evelyn Waugh. ",
        "A Scanner Darkly by Philip K. ",
        "Moab is my Washpot by Stephen Fry"

    };

    private readonly ILogger<LibraryController> _logger;

    public LibraryController(ILogger<LibraryController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetBooks")]
    public IEnumerable<Book> GetBooks()
    {
       
        return Enumerable.Range(1, 5).Select(index => new Book
        {

            PublishedDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-Random.Shared.Next(2000))),
            Pages = Random.Shared.Next(50, 200),
            Name = BookNames[Random.Shared.Next(BookNames.Length)]
        })
        .ToArray();
    }
}
