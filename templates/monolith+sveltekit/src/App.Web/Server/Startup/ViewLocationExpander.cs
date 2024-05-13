namespace App.Web.Server;

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Razor;

public class ViewLocationExpander : IViewLocationExpander
{
  // /////////////////////////////////////////////////////////////////////////////////////////////
  // Public Methods
  // /////////////////////////////////////////////////////////////////////////////////////////////

  public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
  {
    // We need this because the views have been moved from their default locations. This
    // tells MVC where to look to find them.

    yield return "/Server/Areas/{1}/Views/{0}.cshtml";
    yield return "/Server/Areas/Shared/Views/{0}.cshtml";
  }

  public void PopulateValues(ViewLocationExpanderContext context)
  {
  }
}
