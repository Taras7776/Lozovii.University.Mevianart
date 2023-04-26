using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Lozovii.University.Mevianart.Models.Configuration;
using Lozovii.University.Mevianart.Models;
using Lozovii.University.Mevianart.Database.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Lozovii.University.Mevianart.Test
{
    [TestClass]
    public class PhoneTests : TestBase
    {
        IDbEntityService<Phone> _phoneService;
        IOptions<AppConfig> _configuration;

        public PhoneTests()
        {
            _phoneService = ResolveService<IDbEntityService<Phone>>();
            _configuration = ResolveService<IOptions<AppConfig>>();
        }

        [TestMethod]
        public async Task Create()
        {
            var phones = await _phoneService.Create(new Phone()
            {
                Id = 1,
                FirstName = "Test",
                LastName = 4,
                Email = "phone674@gmail.com",
                Password = "phone_password",
            });
        }

        [TestMethod]
        public async Task GetAllPhones()
        {
            var phones = await _phoneService.GetAll().ToListAsync();
        }
    }
}