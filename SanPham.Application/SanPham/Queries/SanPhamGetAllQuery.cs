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

public record SanPhamGetAllQuery : GetAllQuery, IRequest<ResponeListDto<SanPhamDto>>
{
}

public class SanPhamGetAllQueryHandler :
    GetAllQueryHanlder<ISanPhamDbContext, san_pham>,
    IRequestHandler<SanPhamGetAllQuery, ResponeListDto<SanPhamDto>>
{
    public SanPhamGetAllQueryHandler(ISanPhamDbContext context, IMapper mapper, IMediator mediator) : base(context, mapper, mediator)
    {
    }

    public Task<ResponeListDto<SanPhamDto>> Handle(SanPhamGetAllQuery request, CancellationToken cancellationToken)
    {
        return Handle(request, cancellationToken);
    }
}