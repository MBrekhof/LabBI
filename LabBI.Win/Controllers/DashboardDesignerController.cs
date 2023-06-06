using DevExpress.DashboardWeb;
using DevExpress.DataAccess.UI.Native.Sql.QueryBuilder;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Dashboards.Blazor.Components;
using DevExpress.ExpressApp.Dashboards.Blazor.Components.Models;
using DevExpress.Persistent.Base;

namespace LabBI.Win.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public class BlazorDashboardController : ObjectViewController<DetailView, IDashboardData>
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
                SetWorkingMode(dashboardViewerAdapter.ComponentModel);
                
            }
        }
        private void SetWorkingMode(DxDashboardModel dxDashboardModel)
        {
            dxDashboardModel.WorkingMode = WorkingMode.Designer;
        }
    }
}
