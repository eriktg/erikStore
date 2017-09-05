using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using erikStore.Models;

namespace erikStore.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<erikStoreContext>
    {
        protected override void Seed(erikStoreContext context)
        {

        }
    }
}