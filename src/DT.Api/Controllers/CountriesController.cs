using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/countries")]
public class CountriesController : CrudControllerBase<Countries, CountriesDto, CreateCountriesDto, UpdateCountriesDto>
{
    public CountriesController(IGenericRepository<Countries> repo, IMapper mapper) : base(repo, mapper) { }
}
