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

public record SanPhamDeleteCommand : DeleteCommand, IRequest<int>
{
}

public class SanPhamDeleteCommandHandler :
    DeleteCommandHanlder<ISanPhamDbContext, san_pham>,
    IRequestHandler<SanPhamDeleteCommand, int>
{
    public SanPhamDeleteCommandHandler(ISanPhamDbContext context, IMapper mapper, IMediator mediator) : base(context, mapper, mediator)
    {
    }

    public Task<int> Handle(SanPhamDeleteCommand request, CancellationToken cancellationToken)
    {
        return Handle((DeleteCommand)request, cancellationToken);
    }
}
