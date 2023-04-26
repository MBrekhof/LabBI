using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.Persistent.Validation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

// preferred way to define a Key
namespace LabBI.Module.BusinessObjects
{
    public abstract class BaseObjectInt : IXafEntityObject, IObjectSpaceLink
    {
        protected IObjectSpace ObjectSpace;

        //
        // Summary:
        //     The key property for the DevExpress.Persistent.BaseImpl.EF.BaseObject class.
        [Key]
        [VisibleInListView(false)]
        [VisibleInDetailView(false)]
        [VisibleInLookupListView(false)]
        public virtual int ID { get; set; }

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
