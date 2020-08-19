using AddressDetails.Db.Ef.DataQuery;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AddressDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressDetails : ControllerBase
    {
        private readonly ILocationTable _locationTable;
        public AddressDetails(ILocationTable locationTable)
        {
            _locationTable = locationTable;
        }
        [HttpGet("search")]
        public AddressDetailsViewModel[] Search(string searchTerm)
        {
            AddressDetailsViewModel[] addressDetailsViewModels= _locationTable.GetAllAddresses().Select(x=>new AddressDetailsViewModel {
                State=x.State,
                City=x.City,
                Address=x.Address,
                Zip=x.ZipCode
            }).ToArray();

            return addressDetailsViewModels;
        }

        [HttpPost("Insert")]
        public JsonResult Insert()
        {
            return new JsonResult("Success") { StatusCode = 200 };
        }
    }
}
