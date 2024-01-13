using System.Runtime.InteropServices.JavaScript;
using ErrorOr;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using User.API.Common.Http;

namespace User.API.Apis;

public class Api
{
    // protected Results<ProblemHttpResult, ValidationProblem> Problem(List<Error> errors)
    // {
    //     if (errors.Count is 0)
    //     {
    //         return TypedResults.Problem();
    //     }
    //
    //     if (errors.All(errors => errors.Type == ErrorType.Validation))
    //     {
    //         return ValidationProblem(errors);
    //     }
    //     
    //     HttpContext.Items[HttpContextItemKeys.Errors] = errors;
    //     
    //     return Problem(errors[0]);
    // }
    //
    // private ProblemHttpResult Problem(Error error)
    // {
    //     var statusCode = error.Type switch
    //     {
    //         ErrorType.Conflict => StatusCodes.Status409Conflict,
    //         ErrorType.Validation => StatusCodes.Status400BadRequest,
    //         ErrorType.NotFound => StatusCodes.Status400BadRequest,
    //         _ => StatusCodes.Status500InternalServerError,
    //     };
    //
    //     return TypedResults.Problem(statusCode: statusCode, title: error.Description);
    // }
    //
    // private ValidationProblem ValidationProblem(IEnumerable<Error> errors)
    // {
    //     var modelStateDictionary = errors.ToDictionary<Error, string, string[]>(
    //         error => error.Code,
    //         error => new[] { error.Description });
    //
    //     return TypedResults.ValidationProblem(modelStateDictionary);
    // }
}