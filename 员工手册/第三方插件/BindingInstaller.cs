using System;
namespace Zenject
{
	public abstract class BindingInstaller
	{


		DiContainer container;

		protected BindingInstaller()
		{

		}

		public DiContainer Container
		{
			get
			{
				return container;
			}
			set
			{
				this.container = value;
			}

		}



		/// <summary>
		/// Container.Bind...........
		/// </summary>
		public abstract void Bind();





		protected void ContainerBindInterfaceTo<Abstract, Implementation>(bool asSingle = true) where Implementation : Abstract
		{
			if (asSingle)
			{
				container.Bind<Abstract>().To<Implementation>().AsSingle();
			}
			else
			{
				container.Bind<Abstract>().To<Implementation>().AsTransient();
				
			}
		}
	}
}
