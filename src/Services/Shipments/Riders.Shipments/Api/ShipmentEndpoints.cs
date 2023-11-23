using MediatR;
using Microsoft.AspNetCore.Mvc;
using Riders.Shipments.Application.RegisterShipment;

namespace Riders.Shipments.Api;

internal static class ShipmentEndpoints
{
    private const string _routeName = "shipment";

    internal static void MapShipmentEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup(_routeName);

        group.MapPost("/", async ([FromBody] RegisterShipmentRequest request, ISender sender, CancellationToken cancellationToken) =>
        {
            var response = await sender.Send(RegisterShipmentRequestMapper.ToCommand(request), cancellationToken);

            return Results.Created($"/{_routeName}/{response.Id}", response);
        }).AddEndpointFilter<RequestValidatorFilter<RegisterShipmentRequest>>()
            .WithName("RegisterShipment")
            .WithOpenApi()
            .Produces<RegisterShipmentCommandResult>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);
    }
}
