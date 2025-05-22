using Commodity_Request_Form.Data;
using Commodity_Request_Form.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Commodity_Request_Form.Pages.Commodities
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _context;

        public IndexModel(DataContext context)
        {
            _context = context;
        }

        public IList<Commodity> Commodities { get; set; }

        public async Task OnGetAsync()
        {
            Commodities = await _context.Commodity
                .Include(c => c.CHA)
                .Include(c => c.CHW)
                .ToListAsync();
        }
    }
}
