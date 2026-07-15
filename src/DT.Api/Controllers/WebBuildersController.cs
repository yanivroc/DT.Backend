using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/webbuilders")]
public class WebBuildersController : CrudControllerBase<WebBuilders, WebBuildersDto, CreateWebBuildersDto, UpdateWebBuildersDto>
{
    public WebBuildersController(IGenericRepository<WebBuilders> repo, IMapper mapper) : base(repo, mapper) { }
}
