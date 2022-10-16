using Microsoft.AspNetCore.Mvc;
using PaymentApi.Models;
using PaymentApi.Repositories;

namespace PaymentApi.Controllers
{
    [ApiController]
    [Route("api-docs/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoRepository _repository;

        public PedidoController(IPedidoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest("O ID informado é inválido!");
            }

            var pedido = _repository.GetById(id);

            if (pedido == null)
            {
                return NotFound("Pedido não encontrado !");
            }

            return Ok(pedido);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                int retorno;

                retorno = _repository.Add(pedido);

                if (retorno == 1)
                {
                    return Ok(pedido);
                }
            }

            return BadRequest("Ocorreu um erro ao cadastrar o Pedido, verifique os dados informados!");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] string status)
        {
            if (ModelState.IsValid)
            {
                int retorno;
                retorno = _repository.UpdateStatus(id, status);

                if (retorno == 1)
                {
                    return Ok();
                }
            }

            return BadRequest("O Status informado para a operação é inválido!");
        }
    }
}
