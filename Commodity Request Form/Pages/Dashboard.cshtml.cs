using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Commodity_Request_Form.Data;
using Commodity_Request_Form.Models;

namespace Commodity_Request_Form.Pages
{
    public class DashboardModel : PageModel
    {
        private readonly DataContext _context;

        public int TotalCHAs { get; set; }
        public int TotalCHWs { get; set; }
        public int TotalRequests { get; set; }
        public List<Commodity> RecentRequests { get; set; }

        public DashboardModel(DataContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            TotalCHAs = await _context.CHA.CountAsync();
            TotalCHWs = await _context.CHW.CountAsync();
            TotalRequests = await _context.Commodity.CountAsync();

            RecentRequests = await _context.Commodity
                .Include(c => c.CHW)
                .OrderByDescending(c => c.DateRequested)
                .Take(5)
                .ToListAsync();
        }
    }
}
