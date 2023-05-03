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

namespace LabBI.Module.BusinessObjects
{
    // Register this entity in your DbContext (usually in the BusinessObjects folder of your project) with the "public virtual DbSet<AI_TableObject> AI_TableObjects { get; set; }" syntax.
    [DefaultClassOptions]

    // (see https://learn.microsoft.com/en-us/ef/core/change-tracking/change-detection#change-tracking-proxies for details).
    public  class AI_TableObject : BaseObjectInt
    {
        public  AI_TableObject()
        {
            // In the constructor, initialize collection properties, e.g.: 
            // this.AssociatedEntities = new ObservableCollection<AssociatedEntityObject>();
        }

        [StringLength(50)]
        public virtual String TableName { get; set; }

        public virtual String DDL { get; set; }

        public virtual String Additional { get; set; }


    }
}