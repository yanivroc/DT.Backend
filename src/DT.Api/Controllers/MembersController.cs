using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/members")]
public class MembersController : CrudControllerBase<Members, MembersDto, CreateMembersDto, UpdateMembersDto>
{
    public MembersController(IGenericRepository<Members> repo, IMapper mapper) : base(repo, mapper) { }
}
