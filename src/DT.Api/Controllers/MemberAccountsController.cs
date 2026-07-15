using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "User,Admin")]
[Route("api/memberaccounts")]
public class MemberAccountsController : CrudControllerBase<MemberAccounts, MemberAccountsDto, CreateMemberAccountsDto, UpdateMemberAccountsDto>
{
    public MemberAccountsController(IGenericRepository<MemberAccounts> repo, IMapper mapper) : base(repo, mapper) { }
}
