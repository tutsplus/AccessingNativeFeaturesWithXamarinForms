using System;
using DependencyServiceSample.Android;

[assembly: Xamarin.Forms.Dependency(typeof(Sample_Android))]

namespace DependencyServiceSample.Android
{
	public class Sample_Android : ISampleInterface
	{
		#region ISampleInterface implementation

		public string GetData ()
		{
			return "I came from the Android project!";
		}

		#endregion
	}
}

