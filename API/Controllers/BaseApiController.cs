using Application.Activities.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        private IMediator? _mediator;
        protected IMediator Mediator => _mediator??=HttpContext.RequestServices.GetService<IMediator>() 
                                        ?? throw new InvalidOperationException("Mediator service is unavailable");


        // protected IMediator? _mediator;

        // protected IMediator GetService()
        // {
        //     if(_mediator == null)
        //     {
        //         _mediator = HttpContext.RequestServices.GetService<IMediator>();
        //         return _mediator ?? throw new InvalidOperationException("MediatR service is unavaialable");
        //     }

        //     return _mediator;
        // }
    }
}
