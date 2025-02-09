using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using ux.utility.limedica.pe.model;

namespace ux.utility.limedica.pe.Controllers
{

    [AllowAnonymous]
    public class StoreController : ApiController
    {


        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        [Route("api/store/suggestion")]
        public IHttpActionResult GetSuggestion([FromBody] SuggestRequest request)
        {

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

       

            log.Info("Solicitud recibida en GetSuggestion.");

            if (request == null)
            {
                log.Warn("El request es nulo.");
                return BadRequest("El request no puede ser nulo.");
            }

            try
            {
                var response = new { Mensaje = "Respuesta exitosa" };
                log.Debug($"Respuesta generada: {response}");

                stopwatch.Stop();
                log.Info($"Tiempo de respuesta: {stopwatch.ElapsedMilliseconds} ms");

                return Ok(response);
            }
            catch (Exception ex)
            {
                log.Error("Error en GetSuggestion", ex);
                return InternalServerError();
            }
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}