using System.Collections.Generic;
using Xunit;
namespace CountRepeatProject.Objects
{
  public class CountRepeatTest
  {
    [Fact]
    public void isWord_forLongStringNotContainingWord_0()
    {
      CountRepeat newCountRepeat = new CountRepeat ("sample", "this does not work");
      Assert.Equal(newCountRepeat.CountRepeats(), 0);
    }
  }
}
