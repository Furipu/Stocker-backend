using Contracts;
using Entities;

namespace Repository
{

    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IAdressRepository _adress;
        private IBrandRepository _brand;
        private ICategoryRepository _category;
        private ICountryRepository _country;
        private ILocationRepository _location;
        private IPostCityRepository _postCity;
        private IPriceHistoryRepository _priceHistory;
        private IProductRepository _product;
        private IProductVersionRepository _productVersion;
        private IQualityRepository _quality;
        private IStatusRepository _status;
        private ISupplierRepository _supplier;
        private IMetricRepository _metric;
        private IShopCartRepository _shopCart;

        public IAdressRepository Adress
        {
            get
            {
                if (_adress == null)
                {
                    _adress = new AdressRepository(_repoContext);
                }

                return _adress;
            }
        }

        public IBrandRepository Brand
        {
            get
            {
                if (_brand == null)
                {
                    _brand = new BrandRepository(_repoContext);
                }

                return _brand;
            }
        }
        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_repoContext);
                }

                return _category;
            }
        }
        public ICountryRepository Country
        {
            get
            {
                if (_country == null)
                {
                    _country = new CountryRepository(_repoContext);
                }

                return _country;
            }
        }
        public ILocationRepository Location
        {
            get
            {
                if (_location == null)
                {
                    _location = new LocationRepository(_repoContext);
                }

                return _location;
            }
        }
        public IPostCityRepository PostCity
        {
            get
            {
                if (_postCity == null)
                {
                    _postCity = new PostCityRepository(_repoContext);
                }

                return _postCity;
            }
        }
        public IPriceHistoryRepository PriceHistory
        {
            get
            {
                if (_priceHistory == null)
                {
                    _priceHistory = new PriceHistoryRepository(_repoContext);
                }

                return _priceHistory;
            }
        }
        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_repoContext);
                }

                return _product;
            }
        }
        public IProductVersionRepository ProductVersion
        {
            get
            {
                if (_productVersion == null)
                {
                    _productVersion = new ProductVersionRepository(_repoContext);
                }

                return _productVersion;
            }
        }
        public IQualityRepository Quality
        {
            get
            {
                if (_quality == null)
                {
                    _quality = new QualityRepository(_repoContext);
                }

                return _quality;
            }
        }
        public IStatusRepository Status
        {
            get
            {
                if (_status == null)
                {
                    _status = new StatusRepository(_repoContext);
                }

                return _status;
            }
        }
        public ISupplierRepository Supplier
        {
            get
            {
                if (_supplier == null)
                {
                    _supplier = new SupplierRepository(_repoContext);
                }

                return _supplier;
            }
        }

        public IMetricRepository Metric
        {
            get
            {
                if (_metric == null)
                {
                    _metric = new MetricRepository(_repoContext);
                }

                return _metric;
            }
        }
        public IShopCartRepository ShopCart
        {
            get
            {
                if (_shopCart == null)
                {
                    _shopCart = new ShopCartRepository(_repoContext);
                }

                return _shopCart;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }

        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
