namespace WordMaker;
public static class Numbers
{
  /// <summary>
  /// Convert is a function that takes any number from 1 to 999 and produces the textual equivalent
  /// </summary>
  /// 
  /// <param name="number">Number to convert</param>
  /// 
  /// <returns>The textual equivalent to <c>number</c></returns>
  /// 
  /// <remarks>
  /// 1 returns “One”<br/>
  /// 10 returns “Ten”<br/>
  /// 11 returns “Eleven”<br/>
  /// 22 returns “Twenty Two”<br/>
  /// 111 returns “One Hundred and Eleven”<br/>
  /// 120 returns “One Hundred and Twenty”<br/>
  /// 121 returns “One Hundred and Twenty One”<br/>
  /// 300 returns “three hundred”<br/>
  /// </remarks>
  public static string Convert (int number) {
    return "One";
  }
}
