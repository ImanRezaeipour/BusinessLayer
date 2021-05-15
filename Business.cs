using IR.DataAccessLayer;

namespace IR.BusinessLayer {
    public class Business {
        public Business()
        {Data.Config.Type = Data.Type.Sql;
            Persian.GetSession();
            Data person = new Data();
            Network.GetMacAddress();
            person.Field["id"] = "";
            person.Delete();
        }
        
    }
}
