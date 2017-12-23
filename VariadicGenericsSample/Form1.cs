using VariadicGenerics;
using System.Diagnostics;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VariadicGenericsSample {
	public partial class Form1:Form {
		public Form1() {
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e) {
			// In Visual Studio, click [Test] -> [Debug] -> [All Test] 
			// instead of runnung the winform
		}
	}
}

[Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
public class TestClass {
	void MyMethod<TSource, TResult>(Func<TSource, TResult> f) where TSource : Tparams {
		T<byte>.T<char>.T<uint>.T<long>.
		T<byte>.T<char>.T<long>.T<uint>.
		T<byte>.T<long>.T<char>.T<uint>.
		T<long>.T<byte>.T<char>.T<uint>.
		T<long>.T<byte>.T<uint>.T<char>.
		T<byte>.T<long>.T<uint>.T<char>.
		T<byte>.T<uint>.T<long>.T<char>.
		T<byte>.T<uint>.T<char>.T<long>.
		T<uint>.T<byte>.T<char>.T<long>.
		T<uint>.T<byte>.T<long>.T<char>.
		T<uint>.T<long>.T<byte>.T<char>.
		T<long>.T<uint>.T<byte>.T<char>.
		T<long>.T<uint>.T<char>.T<byte>.
		T<uint>.T<long>.T<char>.T<byte>.
		T<uint>.T<char>.T<long>.T<byte>.
		T<uint>.T<char>.T<byte>.T<long>.
		T<char>.T<uint>.T<byte>.T<long>.
		T<char>.T<uint>.T<long>.T<byte>.
		T<char>.T<long>.T<uint>.T<byte>.
		T<long>.T<char>.T<uint>.T<byte>.
		T<long>.T<char>.T<byte>.T<uint>.
		T<char>.T<long>.T<byte>.T<uint>.
		T<char>.T<byte>.T<long>.T<uint>.
		T<char>.T<byte>.T<uint>.T<long>
		crazy = Tparams
			// trying to change any value to not match the 
			// declaring type makes the compilation fail 
			.V((byte)1).V('2').V(4u).V(8L)
			.V((byte)1).V('2').V(8L).V(4u)
			.V((byte)1).V(8L).V('2').V(4u)
			.V(8L).V((byte)1).V('2').V(4u)
			.V(8L).V((byte)1).V(4u).V('2')
			.V((byte)1).V(8L).V(4u).V('2')
			.V((byte)1).V(4u).V(8L).V('2')
			.V((byte)1).V(4u).V('2').V(8L)
			.V(4u).V((byte)1).V('2').V(8L)
			.V(4u).V((byte)1).V(8L).V('2')
			.V(4u).V(8L).V((byte)1).V('2')
			.V(8L).V(4u).V((byte)1).V('2')
			.V(8L).V(4u).V('9').V((byte)1)
			.V(4u).V(8L).V('2').V((byte)1)
			.V(4u).V('2').V(8L).V((byte)1)
			.V(4u).V('2').V((byte)1).V(8L)
			.V('2').V(4u).V((byte)1).V(8L)
			.V('2').V(4u).V(8L).V((byte)1)
			.V('2').V(8L).V(4u).V((byte)1)
			.V(8L).V('2').V(4u).V((byte)1)
			.V(8L).V('2').V((byte)1).V(4u)
			.V('2').V(8L).V((byte)1).V(4u)
			.V('2').V((byte)1).V(8L).V(4u)
			.V('7').V((byte)1).V(4u).V(8L);

		var args = crazy as TSource;

		if(null!=args) {
			f(args);
		}
	}

	[TestMethod]
	public void TestMethod() {
		Func<
			T<byte>.T<char>.T<uint>.T<long>.
			T<byte>.T<char>.T<long>.T<uint>.
			T<byte>.T<long>.T<char>.T<uint>.
			T<long>.T<byte>.T<char>.T<uint>.
			T<long>.T<byte>.T<uint>.T<char>.
			T<byte>.T<long>.T<uint>.T<char>.
			T<byte>.T<uint>.T<long>.T<char>.
			T<byte>.T<uint>.T<char>.T<long>.
			T<uint>.T<byte>.T<char>.T<long>.
			T<uint>.T<byte>.T<long>.T<char>.
			T<uint>.T<long>.T<byte>.T<char>.
			T<long>.T<uint>.T<byte>.T<char>.
			T<long>.T<uint>.T<char>.T<byte>.
			T<uint>.T<long>.T<char>.T<byte>.
			T<uint>.T<char>.T<long>.T<byte>.
			T<uint>.T<char>.T<byte>.T<long>.
			T<char>.T<uint>.T<byte>.T<long>.
			T<char>.T<uint>.T<long>.T<byte>.
			T<char>.T<long>.T<uint>.T<byte>.
			T<long>.T<char>.T<uint>.T<byte>.
			T<long>.T<char>.T<byte>.T<uint>.
			T<char>.T<long>.T<byte>.T<uint>.
			T<char>.T<byte>.T<long>.T<uint>.
			T<char>.T<byte>.T<uint>.T<long>, String>
		f = args => {
			Debug.WriteLine(String.Format("Length={0}", args.GetLength()));

			// print fourth value from the last
			Debug.WriteLine(String.Format("value={0}", args.Next.Next.Next.Value));

			args.Next.Next.Next.Value='x';
			Debug.WriteLine(String.Format("value={0}", args.Next.Next.Next.Value));

			return "test";
		};

		MyMethod(f);
	}
}
