using System.Text.RegularExpressions;
using Shouldly;
using Xunit;

namespace Faker.Tests
{
	
	public class PhoneNumberTests
	{
		[Fact]
		public void TestPhoneNumber()
		{
			Regex.IsMatch(PhoneNumber.GetPhoneNumber(), @"\d{3}[. -]\d{3}").ShouldBeTrue();
		}
		
		[Fact]
		public void TestShortPhoneNumber()
		{
			Regex.IsMatch(PhoneNumber.GetShortPhoneNumber(), @"\d{3}-\d{3}-\d{4}").ShouldBeTrue();
		}
	}
}

