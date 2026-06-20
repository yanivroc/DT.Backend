using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/timezone")]
public class TimeZoneController : CrudControllerBase<TimeZone, TimeZoneDto, CreateTimeZoneDto, UpdateTimeZoneDto>
{
    public TimeZoneController(IGenericRepository<TimeZone> repo, IMapper mapper) : base(repo, mapper) { }
}
