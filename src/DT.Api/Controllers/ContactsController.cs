using AutoMapper;
using DT.Application.Dtos;
using DT.Application.Interfaces;
using DT.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DT.Api.Controllers;

[Authorize(Roles = "User,Admin")]
[Route("api/contacts")]
public class ContactsController : CrudControllerBase<Contacts, ContactsDto, CreateContactsDto, UpdateContactsDto>
{
    public ContactsController(IGenericRepository<Contacts> repo, IMapper mapper) : base(repo, mapper) { }
}
