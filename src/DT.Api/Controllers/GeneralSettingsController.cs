using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "Admin")]
[Route("api/generalsettings")]
public class GeneralSettingsController : CrudControllerBase<GeneralSettings, GeneralSettingsDto, CreateGeneralSettingsDto, UpdateGeneralSettingsDto>
{
    public GeneralSettingsController(IGenericRepository<GeneralSettings> repo, IMapper mapper) : base(repo, mapper) { }
}
