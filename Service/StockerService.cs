using Contracts;
using Domain;
using Service.Brand;
using Service.Category;
using Service.Country;
using Service.Location;
using Service.User;
using Service.Metric;
using Service.PostCity;
using Service.Product;
using Service.ProductVersion;
using Service.Quality;
using Service.Status;
using Service.Supplier;
using System.Collections.Generic;
using System.Threading.Tasks;
using Service.ShopCart;

namespace Service
{
    public class StockerService : IStockerService
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repository;
        private IUserRepository _userRepo;

        public StockerService(ILoggerManager logger, IRepositoryWrapper repository, IUserRepository userRepo)
        {
            _logger = logger;
            _repository = repository;
            _userRepo = userRepo;
        }
        #region Status
        public List<Domain.StatusModel> GetAllStatuses()
        {
            return new GetAllStatusOperation(_repository).Execute();
        }

        public Domain.StatusModel GetStatusById(int id)
        {
            return new GetStatusByIdOperation(_repository).Execute(id);
        }

        public int CreateStatus(Domain.StatusModel status)
        {
           return new SaveStatusOperation(_repository).Execute(status);
        }

        public void UpdateStatus(Domain.StatusModel status)
        {
            new UpdateStatusOperation(_repository).Execute(status);
        }
        public void DeleteStatus(int id)
        {
            new DeleteStatusOperation(_repository).Execute(id);
        }
        #endregion
        #region Brand
        public List<Domain.BrandModel> GetAllBrands()
        {
            return new GetAllBrandOperation(_repository).Execute();
        }
        public Domain.BrandModel GetBrandById(int id)
        {
            return new GetBrandByIdOperation(_repository).Execute(id);
        }

        public int CreateBrand(BrandModel brand)
        {
            return new SaveBrandOperation(_repository).Execute(brand);
        }

        public void UpdateBrand(BrandModel brand)
        {
            new UpdateBrandOperation(_repository).Execute(brand);
        }
        public void DeleteBrand(int id)
        {
            new DeleteBrandOperation(_repository).Execute(id);
        }
        #endregion     
        #region Supplier
        public List<Domain.SupplierModel> GetAllSuppliers()
        {
            return new GetAllSupplierOperation(_repository).Execute();
        }
        public Domain.SupplierModel GetSupplierById(int id)
        {
            return new GetSupplierByIdOperation(_repository).Execute(id);
        }

        public int CreateSupplier(Domain.SupplierModel supplier)
        {
            return new SaveSupplierOperation(_repository).Execute(supplier);
        }

        public void UpdateSupplier(Domain.SupplierModel supplier)
        {
            new UpdateSupplierOperation(_repository).Execute(supplier);
        }
        public void DeleteSupplier(int id)
        {
            new DeleteSupplierOperation(_repository).Execute(id);
        }
        #endregion
        #region Quality
        public List<QualityModel> GetAllQualities()
        {
            return new GetAllQualityOperation(_repository).Execute();
        }
        public QualityModel GetQualityById(int id)
        {
            return new GetQualityByIdOperation(_repository).Execute(id);
        }

        public int CreateQuality(QualityModel quality)
        {
            return new SaveQualityOperation(_repository).Execute(quality);
        }

        public void UpdateQuality(QualityModel quality)
        {
            new UpdateQualityOperation(_repository).Execute(quality);
        }
        public void DeleteQuality(int id)
        {
            new DeleteQualityOperation(_repository).Execute(id);
        }
        #endregion
        #region PostCity
        public List<Domain.PostCityModel> GetAllPostCities()
        {
            return new GetAllPostCityOperation(_repository).Execute();
        }
        public PostCityModel GetPostCityById(int id)
        {
            return new GetPostCityByIdOperation(_repository).Execute(id);
        }

        public int CreatePostCity(PostCityModel postCity)
        {
            return new SavePostCityOperation(_repository).Execute(postCity);
        }

        public void UpdatePostCity(PostCityModel postCity)
        {
            new UpdatePostCityOperation(_repository).Execute(postCity);
        }
        public void DeletePostCity(int id)
        {
            new DeletePostCityOperation(_repository).Execute(id);
        }
        #endregion
        #region Country
        public List<CountryModel> GetAllCountries()
        {
            return new GetAllCountryOperation(_repository).Execute();
        }
        public CountryModel GetCountryById(int id)
        {
            return new GetCountryByIdOperation(_repository).Execute(id);
        }

        public int CreateCountry(CountryModel country)
        {
            return new SaveCountryOperation(_repository).Execute(country);
        }

        public void UpdateCountry(CountryModel country)
        {
            new UpdateCountryOperation(_repository).Execute(country);
        }
        public void DeleteCountry(int id)
        {
            new DeleteCountryOperation(_repository).Execute(id);
        }
        #endregion
        #region Category
        public List<CategoryModel> GetAllCategories()
        {
            return new GetAllCategoryOperation(_repository).Execute();
        }
        public CategoryModel GetCategoryById(int id)
        {
            return new GetCategoryByIdOperation(_repository).Execute(id);
        }

        public int CreateCategory(CategoryModel category)
        {
            return new SaveCategoryOperation(_repository).Execute(category);
        }

        public void UpdateCategory(CategoryModel category)
        {
            new UpdateCategoryOperation(_repository).Execute(category);
        }
        public void DeleteCategory(int id)
        {
             new DeleteCategoryOperation(_repository).Execute(id);
        }
        #endregion
        #region Location
        public List<LocationModel> GetAllLocations()
        {
            return new GetAllLocationOperation(_repository).Execute();
        }
        public LocationModel GetLocationById(int id)
        {
            return new GetLocationByIdOperation(_repository).Execute(id);
        }

        public int CreateLocation(LocationModel location)
        {
            return new SaveLocationOperation(_repository).Execute(location);
        }

        public void UpdateLocation(LocationModel location)
        {
            new UpdateLocationOperation(_repository).Execute(location);
        }
        public void DeleteLocation(int id)
        {
            new DeleteLocationOperation(_repository).Execute(id);
        }
        #endregion
        #region Product
        public List<ProductModel> GetAllProducts()
        {
            return new GetAllProductOperation(_repository).Execute();
        }
        public ProductModel GetProductById(int id)
        {
            return new GetProductByIdOperation(_repository).Execute(id);
        }

        public int CreateProduct(ProductModel location)
        {
            return new SaveProductOperation(_repository).Execute(location);
        }

        public void UpdateProduct(ProductModel location)
        {
            new UpdateProductOperation(_repository).Execute(location);
        }
        public void DeleteProduct(int id)
        {
            new DeleteProductOperation(_repository).Execute(id);
        }
        #endregion
        #region Metric
        public List<MetricModel> GetAllMetrics()
        {
            return new GetAllMetricOperation(_repository).Execute();
        }
        public MetricModel GetMetricById(int id)
        {
            return new GetMetricByIdOperation(_repository).Execute(id);
        }

        public int CreateMetric(MetricModel location)
        {
            return new SaveMetricOperation(_repository).Execute(location);
        }

        public void UpdateMetric(MetricModel location)
        {
            new UpdateMetricOperation(_repository).Execute(location);
        }
        public void DeleteMetric(int id)
        {
            new DeleteMetricOperation(_repository).Execute(id);
        }
        #endregion
        #region ProductVersion
        public List<ProductVersionModel> GetAllProductVersions()
        {
            return new GetAllProductVersionOperation(_repository).Execute();
        }
        public ProductVersionModel GetProductVersionId(int id)
        {
            return new GetProductVersionByIdOperation(_repository).Execute(id);
        }

        public int CreateProductVersion(ProductVersionModel productVersionModel)
        {
            return new SaveProductVersionOperation(_repository).Execute(productVersionModel);
        }

        public void UpdateProductVersion(ProductVersionModel productVersionModel)
        {
            new UpdateProductVersionOperation(_repository).Execute(productVersionModel);
        }
        public void DeleteProductVersion(int id)
        {
            new DeleteProductVersionOperation(_repository).Execute(id);
        }
        #endregion
        #region User
        public async Task<List<UserModel>> GetAllUsers()
        {
            return await new GetAllUsersOperation(_userRepo).Execute();
        }
        public async Task<UserModel> GetUserById(string id)
        {
            return await new GetUserByIdOperation(_userRepo).Execute(id);
        }

        public void CreateUser(UserModel userModel)
        {
            new SaveUserOperation(_userRepo).Execute(userModel);
        }

        public void UpdateUser(UserModel userModel)
        {
            new UpdateUserOperation(_userRepo).Execute(userModel);
        }
        public void DeleteUser(string id)
        {
            new DeleteUserOPeration(_userRepo).Execute(id);
        }
        #endregion
        #region ShopCart
        public List<ShopCartModel> GetAllShopCarts()
        {
            return new GetAllShopCartOperation(_repository).Execute();
        }
        public ShopCartModel GetShopCartId(int id)
        {
            return new GetShopCartByIdOperation(_repository).Execute(id);
        }
        public ShopCartModel GetOrCreateShopCartByProductID(int id)
        {
            return new GetOrCreateShopCartByProductIdOperation(_repository).Execute(id);
        }
        public int CreateOrUpdateShopCart(ShopCartModel shopCartModel)
        {
            return new SaveOrUpdateShopCartOperation(_repository).Execute(shopCartModel);
        }

        public void UpdateShopCart(ShopCartModel shopCartModel)
        {
            new UpdateShopCartOperation(_repository).Execute(shopCartModel);
        }
        public void DeleteShopCart(int id)
        {
            new DeleteShopCartOperation(_repository).Execute(id);
        }
        #endregion
    }
}
