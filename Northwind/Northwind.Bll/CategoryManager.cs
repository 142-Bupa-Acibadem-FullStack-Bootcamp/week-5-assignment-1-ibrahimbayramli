using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Northwind.Entity.IBase;

namespace Northwind.Bll
{
    public class CategoryManager : BllBase<Category, DtoCategory>, ICategoryService
    {
        public readonly ICategoryRepository categoryRepository;
        public CategoryManager(IServiceProvider service) : base(service)
        {
            categoryRepository = service.GetService<ICategoryRepository>();
        }

        public IQueryable CategoryReport()
        {
            return categoryRepository.CategoryReport();
        }

        public IResponse<List<DtoCategory>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResponse<List<DtoCategory>> GetAll(Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IResponse<DtoCategory> Find(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetIQueryable()
        {
            throw new NotImplementedException();
        }

        public IResponse<DtoCategory> Add(DtoCategory item, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<DtoCategory> AddAsync(DtoCategory item)
        {
            throw new NotImplementedException();
        }

        public DtoCategory Update(DtoCategory item)
        {
            throw new NotImplementedException();
        }

        public Task<DtoCategory> UpdateAsync(DtoCategory item)
        {
            throw new NotImplementedException();
        }

        public IResponse<bool> DeleteById(int id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public bool Delete(DtoCategory item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(DtoCategory item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }

    public class BllBase<T, T1>
    {
        protected BllBase(IServiceProvider service)
        {
            throw new NotImplementedException();
        }
    }
}
