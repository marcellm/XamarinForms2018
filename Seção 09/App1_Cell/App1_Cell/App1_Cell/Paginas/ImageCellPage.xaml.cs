using App1_Cell.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1_Cell.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "José", Cargo = "Presidente", Foto = "perfil.png" });
            Lista.Add(new Funcionario() { Nome = "Maria", Cargo = "Gerente de Vendas", Foto = "perfil.png" });
            Lista.Add(new Funcionario() { Nome = "Elaine", Cargo = "Gerente de Marketing", Foto = "perfil.png" });
            Lista.Add(new Funcionario() { Nome = "Felipe", Cargo = "Entregador", Foto = "perfil.png" });
            Lista.Add(new Funcionario() { Nome = "João", Cargo = "Vendedor", Foto = "perfil.png" });

            ListaFuncionario.ItemsSource = Lista;
        }
	}
}