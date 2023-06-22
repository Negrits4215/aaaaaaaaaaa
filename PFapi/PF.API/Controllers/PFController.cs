using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PF.API.Models;
using PF.API.Utils;

namespace PF.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PFController : ControllerBase
{

    [HttpGet("Temas")] public IActionResult GetAll() {
        IActionResult respuesta;
        List<Temas> entityList;
        entityList=BDPF.GetTemas();
        respuesta= Ok(entityList);
        return respuesta;
    }

    [HttpGet("Preguntas/{TemasId}")] public IActionResult PreguntasById(int TemasId) {
        IActionResult respuesta;
        List<Preguntas> entityList;
        entityList=BDPF.GetPreguntasById(TemasId);
        if (entityList==null) {
            respuesta=NotFound();
        }
        else {
            respuesta=Ok(entityList);
        }
        return respuesta;
    }
    
    [HttpGet("Respuestas/{PreguntasId}")] public IActionResult RespuestasById(int PreguntasId) {
        IActionResult respuesta;
        List<Respuestas> entity;
        entity=BDPF.GetRespuestasById(PreguntasId);
        if (entity==null) {
            respuesta=NotFound();
        }
        else {
            respuesta=Ok(entity);
        }
        return respuesta;
    }
}
