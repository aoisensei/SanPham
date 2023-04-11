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

public record SanPhamUpdateCommand : UpdateCommand<SanPhamDto>, IRequest<SanPhamDto>
{
}

public class SanPhamUpdateCommandHandler :
    UpdateCommandHanlder<ISanPhamDbContext, san_pham>,
    IRequestHandler<SanPhamUpdateCommand, SanPhamDto>
{
    public SanPhamUpdateCommandHandler(ISanPhamDbContext context, IMapper mapper, IMediator mediator) : base(context, mapper, mediator)
    {
    }

    public Task<SanPhamDto> Handle(SanPhamUpdateCommand request, CancellationToken cancellationToken)
    {
        return Handle(request, cancellationToken);
    }
}