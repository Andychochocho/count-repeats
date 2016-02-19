using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace CountRepeatProject.Objects
{
  public class CountRepeat
  {
    private string _word;
    private string _longString;

    public CountRepeat(string word, string longString)
    {
      _word = word;
      _longString = longString;
    }
// Getters are placed here
    public string GetWord()
    {
      return _word;
    }
    public string GetLongString()
    {
      return _longString;
    }

    public int CountRepeats()
    {
        return 0;
    }
  }
}
