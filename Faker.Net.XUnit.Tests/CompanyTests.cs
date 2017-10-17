using System.Text.RegularExpressions;
using Shouldly;
using Xunit;

namespace Faker.Tests
{
	
	public class CompanyTests
	{
		[Fact]
		public void TestBS()
		{
			Regex.IsMatch(Company.GetBS(), @"[ a-z]+").ShouldBeTrue();
			Regex.IsMatch(Company.GetBS(), @"\s").ShouldBeTrue();
		}
		
		[Fact]
		public void TestCatchPhrase()
		{
			Regex.IsMatch(Company.GetCatchPhrase(), @"[ a-z]+").ShouldBeTrue();
			Regex.IsMatch(Company.GetCatchPhrase(), @"\s").ShouldBeTrue();
		}
		
		[Fact]
		public void TestName()
		{
			Regex.IsMatch(Company.GetName(), @"[ a-z]+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestSuffix()
		{
			Regex.IsMatch(Company.GetSuffix(), @"[ a-z]+").ShouldBeTrue();
		}
	}
}