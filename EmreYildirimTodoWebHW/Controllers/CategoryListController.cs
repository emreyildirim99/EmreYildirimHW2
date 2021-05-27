using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmreYildirimTodoWebHW.Data;
using EmreYildirimTodoWebHW.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmreYildirimTodoWebHW.Controllers
{
    public class CategoryListController
    {
        private readonly ApplicationDbContext _context;
        public CategoryListController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetListOfCategories()
        {
            var query = _context.Categories;

            List<Category> result = await query.ToListAsync();
            
            return result;
        }
    }
}