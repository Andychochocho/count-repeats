using Nancy;
using CountRepeatProject.Objects;
using System.Collections.Generic;

namespace CountReplaceProject
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => View["index.cshtml"];
      Post["/output"] = _ =>
      {

        return View["output.cshtml"];
      };
    }
  }
}
