using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/states")]
public class StatesController : CrudControllerBase<States, StatesDto, CreateStatesDto, UpdateStatesDto>
{
    public StatesController(IGenericRepository<States> repo, IMapper mapper) : base(repo, mapper) { }
}
