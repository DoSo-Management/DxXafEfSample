using System;
using System.Collections.Generic;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp.EF;
using System.Data.Entity;


namespace MySolution.Module {
    public sealed partial class MySolutionModule : ModuleBase {
        public MySolutionModule() {
            InitializeComponent();
            Database.SetInitializer<MyDbContext>(new DropCreateDatabaseIfModelChanges<MyDbContext>());
       }
        public override IEnumerable<ModuleUpdater> GetModuleUpdaters(IObjectSpace objectSpace, Version versionFromDB) {
            ModuleUpdater updater = new Updater(objectSpace, versionFromDB);
            return new ModuleUpdater[] { updater };
        }
    }
}
