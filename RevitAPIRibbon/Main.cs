using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevitAPIRibbon
{
    [Transaction(TransactionMode.Manual)]
    public class Main : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            string panelName = "Elem";
            string tabName = "RevitAPITest";
            application.CreateRibbonTab(tabName);
            string utilsFolderPath = @"C:\Program Files\RevitAPITrainig\";

            var panel = application.CreateRibbonPanel(tabName, panelName);

            var button = new PushButtonData("Type", "Change Type", Path.Combine(utilsFolderPath, "RevitAPIWallsTypeChange.dll"), "RevitAPIWallsTypeChange.main");

            panel.AddItem(button);
            return Result.Succeeded;
        }
    }
}
