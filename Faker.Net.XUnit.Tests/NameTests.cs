using System.Text.RegularExpressions;
using Shouldly;
using Xunit;

namespace Faker.Tests
{
	
	public class NameTests
	{
		[Fact]
		public void TestName()
		{
			Regex.IsMatch(Name.GetName(), @"(\w+\.?) (\w+)( \w+)?").ShouldBeTrue();
		}
		
		[Fact]
		public void TestPrefix()
		{
			Regex.IsMatch(Name.GetPrefix(), @"[A-Z][a-z]+\.?").ShouldBeTrue();
		}
		
		[Fact]
		public void TestSuffix()
		{
			Regex.IsMatch(Name.GetSuffix(), @"[A-Z][a-z]*\.?").ShouldBeTrue();
		}
	}
}