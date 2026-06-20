using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/memberapi")]
public class MemberAPIController : CrudControllerBase<MemberAPI, MemberAPIDto, CreateMemberAPIDto, UpdateMemberAPIDto>
{
    public MemberAPIController(IGenericRepository<MemberAPI> repo, IMapper mapper) : base(repo, mapper) { }
}
