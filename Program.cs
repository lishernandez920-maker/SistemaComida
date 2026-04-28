using System;

namespace SistemaComida
{
	
	class Program
	{
		static void Main(string[] args)
		{
			ComidaFactory factory;

			Console.WriteLine("Seleccione una opción: 1) Pizza  2) Hamburguesa  3) Ensalada");
			string opcion = Console.ReadLine();

			switch (opcion)
			{
				case "1":
					factory = new PizzaFactory();
					break;
				case "2":
					factory = new HamburguesaFactory();
					break;
				case "3":
					factory = new EnsaladaFactory();
					break;
				default:
					Console.WriteLine("Opción inválida.");
					return;
			}

			// Se crea la comida usando el Factory seleccionado
			IComida comida = factory.CrearComida();

			// Se ejecuta el método Preparar() de la comida concreta
			comida.Preparar();

			Console.WriteLine("¡Comida lista para servir!");
		}
	}


	public interface IComida
	{
		void Preparar();
	}

	
	public class Pizza : IComida
	{
		public void Preparar()
		{
			Console.WriteLine("Preparando una Pizza con salsa, queso y pepperoni.");
		}
	}

	public class Hamburguesa : IComida
	{
		public void Preparar()
		{
			Console.WriteLine("Preparando una Hamburguesa con carne, lechuga y tomate.");
		}
	}

	public class Ensalada : IComida
	{
		public void Preparar()
		{
			Console.WriteLine("Preparando una Ensalada fresca con vegetales variados.");
		}
	}


	public abstract class ComidaFactory
	{
		public abstract IComida CrearComida();
	}

	
	public class PizzaFactory : ComidaFactory
	{
		public override IComida CrearComida()
		{
			return new Pizza();
		}
	}

	public class HamburguesaFactory : ComidaFactory
	{
		public override IComida CrearComida()
		{
			return new Hamburguesa();
		}
	}

	public class EnsaladaFactory : ComidaFactory
	{
		public override IComida CrearComida()
		{
			return new Ensalada();
		}
	}
}

