using System.Collections.Generic;

namespace TasklistWebApp.Helpers
{
	public static partial class AngularRoutesHelper
	{
		private static string[] GetAllRoutes()
		{
			List<string> rotas = new List<string>()
			{
				"/Conta",
				"/Conta/Acessar",
				"/Home",
				"/fazer-um-teste-agora",
				"/acesso",
				"/sobre-nos"
			};

			rotas.AddCrud("Tarefa");

			return rotas.ToArray();
		}

		private static string[] GetAllGetRoutes()
		{
			List<string> rotas = new List<string>()
			{
				//"/Tarefas/RetornarDocumento",
			};

			return rotas.ToArray();
		}
	}
}