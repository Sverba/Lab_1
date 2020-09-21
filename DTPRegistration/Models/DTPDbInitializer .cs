using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DTPRegistration.Models
{
    public class DTPDbInitializer: DropCreateDatabaseAlways<DTPContext>
    {
        protected override void Seed(DTPContext db)
        {
            db.Types.Add(new DTPType {Name = "Адміністративне" });
            db.Types.Add(new DTPType {Name = "Кримінальне" });
            base.Seed(db);
        }
    }
}