using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/useragents")]
public class UserAgentsController : CrudControllerBase<UserAgents, UserAgentsDto, CreateUserAgentsDto, UpdateUserAgentsDto>
{
    public UserAgentsController(IGenericRepository<UserAgents> repo, IMapper mapper) : base(repo, mapper) { }
}
