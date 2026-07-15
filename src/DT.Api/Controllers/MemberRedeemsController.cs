using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "User,Admin")]
[Route("api/memberredeems")]
public class MemberRedeemsController : CrudControllerBase<MemberRedeems, MemberRedeemsDto, CreateMemberRedeemsDto, UpdateMemberRedeemsDto>
{
    public MemberRedeemsController(IGenericRepository<MemberRedeems> repo, IMapper mapper) : base(repo, mapper) { }
}
