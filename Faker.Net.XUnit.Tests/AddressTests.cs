using System.Text.RegularExpressions;
using Shouldly;
using Xunit;

namespace Faker.Tests
{
	
	public class AddressTests
	{
		[Fact]
		public void TestCity()
		{
			Regex.IsMatch(Address.GetCity(), @"[ a-z]+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestCityPrefix()
		{
			Regex.IsMatch(Address.GetCityPrefix(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestCitySuffix()
		{
			Regex.IsMatch(Address.GetCitySuffix(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestSecondaryAddress()
		{
			Regex.IsMatch(Address.GetSecondaryAddress(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUSStreetAddress()
		{
            var address = Address.GetEUStreetAddress();
            Regex.IsMatch(address, @"[ a-z]").ShouldBeTrue();
		}
        [Fact]
        public void TestEUStreetAddress()
        {
            var address = Address.GetEUStreetAddress();
            Regex.IsMatch(address, @"[ a-z]").ShouldBeTrue();
        }
		
		[Fact]
		public void TestStreetName()
		{
			Regex.IsMatch(Address.GetStreetName(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestStreetSuffix()
		{
			Regex.IsMatch(Address.GetStreetSuffix(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUKCountry()
		{
			Regex.IsMatch(Address.GetUKCountry(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUKCounty()
		{
			Regex.IsMatch(Address.GetUKCounty(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUKPostcode()
		{
			Regex.IsMatch(Address.GetUKPostcode(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUSState()
		{
			Regex.IsMatch(Address.GetUSState(), @"[ a-z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUSStateAbbr()
		{
			Regex.IsMatch(Address.GetUSStateAbbr(), @"[A-Z]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUSZipCode()
		{
			Regex.IsMatch(Address.GetZipCode(), @"[0-9]").ShouldBeTrue();
		}
		
		[Fact]
		public void TestNeighborhood()
		{
			Regex.IsMatch(Address.GetNeighborhood(), @"[ a-z]+").ShouldBeTrue();
		}

        [Fact]
        public void TestWorldCountry()
        {
            Regex.IsMatch(Address.GetCountry(), @"[ a-z]").ShouldBeTrue();
        }
	}
}