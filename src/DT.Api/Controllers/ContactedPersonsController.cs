using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Route("api/contactedpersons")]
public class ContactedPersonsController : CrudControllerBase<ContactedPersons, ContactedPersonsDto, CreateContactedPersonsDto, UpdateContactedPersonsDto>
{
    public ContactedPersonsController(IGenericRepository<ContactedPersons> repo, IMapper mapper) : base(repo, mapper) { }
}
