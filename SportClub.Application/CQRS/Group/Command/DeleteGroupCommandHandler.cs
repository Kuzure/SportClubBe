using MediatR;
using SportClub.Application.Interface;
using SportClub.Infrastructure;

namespace SportClub.Application.CQRS.Group.Command;

public class DeleteGroupCommandHandler: IRequestHandler<DeleteGroupCommand, Response<string>>
{
    private readonly IRepository<SportClub.Domain.Entity.Group> _repository;

    public DeleteGroupCommandHandler(IRepository<SportClub.Domain.Entity.Group> repository)
    {
        _repository = repository;
    }

    public async Task<Response<string>> Handle(DeleteGroupCommand request, CancellationToken cancellationToken)
    {
        await _repository.Delete(request.Id);
        return default!;
    }
}