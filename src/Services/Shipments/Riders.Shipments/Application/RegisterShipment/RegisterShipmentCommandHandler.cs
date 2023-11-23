using MediatR;
using Riders.Shipments.Domain;

namespace Riders.Shipments.Application.RegisterShipment;

public class RegisterShipmentCommandHandler(IShipmentRepository _shipmentRepository) : IRequestHandler<RegisterShipmentCommand, RegisterShipmentCommandResult>
{

    public async Task<RegisterShipmentCommandResult> Handle(RegisterShipmentCommand request, CancellationToken cancellationToken)
    {
        var entity = ShipmentCommandMapper.ToEntity(request);

        _shipmentRepository.Add(entity);
        await _shipmentRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

        return new(entity.Id);
    }
}
