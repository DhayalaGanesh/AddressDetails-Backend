using AddressDetails.Db.Ef.Models;

namespace AddressDetails.Db.Ef.DataQuery
{
    public interface ILocationTable
    {
        Location[] GetAllAddresses();
    }
}
