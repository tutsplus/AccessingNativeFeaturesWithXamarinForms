using System;
using DependencyServiceSample.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(Sample_iOS))]

namespace DependencyServiceSample.iOS
{
	public class Sample_iOS : ISampleInterface
	{
		#region ISampleInterface implementation

		public string GetData ()
		{
			return "I came from the iOS project!";
		}

		#endregion
	}
}

