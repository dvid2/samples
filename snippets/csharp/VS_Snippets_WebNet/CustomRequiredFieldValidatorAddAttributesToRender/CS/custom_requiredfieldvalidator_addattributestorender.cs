﻿// <Snippet2>
using System.Web;
using System.Security.Permissions;

namespace Samples.AspNet.CS.Controls
{
  [AspNetHostingPermission(SecurityAction.Demand, Level=AspNetHostingPermissionLevel.Minimal)]
  public sealed class CustomRequiredFieldValidatorAddAttributesToRender : System.Web.UI.WebControls.RequiredFieldValidator
  {
    protected override void AddAttributesToRender(System.Web.UI.HtmlTextWriter writer)
    {
      // Show the RequiredFieldValidator's error message as bold.
      writer.AddStyleAttribute(System.Web.UI.HtmlTextWriterStyle.FontWeight, "bold");
      
      // Call the Base's AddAttributesToRender method.
      base.AddAttributesToRender(writer);
    }
  }
}
// </Snippet2>
