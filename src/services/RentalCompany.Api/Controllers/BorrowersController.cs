using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentalCompany.Api.Models.Request;
using RentalCompany.Application.Borrower.Commands.CreateBorrower;
using RentalCompany.Core.Messages.Commands;
using RentalCompany.Core.Models;
using RentalCompany.Domain.Entities;
using RentalCompany.Domain.Repositories;

namespace RentalCompany.Api.Controllers
{
    [Route("api/v1/borrowers")]
    [ApiController]
    public class BorrowersController : MainController
    {
        public BorrowersController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAll(
            [FromQuery] GetAllBorrowersPagedQueryRequest queryRequest)
        {
            var result = await Mediator.Send(queryRequest.BuildQuery());
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiErrorResponse), StatusCodes.Status400BadRequest)]

        public async Task<ActionResult> Create(
            [FromBody] CreateBorrowerCommand command,
            [FromServices] CreateBorrowerCommandHandler handler)
        {
            var result = (CommandResult<Borrower>)await handler.HandleAsync(command);

            if (result.IsFailure)
            {
                AddProcessingErrors(command.ValidationResult!);
            }

            return CustomReponse();
        }
    }
}
