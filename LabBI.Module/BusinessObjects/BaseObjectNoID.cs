using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using System.ComponentModel.DataAnnotations;

// if the key is an int, you can use this snippet

namespace LabBI.Module.BusinessObjects
{
    public abstract class BaseObjectNoID : IXafEntityObject, IObjectSpaceLink
    {
        protected IObjectSpace ObjectSpace;


        IObjectSpace IObjectSpaceLink.ObjectSpace
        {
            get
            {
                return ObjectSpace;
            }
            set
            {
                ObjectSpace = value;
            }
        }

        //
        // Summary:
        //     Partially implements the DevExpress.ExpressApp.IXafEntityObject interface in
        //     the DevExpress.Persistent.BaseImpl.EF.BaseObject class.
        public virtual void OnCreated()
        {
        }

        //
        // Summary:
        //     Partially implements the DevExpress.ExpressApp.IXafEntityObject interface in
        //     the DevExpress.Persistent.BaseImpl.EF.BaseObject class.
        public virtual void OnSaving()
        {
        }

        //
        // Summary:
        //     Partially implements the DevExpress.ExpressApp.IXafEntityObject interface in
        //     the DevExpress.Persistent.BaseImpl.EF.BaseObject class.
        public virtual void OnLoaded()
        {
        }
    }
}
