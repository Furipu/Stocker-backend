﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IStockerService
    {
        List<StatusModel> GetAllStatuses();
        StatusModel GetStatusById(int id);
        int CreateStatus(StatusModel status);
        void UpdateStatus(StatusModel status);
        void DeleteStatus(int id);
        List<BrandModel> GetAllBrands();
        BrandModel GetBrandById(int id);
        int CreateBrand(BrandModel brand);
        void UpdateBrand(BrandModel brand);
        void DeleteBrand(int id);        
        List<SupplierModel> GetAllSuppliers();
        SupplierModel GetSupplierById(int id);
        int CreateSupplier(SupplierModel supplier);
        void UpdateSupplier(SupplierModel supplier);
        void DeleteSupplier(int id);
        List<QualityModel> GetAllQualities();
        QualityModel GetQualityById(int id);
        int CreateQuality(QualityModel quality);
        void UpdateQuality(QualityModel quality);
        void DeleteQuality(int id);
        List<CountryModel> GetAllCountries();        
        CountryModel GetCountryById(int id);
        int CreateCountry(CountryModel country);
        void UpdateCountry(CountryModel country);
        void DeleteCountry(int id);
        List<PostCityModel> GetAllPostCities();
        PostCityModel GetPostCityById(int id);
        int CreatePostCity(PostCityModel postCity);
        void UpdatePostCity(PostCityModel postCity);
        void DeletePostCity(int id);
        List<CategoryModel> GetAllCategories();
        CategoryModel GetCategoryById(int id);
        int CreateCategory(CategoryModel category);
        void UpdateCategory(CategoryModel category);
        void DeleteCategory(int id);
        List<LocationModel> GetAllLocations();
        LocationModel GetLocationById(int id);
        int CreateLocation(LocationModel location);
        void UpdateLocation(LocationModel location);
        void DeleteLocation(int id);
        List<ProductModel> GetAllProducts();
        ProductModel GetProductById(int id);
        int CreateProduct(ProductModel location);
        void UpdateProduct(ProductModel location);
        void DeleteProduct(int id);
        List<MetricModel> GetAllMetrics();
        MetricModel GetMetricById(int id);
        int CreateMetric(MetricModel location);
        void UpdateMetric(MetricModel location);
        void DeleteMetric(int id);
    }
}