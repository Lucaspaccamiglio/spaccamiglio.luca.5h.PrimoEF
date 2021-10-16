using System;
using Microsoft.EntityFrameworkCore.Migrations;
using System.ComponentModel.DataAnnotations;

namespace spaccamiglio.luca._5h.PrimoEF
{
public class Persona{

[Key]
public int PersonaId {get; set;}
public string Nome {get; set;}
public string Cognome {get; set;}

[EmailAddress]
public string EMail {get; set;}
    
 }
}