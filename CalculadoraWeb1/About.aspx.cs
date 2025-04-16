using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb1
{
	public partial class About : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			var calculadora = new Calculadora();
			var lista = calculadora.GerarNumerosFibonacci(10);

			var html = new StringBuilder();
			html.Append("<ul>");
			for (int i = 0; i < lista.Count; i++)
			{
				html.Append("<li>");
				html.Append(lista[i]);
				html.Append("</li>");
			}
			html.Append("</ul>");

			Label1.Text = html.ToString();
		}
	}
}