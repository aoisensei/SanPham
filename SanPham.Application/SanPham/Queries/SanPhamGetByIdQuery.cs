using AutoMapper;
using MediatR;
using SanPham.Application.Interfaces;
using SanPham.Application.SanPham.DTO;
using SanPham.Domain.Entities;
using SharedKernel.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.Application.SanPham.Queries;

public record SanPhamGetByIdQuery : GetByIdQuery, IRequest<SanPhamDto>
{
}

public class SanPhamGetByIdQueryHandler :
    GetByIdQueryHanlder<ISanPhamDbContext, san_pham>,
    IRequestHandler<SanPhamGetByIdQuery, SanPhamDto>
{
    public SanPhamGetByIdQueryHandler(ISanPhamDbContext context, IMapper mapper, IMediator mediator) : base(context, mapper, mediator)
    {
    }

    public Task<SanPhamDto> Handle(SanPhamGetByIdQuery request, CancellationToken cancellationToken)
    {
        return Handle(request, cancellationToken);
    }
}