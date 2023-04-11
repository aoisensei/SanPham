using AutoMapper;
using MediatR;
using SanPham.Application.Interfaces;
using SanPham.Application.SanPham.DTO;
using SanPham.Domain.Entities;
using SharedKernel.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.Application.SanPham.Commands;

public record SanPhamCreateCommand : CreateCommand<SanPhamDto>, IRequest<SanPhamDto>
{
}

public class SanPhamCreateCommandHandler :
    CreateCommandHanlder<ISanPhamDbContext, san_pham>,
    IRequestHandler<SanPhamCreateCommand, SanPhamDto>
{
    public SanPhamCreateCommandHandler(ISanPhamDbContext context, IMapper mapper, IMediator mediator) : base(context, mapper, mediator)
    {
    }

    public Task<SanPhamDto> Handle(SanPhamCreateCommand request, CancellationToken cancellationToken)
    {
        return Handle(request, cancellationToken);
    }
}
