using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers;

[ApiController]
[Route("[controller]")]
public class ListingController : ControllerBase
{
    private readonly ILogger<ListingController> _logger;
    private readonly IListingFromCsvService _csvService;

    public ListingController(ILogger<ListingController> logger, IListingFromCsvService csvService)
    {
        _logger = logger;
        _csvService = csvService;
    }

    [Route("{id}", Name = "GetById")]
    public ListingEntity Get(int id) =>
        _csvService.GetById(id);

    [HttpGet(Name = "GetPaged")]
    public IList<ListingEntity> GetPaged(string? propertyType, int pageNumber) =>
        _csvService.GetPaged(propertyType, pageNumber);


}
