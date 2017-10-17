using System.Text.RegularExpressions;
using Shouldly;
using Xunit;

namespace Faker.Tests
{
	
	public class InternetTests
	{
		[Fact]
		public void TestEmail()
		{
			Regex.IsMatch(Internet.GetEmail(), @".+@.+\.\w+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestFreeEmail()
		{
			Regex.IsMatch(Internet.GetFreeEmail(), @".+@(gmail|hotmail|yahoo)\.com").ShouldBeTrue();
		}
		
		[Fact]
		public void TestDisposableEmail()
		{
			Regex.IsMatch(Internet.GetDisposableEmail(), @".+@(mailinator\.com|suremail\.info|spamherelots\.com|binkmail\.com|safetymail\.info)").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUserName()
		{
			Regex.IsMatch(Internet.GetUserName(), @"[a-z]+((_|\.)[a-z]+)?").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUserNameWithArg()
		{
			Regex.IsMatch(Internet.GetUserName("bo peep"), @"(bo(_|\.)peep|peep(_|\.)bo)").ShouldBeTrue();
		}
		
		[Fact]
		public void TestDomainName()
		{
			Regex.IsMatch(Internet.GetDomainName(), @"\w+\.\w+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestDomainWord()
		{
			Regex.IsMatch(Internet.GetDomainWord(), @"^\w+$").ShouldBeTrue();
		}
		
		[Fact]
		public void TestDomainSuffix()
		{
			Regex.IsMatch(Internet.GetDomainSuffix(), @"^\w+(\.\w+)?").ShouldBeTrue();
		}
		
		[Fact]
		public void TestUri()
		{
			Regex.IsMatch(Internet.GetUri("ftp"), @"^ftp:\/\/.+").ShouldBeTrue();
			Regex.IsMatch(Internet.GetUri("http"), @"^http:\/\/.+").ShouldBeTrue();
			Regex.IsMatch(Internet.GetUri("https"), @"^https:\/\/.+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestHttpUrl()
		{
			Regex.IsMatch(Internet.GetHttpUrl(), @"^http:\/\/.+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestIP_V4_Address()
		{
			Regex.IsMatch(Internet.GetIP_V4_Address(), @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}").ShouldBeTrue();
		}
	}
}