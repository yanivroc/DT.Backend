using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "User,Admin")]
[Route("api/memberproofs")]
public class MemberProofsController : CrudControllerBase<MemberProofs, MemberProofsDto, CreateMemberProofsDto, UpdateMemberProofsDto>
{
    public MemberProofsController(IGenericRepository<MemberProofs> repo, IMapper mapper) : base(repo, mapper) { }
}
