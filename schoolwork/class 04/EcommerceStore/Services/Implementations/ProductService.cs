﻿using Data_Access.Interfaces;
using DomainModels;
using DTOs.Product;
using Services.Interfaces;
using Services.Mappers;

namespace Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        public bool Add(CreateProductDto entity) => _repository.Add(entity.ToModel());

        public bool DeleteById (int id) => _repository.Any(id) && _repository.DeleteById(id);

        public IEnumerable<ProductDto> GetAll() => _repository.GetAll().Select(x => x.ToModel()).ToList();

        public Product GetById(int id) => _repository.GetById(id);

        public bool Update(CreateProductDto entity, Product found) => _repository.Update(entity.ToModel(found));
    }
}
