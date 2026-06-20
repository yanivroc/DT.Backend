using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/pics")]
public class PicsController : CrudControllerBase<Pics, PicsDto, CreatePicsDto, UpdatePicsDto>
{
    public PicsController(IGenericRepository<Pics> repo, IMapper mapper) : base(repo, mapper) { }
}
