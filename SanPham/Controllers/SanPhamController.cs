using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SanPham.Application.SanPham.Commands;
using SanPham.Application.SanPham.Queries;
using SharedKernel.Api;

namespace SanPham.Api.Controllers
{
    [Route("api/san-pham")]
    [ApiController]
    public class SanPhamController : BaseCrudApiController
        <SanPhamGetAllQuery, 
        SanPhamGetByIdQuery, 
        SanPhamCreateCommand, 
        SanPhamUpdateCommand,
        SanPhamDeleteCommand>
    {
    }
}
