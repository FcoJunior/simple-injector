using SampleInjectExample.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimpleInjectExample.Web.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IClienteRepository _repository;

        public ValuesController(IClienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public string Get()
        {
            return _repository.CaptureMessage();
        }
    }
}
