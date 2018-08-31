using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using System.Data.Entity;
using System.Reflection;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;


namespace MySolution.Module {
    public sealed partial class MySolutionModule : ModuleBase {
        public MySolutionModule() {
            InitializeComponent();
            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseIfModelChanges<MyDbContext>());
       }

        public override void CustomizeTypesInfo(ITypesInfo typesInfo)
        {
            base.CustomizeTypesInfo(typesInfo);

            //typesInfo.LoadTypes(Assembly.LoadFrom("MySolution.Module.D2.dll"));

            //typesInfo.RefreshInfo(typeof(Employee));

            typesInfo.FindTypeInfo(typeof(Task)).AddAttribute(new DefaultClassOptionsAttribute());
            typesInfo.FindTypeInfo(typeof(Employee)).AddAttribute(new DefaultClassOptionsAttribute());
            
            //typesInfo.RefreshInfo(typeof(Task));
        }

        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
    }
}
