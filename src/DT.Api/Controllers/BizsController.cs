using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/bizs")]
public class BizsController : CrudControllerBase<Bizs, BizsDto, CreateBizsDto, UpdateBizsDto>
{
    public BizsController(IGenericRepository<Bizs> repo, IMapper mapper) : base(repo, mapper) { }
}
