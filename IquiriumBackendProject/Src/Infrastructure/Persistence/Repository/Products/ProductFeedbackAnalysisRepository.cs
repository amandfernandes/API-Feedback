﻿using IqueiriumBackendProject.Src.Domain.Entities.ProductEntities;
using IqueiriumBackendProject.Src.Infrastructure.Data;
using IqueiriumBackendProject.Src.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;

namespace IqueiriumBackendProject.Src.Infrastructure.Persistence.Repository.Products
{
    public class ProductFeedbackAnalysisRepository : BaseRepository<ProductFeedbackAnalysis>
    {
        public ProductFeedbackAnalysisRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
