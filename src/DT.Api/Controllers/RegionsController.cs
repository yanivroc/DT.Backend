using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/regions")]
public class RegionsController : CrudControllerBase<Regions, RegionsDto, CreateRegionsDto, UpdateRegionsDto>
{
    public RegionsController(IGenericRepository<Regions> repo, IMapper mapper) : base(repo, mapper) { }
}
