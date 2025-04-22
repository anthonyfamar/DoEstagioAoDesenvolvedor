using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraWeb1
{
	public partial class CalculadoraCompleta : System.Web.UI.Page
	{

		public string NumeroAtual
		{
			get { return NumeroAtualLabel.Text; }
			set { NumeroAtualLabel.Text = value; }
		}

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void Numero7Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "7";
		}

		protected void Numero8Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "8";
		}

		protected void Numero9Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "9";
		}

		protected void Numero4Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "4";
		}

		protected void Numero5Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "5";
		}

		protected void Numero6Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "6";
		}

		protected void Numero1Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "1";
		}

		protected void Numero2Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "2";
		}

		protected void Numero3Button_Click(object sender, EventArgs e)
		{
			NumeroAtual = NumeroAtual + "3";
		}

		protected void Numero0Button_Click(object sender, EventArgs e)
		{
			if (NumeroAtual != "0")
			{
				NumeroAtual = NumeroAtual + "0";
			}
		}
	}
}