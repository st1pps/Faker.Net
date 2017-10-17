using System.Globalization;
using System.Text.RegularExpressions;
using Shouldly;
using Xunit;

namespace Faker.Tests
{
	
	public class GeoLocationTests
	{
		[Fact]
		public void TestLat()
		{
			Regex.IsMatch(GeoLocation.GetLat().ToString(CultureInfo.InvariantCulture), "[0-9]+").ShouldBeTrue();
		}

		[Fact]
		public void TestLng()
		{
			Regex.IsMatch(GeoLocation.GetLng().ToString(CultureInfo.InvariantCulture), "[0-9]+").ShouldBeTrue();
		}
	}
}