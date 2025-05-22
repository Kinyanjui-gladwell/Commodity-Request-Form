using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commodity_Request_Form.Data;
using Commodity_Request_Form.Enums;
using Commodity_Request_Form.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Commodity_Request_Form.Pages.Commodities
{
    public class CreateModel : PageModel
    {
        private readonly DataContext _context;

        public CreateModel(DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Commodity Commodity { get; set; }

        public List<CHW> CHWs { get; set; }
        public List<SelectListItem> CHWList { get; set; }
        public List<SelectListItem> CommodityList { get; set; }
        public List<SelectListItem> StatusList { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            await LoadLists();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Commodity.Quantity < 1 || Commodity.Quantity >= 100)
            {
                ModelState.AddModelError(nameof(Commodity.Quantity), "Quantity must be a whole number less than 100.");
            }

            if (!ModelState.IsValid)
            {
                await LoadLists();
                return Page();
            }

            var today = DateTime.Today;

            // 1. Check for duplicate request per CHW + commodity + date
            bool duplicateRequestToday = await _context.Commodity.AnyAsync(c =>
                c.CHW_ID == Commodity.CHW_ID &&
                c.Name == Commodity.Name &&
                c.DateRequested.Date == today
            );

            if (duplicateRequestToday)
            {
                ModelState.AddModelError(string.Empty, "A request for this commodity by the same CHW has already been submitted today.");
                await LoadLists();
                return Page();
            }

            // 2. Check for monthly 200 unit cap per commodity per CHW
            var startOfMonth = new DateTime(today.Year, today.Month, 1);
            var endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);

            int totalThisMonth = await _context.Commodity
                .Where(c =>
                    c.CHW_ID == Commodity.CHW_ID &&
                    c.Name == Commodity.Name &&
                    c.DateRequested >= startOfMonth &&
                    c.DateRequested <= endOfMonth)
                .SumAsync(c => (int?)c.Quantity) ?? 0;

            if (totalThisMonth + Commodity.Quantity > 200)
            {
                int remaining = 200 - totalThisMonth;
                ModelState.AddModelError(nameof(Commodity.Quantity), $"Monthly limit exceeded. You may only request {remaining} more units of this commodity.");
                await LoadLists();
                return Page();
            }

            // 3. Assign CHA and date
            var chw = await _context.CHW.Include(c => c.CHA).FirstOrDefaultAsync(c => c.CHW_ID == Commodity.CHW_ID);
            if (chw == null)
            {
                ModelState.AddModelError(nameof(Commodity.CHW_ID), "Invalid CHW selected.");
                await LoadLists();
                return Page();
            }

            Commodity.CHA_ID = chw.CHA_ID;
            Commodity.DateRequested = today;

            _context.Commodity.Add(Commodity);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        private async Task LoadLists()
        {
            CHWs = await _context.CHW.Include(c => c.CHA).ToListAsync();

            CHWList = CHWs.Select(c => new SelectListItem
            {
                Value = c.CHW_ID.ToString(),
                Text = $"{c.F_Name} {c.L_Name}"
            }).ToList();

            CommodityList = await _context.Commodity
                .Select(c => c.Name)
                .Distinct()
                .Select(name => new SelectListItem
                {
                    Value = name,
                    Text = name
                }).ToListAsync();

            StatusList = Enum.GetValues(typeof(RequestStatus))
                .Cast<RequestStatus>()
                .Select(s => new SelectListItem
                {
                    Value = s.ToString(),
                    Text = s.ToString()
                }).ToList();
        }
    }
}
