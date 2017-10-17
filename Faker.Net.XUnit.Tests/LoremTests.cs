using System.Text.RegularExpressions;
using Faker.Extensions;
using Shouldly;
using Xunit;

namespace Faker.Tests
{
	
	public class LoremTests
	{
		[Fact]
		public void TestParagraph()
		{
			Regex.IsMatch(Lorem.GetParagraph(), @"[ a-z]+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestSentence()
		{
			Regex.IsMatch(Lorem.GetSentence(), @"[ a-z]+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestWord()
		{
			Regex.IsMatch(Lorem.GetWord(), @"[ a-z]+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestParagraphs()
		{
			Regex.IsMatch(Lorem.GetParagraphs().Join(" "), @"[ a-z]+").ShouldBeTrue();
		}
		
		public void TestSentences()
		{
			Regex.IsMatch(Lorem.GetSentences().Join(" "), @"[ a-z]+").ShouldBeTrue();
		}
		
		[Fact]
		public void TestWords()
		{
			Regex.IsMatch(Lorem.GetWords().Join(" "), @"[ a-z]+").ShouldBeTrue();
		}
	}
}