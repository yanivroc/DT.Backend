using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/errorlog")]
public class ErrorLogController : CrudControllerBase<ErrorLog, ErrorLogDto, CreateErrorLogDto, UpdateErrorLogDto>
{
    public ErrorLogController(IGenericRepository<ErrorLog> repo, IMapper mapper) : base(repo, mapper) { }
}
