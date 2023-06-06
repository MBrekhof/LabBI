using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Dashboards.Blazor.Components.Models;
using DevExpress.ExpressApp.Dashboards.Blazor.Components;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabBI.Blazor.Server.Controllers
{
    public partial class BlazorDashboardController : ObjectViewController<DetailView, IDashboardData>
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            View.CustomizeViewItemControl<BlazorDashboardViewerViewItem>(this, CustomizeDashboardViewerViewItem);
        }
        void CustomizeDashboardViewerViewItem(BlazorDashboardViewerViewItem dashboardViewerViewItem)
        {
            if (dashboardViewerViewItem.Control is DxDashboardViewerAdapter dashboardViewerAdapter)
            {
                Customize(dashboardViewerAdapter.ComponentModel);

            }
        }
        private void Customize(DxDashboardModel dxDashboardModel)
        {
            dxDashboardModel.ChildContent = DashboardExtension.Create(dxDashboardModel.ChildContent);
        }
    }
}
