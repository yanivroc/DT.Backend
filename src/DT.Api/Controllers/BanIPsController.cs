using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/banips")]
public class BanIPsController : CrudControllerBase<BanIPs, BanIPsDto, CreateBanIPsDto, UpdateBanIPsDto>
{
    public BanIPsController(IGenericRepository<BanIPs> repo, IMapper mapper) : base(repo, mapper) { }
}
