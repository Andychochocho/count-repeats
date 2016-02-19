using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace CountRepeatProject.Objects
{
  public class RepeatCounter
  {
    private string _word;
    private string _longString;

    public RepeatCounter(string word, string longString)
    {
      _word = word;
      _longString = longString;
    }

    public int CountRepeats()
    {
      int result = Regex.Matches(_longString, @"\b" + @_word + @"\b").Count;
      return result;
    }
  }
}
