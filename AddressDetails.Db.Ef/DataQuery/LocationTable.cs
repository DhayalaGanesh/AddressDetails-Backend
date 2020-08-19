using AddressDetails.Db.Ef.Models;
using System.Linq;

namespace AddressDetails.Db.Ef.DataQuery
{
    public class LocationTable: ILocationTable
    {
        private readonly AddressDetailsContext _dbContext;
        public LocationTable(AddressDetailsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Location[] GetAllAddresses()
        {
            Location[] locations = (from db in _dbContext.Location
                                    select db).ToArray();

            return locations;
        }
    }
}
