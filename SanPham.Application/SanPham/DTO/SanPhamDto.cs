using AutoMapper;
using SanPham.Domain.Entities;
using SharedKernel.Application.DTO;
using SharedKernel.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPham.Application.SanPham.DTO;

public class SanPhamDto : BaseAuditableDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Type { get; set; } = string.Empty;
    public int Quantity { get; set; }
}

public class SanPhamProfile : Profile
{
    public SanPhamProfile() 
    {
        CreateMap<san_pham, SanPhamDto>()
            .IncludeBase<BaseAuditableEntity, BaseAuditableDto>();
        CreateMap<SanPhamDto, san_pham>()
            .IncludeBase<BaseAuditableDto, BaseAuditableEntity>();
    }
}
