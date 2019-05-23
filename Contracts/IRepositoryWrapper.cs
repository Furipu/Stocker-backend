using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IAdressRepository Adress { get; }
        IBrandRepository Brand { get; }
        ICategoryRepository Category { get; }
        ICountryRepository Country { get; }
        ILocationRepository Location { get; }
        IPostCityRepository PostCity { get; }
        IPriceHistoryRepository PriceHistory { get; }
        IProductRepository Product { get; }
        IProductVersionRepository ProductVersion { get; }
        IQualityRepository Quality { get; }
        IStatusRepository Status { get; }
        ISupplierRepository Supplier { get; }
        IMetricRepository Metric { get; }
        IShopCartRepository ShopCart { get; }
        void Save();
    }
}
