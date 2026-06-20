using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/memberrewards")]
public class MemberRewardsController : CrudControllerBase<MemberRewards, MemberRewardsDto, CreateMemberRewardsDto, UpdateMemberRewardsDto>
{
    public MemberRewardsController(IGenericRepository<MemberRewards> repo, IMapper mapper) : base(repo, mapper) { }
}
