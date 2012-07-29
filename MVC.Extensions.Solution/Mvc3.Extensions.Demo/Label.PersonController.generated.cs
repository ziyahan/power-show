// <auto-generated />
// This file was generated by a T4 template.
// Don't change it directly as your change would get overwritten.  Instead, make changes
// to the .tt file (i.e. the T4 template) and save it to regenerate this file.

// Make sure the compiler doesn't complain about missing Xml comments
#pragma warning disable 1591
#region T4MVC

using System;
using System.Diagnostics;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using System.Web.Routing;
using T4MVC;
namespace Mvc3.Extensions.Demo.Areas.Label.Controllers {
    public partial class PersonController {
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PersonController() { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected PersonController(Dummy d) { }

        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        protected RedirectToRouteResult RedirectToAction(ActionResult result) {
            var callInfo = result.GetT4MVCResult();
            return RedirectToRoute(callInfo.RouteValueDictionary);
        }


        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public PersonController Actions { get { return MVC.Label.Person; } }
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Area = "Label";
        [GeneratedCode("T4MVC", "2.0")]
        public readonly string Name = "Person";

        static readonly ActionNamesClass s_actions = new ActionNamesClass();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ActionNamesClass ActionNames { get { return s_actions; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ActionNamesClass {
            public readonly string Index = "Index";
            public readonly string Edit = "Edit";
        }


        static readonly ViewNames s_views = new ViewNames();
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public ViewNames Views { get { return s_views; } }
        [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
        public class ViewNames {
            public readonly string Edit = "~/Areas/Label/Views/Person/Edit.cshtml";
        }
    }

    [GeneratedCode("T4MVC", "2.0"), DebuggerNonUserCode]
    public class T4MVC_PersonController: Mvc3.Extensions.Demo.Areas.Label.Controllers.PersonController {
        public T4MVC_PersonController() : base(Dummy.Instance) { }

        public override System.Web.Mvc.ActionResult Index() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Index);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit() {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            return callInfo;
        }

        public override System.Web.Mvc.ActionResult Edit(Mvc3.Extensions.Demo.Areas.Label.Models.PersonViewModel person) {
            var callInfo = new T4MVC_ActionResult(Area, Name, ActionNames.Edit);
            callInfo.RouteValueDictionary.Add("person", person);
            return callInfo;
        }

    }
}

#endregion T4MVC
#pragma warning restore 1591