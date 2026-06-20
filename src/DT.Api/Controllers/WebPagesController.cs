using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/webpages")]
public class WebPagesController : CrudControllerBase<WebPages, WebPagesDto, CreateWebPagesDto, UpdateWebPagesDto>
{
    public WebPagesController(IGenericRepository<WebPages> repo, IMapper mapper) : base(repo, mapper) { }
}
