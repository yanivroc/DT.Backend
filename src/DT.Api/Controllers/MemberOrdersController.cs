using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "User,Admin")]
[Route("api/memberorders")]
public class MemberOrdersController : CrudControllerBase<MemberOrders, MemberOrdersDto, CreateMemberOrdersDto, UpdateMemberOrdersDto>
{
    public MemberOrdersController(IGenericRepository<MemberOrders> repo, IMapper mapper) : base(repo, mapper) { }
}
