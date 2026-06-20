using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/memberpoints")]
public class MemberPointsController : CrudControllerBase<MemberPoints, MemberPointsDto, CreateMemberPointsDto, UpdateMemberPointsDto>
{
    public MemberPointsController(IGenericRepository<MemberPoints> repo, IMapper mapper) : base(repo, mapper) { }
}
