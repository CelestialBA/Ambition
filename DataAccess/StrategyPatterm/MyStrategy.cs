using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StrategyPatterm
{
    public class MyStrategy: DropCreateDatabaseIfModelChanges<CelestialEntities>
    {
        protected override void Seed(CelestialEntities context)
        {
            //base.Seed(context);
            //Model değişirse silip yeniden yaratmasını sağlayan sınıfımız DropCreateDatabaseIfModelChanges sınıfıdır. Bu sınıf sizden bir generic tip ister. Bu da hangi context sınıfı ile tanımlama yaptıysanız o contexti vermek zorundasınız.
        }
    }
}
