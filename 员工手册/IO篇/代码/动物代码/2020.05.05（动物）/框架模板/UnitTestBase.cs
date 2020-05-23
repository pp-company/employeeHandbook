using System;
using NUnit.Framework;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
namespace Zenject
{
	public abstract class UnitTestBase : ZenjectUnitTestFixture
	{
		protected List<BindingInstaller> installers = new List<BindingInstaller>();

		protected double _epsilon = 1e-5;

		protected float _similarRange = .2f;

		public UnitTestBase()
		{
			//installers.Add(new Ampligence.Installers.BasicInstaller());
			SetInstallers();


		}

		public static void PrintMatrix<T>(T[,] matrix)
		{
			int n = matrix.GetLength(0);
			int m = matrix.GetLength(1);
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					Console.Write(matrix[i, j].ToString() + ",\t");
				}
				Console.Write(";\n");

			}
		}


		public virtual void SafeAssertEqual<T>(T expected, T actual)
		{
			if (expected is float || expected is double)
			{
				double dE = Convert.ToDouble(expected);
				double dA = Convert.ToDouble(actual);

				Assert.AreEqual(dE, dA, _epsilon);
			}
			else
			{
				Assert.AreEqual(expected, actual);
			}

		}


		public virtual void SafeAssertNotEqual<T>(T expected, T actual)
		{
			Assert.AreNotEqual(expected, actual);
		}

		public virtual void SafeAssertEqualOrNot<T>(T expected, T actual, bool isEqual)
		{
			if (isEqual)
			{
				SafeAssertEqual<T>(expected, actual);
			}
			else
			{
				SafeAssertNotEqual<T>(expected, actual);
			}
		}

		public static void Print(object obj)
		{
			Console.WriteLine(obj.ToString());
		}





		public static void PrintLine()
		{
			Console.WriteLine("");
			Console.WriteLine("===========================");
			Console.WriteLine("");
		}


		public static void PrintArray<T>(IEnumerable<T> items)
		{
			var enu = items.GetEnumerator();
			int i = 0;
			while (enu.MoveNext())
			{
				Console.WriteLine(//i + ":\t" +
								  (enu.Current.ToString()
								  + ';'
								  )
								 );
				i++;
			}
		}


		public static void AssertPrintEqual(object expected, object actual)
		{
			Print("actual = " + actual);
			Assert.AreEqual(expected.ToString(), actual.ToString());
		}


		public void AssertMatrixSame<T>(T[,] a, T[,] b)
		{
			var aRow = a.GetLength(0);
			var aCol = a.GetLength(1);
			var bRow = b.GetLength(0);
			var bCol = b.GetLength(1);
			if (aRow != bRow)
			{
				Assert.Fail("Matrix Dimension (row) not the same.");
			}
			else if (aCol != bCol)
			{
				Assert.Fail("Matrix Dimension (col) not the same.");
			}
			else
			{
				for (int i = 0; i < aRow; i++)
				{
					for (int j = 0; j < aCol; j++)
					{

						Assert.AreEqual(a[i, j], b[i, j], "Elememnt({0},{1}) is different ", i, j);

					}
				}
			}
		}



		public void AssertListSame<T>(IEnumerable<T> a, IEnumerable<T> b)
		{
			var ac = a.Count();
			var bc = b.Count();
			if (ac != bc)
			{
				Assert.Fail("List Dimension not equal! a.Count = {0}, b.Count= {1}", ac, bc);
			}
			else
			{
				var ae = a.GetEnumerator();
				var be = b.GetEnumerator();

				if (typeof(T) == typeof(double) || typeof(T) == typeof(float))//decide once, don't decide in loop
				{
					while (ae.MoveNext() && be.MoveNext())
					{
						var ai = ae.Current;
						var bi = be.Current;
						SafeAssertEqual(ai, bi);
					}
				}
				else
				{
					while (ae.MoveNext() && be.MoveNext())
					{
						var ai = ae.Current;
						var bi = be.Current;
						Assert.AreEqual(ai, bi);//speed up. no need to use safe, because T is already ensured, and there is no truncation error.
					}
				}

			}



		}


		public void AssertListNotSame<T>(IEnumerable<T> a, IEnumerable<T> b)
		{
			bool ans;
			ans = a.SequenceEqual(b);
			Assert.False(ans);
		}







		public override void Setup()
		{
			base.Setup();
			DoBinding();
			Container.Inject(this);
		}




		protected virtual void DoBinding()
		{
			foreach (var installer in installers)
			{
				installer.Container = this.Container;
				installer.Bind();
			}
		}


		protected bool IsSimilar(IEnumerable<float> list)
		{

			float average = list.Average();

			foreach (float element in list)
			{
				if (element > average + average * _similarRange || element < average - average * _similarRange)
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// installers.Add(BindingInstaller)
		/// </summary>
		protected abstract void SetInstallers();
	}
}
