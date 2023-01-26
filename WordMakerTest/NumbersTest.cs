namespace WordMakerTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class NumbersTest
{
  [TestMethod]
  public void HandleZeroAndBelow()
  {
    Assert.ThrowsException<Exception>(() => WordMaker.Numbers.Convert(0));
    Assert.ThrowsException<Exception>(() => WordMaker.Numbers.Convert(-1));
  }
  [TestMethod]
  public void HandleNumbersGreaterThan999()
  {
    Assert.ThrowsException<Exception>(() => WordMaker.Numbers.Convert(1000));
  }

  [DataTestMethod]
  [DataRow(1, "One")]
  [DataRow(8, "Eight")]
  [DataRow(12, "Twelve")]
  [DataRow(19, "Nineteen")]
  [DataRow(20, "Twenty")]
  [DataRow(35, "Thirty Five")]
  [DataRow(100, "One Hundred")]
  [DataRow(111, "One Hundred and Eleven")]
  [DataRow(205, "Two Hundred and Five")]
  [DataRow(250, "Two Hundred and Fifty")]
  [DataRow(500, "Five Hundred")]
  [DataRow(519, "Five Hundred and Nineteen")]
  [DataRow(555, "Five Hundred and Fifty Five")]
  [DataRow(567, "Five Hundred and Sixty Seven")]
  [DataRow(998, "Nine Hundred and Ninety Eight")]
  [DataRow(999, "Nine Hundred and Ninety Nine")]
  public void HandleNumbersBetween1And999(int input, string expected)
  {
      Assert.AreEqual(expected, WordMaker.Numbers.Convert(input), string.Format("Should accept {0} and return {1}", input, expected));
  }

}