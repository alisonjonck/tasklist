using System.Collections.Generic;
using System.Linq;

namespace TasklistWebApp.Helpers
{
	public static partial class AngularRoutesHelper
	{
		private static string[] AngularRoutes { get; } = GetAllRoutes();
		private static string[] GETMethodRoutes { get; } = GetAllGetRoutes();
		private static int GETRoutesCount { get; } = GETMethodRoutes.Length;
		private static int RoutesCount { get; } = AngularRoutes.Length;
		/// <summary>
		/// Ajusta Layout da Rota passada por parâmetro
		/// </summary>
		/// <param name="requestPath">Rota que terá Layout ajustado</param>
		/// <returns> Retorna rota pronta para processamento pelo $routeProvider </returns>
		public static string ResolveAngularUri(string requestPath)
		{
			return requestPath.StartsWith("/#") ? requestPath : "~/#/" + requestPath;
		}

		/// <summary>
		/// Verifica se a rota é uma das rotas registradas para o AngularRoutes
		/// </summary>
		/// <param name="path"> Rota que será verificada</param>
		/// <returns> Se TRUE 'path' é uma rota em AngularRoutes </returns>
		public static bool IsAngularRoute(string path)
		{
			string cleanUri = path.Split('?')[0];

			var foundGETURL = false;
			foreach (var gR in GETMethodRoutes.ToList())
			{
				if (gR.Equals(cleanUri))
				{
					foundGETURL = true;
					break;
				}
			}
			if (foundGETURL) return false;

			for (int i = 0; i < RoutesCount; i++)
			{
				if (cleanUri.Equals(AngularRoutes[i]))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Adiciona todas as rotas para um CRUD básico
		/// </summary>
		/// <param name="list"> Extensão para lista de string</param>
		/// <param name="controllerName"> Nome da Controller para o CRUD básico</param>
		internal static void AddCrud(this List<string> list, string controllerName)
		{
			list.Add(string.Format("/{0}/Lista", controllerName));
			list.Add(string.Format("/{0}/Criar", controllerName));
			list.Add(string.Format("/{0}/Editar", controllerName));
			list.Add(string.Format("/{0}", controllerName));
		}
	}
}