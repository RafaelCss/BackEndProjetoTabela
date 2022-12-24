using System.ComponentModel.DataAnnotations;

namespace WebApi.Modelos
{
	public class ModelCadastroFruta
	{
		[Required]
		public string Nome { get; set; }
		[Required]
		public int ValorA { get; set; }
		[Required]
		public int ValorB { get; set; }
	}
}
