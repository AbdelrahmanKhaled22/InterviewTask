using InterviewTask.Data;
using InterviewTask.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InterviewTask.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvoicesController(ApplicationDbContext context)
        {

        _context = context;
            
        }
        public async Task<IActionResult> Index()
        {
            
            return View(await _context.invoiceDetails.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(InvoiceDetails invoice)
        {
            if (invoice != null)
            {
                if (ModelState.IsValid)
                {

                    var newunit = new Unit();
                    _context.Units.Add(newunit);
                    await _context.SaveChangesAsync();
                    invoice.unitNo = newunit.unitNo;
                    invoice.total = invoice.price * (int)invoice.quantity;
                    _context.invoiceDetails.Add(invoice);
                    await _context.SaveChangesAsync();
                    RedirectToAction("Index");

                }

            }
            return View(invoice);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int lineNo) 
        {

            var invoice = await _context.invoiceDetails.FindAsync(lineNo);

            return View(invoice);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(InvoiceDetails invoice)
        {
            if (ModelState.IsValid)
            {
                _context.invoiceDetails.Update(invoice);
                await _context.SaveChangesAsync();
                RedirectToAction("Index");


            }
            return View(invoice);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int lineNo)
        {
            var invoice = await _context.invoiceDetails.FindAsync(lineNo);

            return View(invoice);
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int lineNo)
        {
            var invoice = await _context.invoiceDetails.FindAsync(lineNo);
            _context.invoiceDetails.Remove(invoice);
            RedirectToAction("Index");
            return View("Delete",invoice);
        }

    }
}
