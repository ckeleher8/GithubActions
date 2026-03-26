namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Patino()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Patino()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Patino()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}	
}

[TestClass]
public class SubtractionTests
{
	[TestMethod]
	public void Subtract_Valid_Keleher() =>  Assert.AreEqual(5, Program.Subtract("10", "5"));
}

[TestClass]
public class MultiplicationTests
{
	[TestMethod]
	public void Multiply_Valid_Keleher() => Assert.AreEqual(50, Program.Multiply("10", "5"));
}

[TestClass]
public class DivisionTests
{
	[TestMethod]
	public void Divide_Valid_Keleher() => Assert.AreEqual(2, Program.Divide("10", "5"));
}

[TestClass]
public class PowerTests
{
	[TestMethod]
	public void Power_Valid_Keleher() => Assert.AreEqual(100, Program.Power("10", "2"));

	[TestMethod]
	public void Power_Invalid_Keleher() => Assert.AreEqual(9, Program.Power("2", "3"));
}
