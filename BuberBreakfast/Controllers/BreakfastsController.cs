using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using BuberBreakfast.Contracts.Breakfast;

namespace BuberBreakfast.Controllers;

[ApiController]
public class Breakfasts : ControllerBase
{

    [HttpPost("/breakfasts")]
    public ActionResult CreateBreakfast(CreateBreakfastRequest request)
    {
        return Ok(request);

    }

    [HttpGet("/breakfast/{id:guid}")]
    public ActionResult GetBreakfast(Guid id)
    {
        return Ok(id);
    }
}