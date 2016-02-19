using System.Collections.Generic;
using Xunit;
namespace CountRepeatProject.Objects
{
  public class RepeatCounterTest
  {
    [Fact]
    public void isWord_forLongStringNotContainingWord_0()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("sample", "this does not work");
      Assert.Equal(newCountRepeat.CountRepeats(), 0);
    }
    [Fact]
    public void isWord_forLongStringBeingWord_1()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("superman", "superman");
      Assert.Equal(newCountRepeat.CountRepeats(), 1);
    }
    [Fact]
    public void isWord_forLongStringContainingWordOnce_1()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("batman", "batman rocks");
      Assert.Equal(newCountRepeat.CountRepeats(), 1);
    }
    [Fact]
    public void isWord_forLongStringContainingWordMutipleTimes_3()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("the", "the hulk is the best at the hulk smash");
      Assert.Equal(newCountRepeat.CountRepeats(), 3);
    }
    [Fact]
    public void isWord_forLongStringContainingWordMutipleTimesAndOnlyCaseMatches_2()
    {
      RepeatCounter newCountRepeat = new RepeatCounter ("123", "the 123 is super good at123 123ing in order of 1 2 3 123 yeah");
      Assert.Equal(newCountRepeat.CountRepeats(), 2);
    }
  }
}
