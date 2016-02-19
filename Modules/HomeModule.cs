using Nancy;
using CountRepeatProject.Objects;
using System.Collections.Generic;

namespace CountRepeatProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => View["index.cshtml"];
      Post["/results"] = _ =>
      {
        RepeatCounter newRepeatCounter = new RepeatCounter(Request.Form["word"], Request.Form["longString"]);
        int result = newRepeatCounter.CountRepeats();
        return View["results.cshtml", result];
      };
    }
  }
}
