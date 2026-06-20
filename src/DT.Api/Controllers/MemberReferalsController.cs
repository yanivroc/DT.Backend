using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/memberreferals")]
public class MemberReferalsController : CrudControllerBase<MemberReferals, MemberReferalsDto, CreateMemberReferalsDto, UpdateMemberReferalsDto>
{
    public MemberReferalsController(IGenericRepository<MemberReferals> repo, IMapper mapper) : base(repo, mapper) { }
}
