using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using OrderManagement.Models;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;

namespace OrderManagement.Controllers
{
    //[Authorize()]
    public class OrdersController : Controller
    {
        private readonly SysContext _context;

        public OrdersController(SysContext context)
        {
            _context = context;
        }

        public ActionResult TableEdit() {
            return View();

        }


        public ActionResult Total()
        {

            return View();
        }
        // GET: Orders
        public async Task<IActionResult> Index()
        {
            /*  var query = _context.Orders.GroupBy(o => new { o.OrderName })
       .Select(g => new
       {
           g.Key.OrderName,
           Sum = g.Sum(o => o.Amount)
       });*/
            //var denemee = _context.Orders.FromSql(" Select sum(Amount), OrderName from dbo.Orders where TableID = '4').ToList<Order>();
            var veri = await _context.Orders.OrderBy(x=>x.TableID).ToListAsync();
            return View(veri);
        }

        public async Task<IActionResult> OrderPage()
        {
            return View(await _context.Orders.ToListAsync());
        }


        public ActionResult Det(int? id)   //order listeleme ve 
        {

            TempData["TableNo"] = id;
            ViewBag.Table = id;
            if (id == null) {
                return NotFound();
            
            }
           
            
            //var groupedData = _context.Orders.FromSql<Order>("SELECT SUM(Amount) as Amount, OrderName WHERE TableID = {0} GROUP BY OrderName; " , id) ;

            //IEnumerable<Order> results = _context.ExecuteQuery<Order>("SELECT SUM(Amount) as Amount, OrderName WHERE TableID = {0} GROUP BY OrderName; ", data);
            /* var groupedData = from p in _context.Orders
                              group p by p.OrderName into g
                              select new { OrderName = g.Key, Amount = g.Sum(y => y.Amount) }; */

            //var dene = _context.Orders.GroupBy(y => y.OrderName).Sum(y => y.Amount);


            /* var groupedData = _context.Orders.
                                GroupBy(y => y.OrderName)
                                      .Select(x =>
                                            new
                                            {
                                                OrderName = x.Key,
                                                Amount = x.Sum(y => y.Amount)
                                            }).toList();*/


            //IQueryable<Order> groupedData = _context.Orders.Where(m => m.TableID == id);

            //var groupedData = _context.Orders.Where(x => x.TableID == id).GroupBy(x => x.OrderName).Select(y => new { OrderName = y.Key, Amount = y.Sum(x=>x.Amount) });
            
            var groupedData = _context.Orders.Where(m => m.TableID == id);
            if (groupedData == null) {
                return NotFound();
            }
            // _context.Orders.Where(d => d.TableID == data.TableID).ToList();
            var check = _context.Orders.Where(m => m.TableID == id).Select(m => m.OrderName).FirstOrDefault();
            if (check == null)
            {
                return RedirectToAction("Create", new { id = id });
            }
            else
            {
                return View(groupedData);
            }
        }

        public ActionResult DeleteOrder(int? id)  
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var data = _context.Orders.First(k => k.OrderID == id);
            _context.Orders.Remove(data);
            _context.SaveChanges();
            return RedirectToAction("OrderPage");
        }

       
        public ActionResult EdTable(Order item)
        {

            var data = _context.Orders.FirstOrDefault(x => x.OrderID == item.OrderID);
                if(data != null)
            {
                data.Amount = item.Amount;
                _context.Update(data);
                _context.SaveChanges();
                return RedirectToAction("Det", new { id = item.TableID });
            }

            return RedirectToAction("OrderPage");
       
        }

        public ActionResult price(int id) {

            var data = _context.Orders.Where(x => x.TableID == id).Select(s => new { s.OrderName, s.Amount }).ToList();

            //var data = _context.Orders.SqlQuery<Order>("Select * from Orders").Where(i => i.TableID == id).ToList();
           // var x = _context.Orders.Where(y => y.OrderName == data ).Select(o => o.Amount).ToList();
            int total = 0;
           // string prices = " ";
           // int i = 0;
            if (data != null) {
                foreach (var item in data)  // data ordername içeriyor 
                {
                    //var z = _context.Menus.Where(o => o.FoodName == item.OrderName).Select(o => o.Price).First();
                    
                    var y = _context.Menus.FirstOrDefault(x => x.FoodName == item.OrderName);
                    total = total + (y.Price * item.Amount);  //y.Price
                   /// prices.Insert(i++, "y.Price");
                    


                }

               var allData = _context.Orders.Where(m => m.TableID == id).ToList();
                //ViewBag.mumu = prices;
                TempData["TableN"] = id;
                TempData["fiyat"] = total;
                return View(allData);
            }
            return View("OrderPage");

        }

      
        public async Task<IActionResult> Details(int? id )
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        // GET: Orders/Create
       /* private bool FoodExists(string food, int id)
        {
            var sonuc = _context.Orders.Where(x=>x.TableID==id && x.OrderName==food).FirstOrDefault();
            return (sonuc);

        }*/

        public IActionResult Create(int? id)  
        {
            TempData["dene"] = id;
            if (id == null) {
                return NotFound();
            }
            var yemekListesi = _context.Menus.Where(x => x.Type.Equals("Pizza")).Select(x => x.FoodName  ).ToList();  //duzenle
            ViewBag.pizza = yemekListesi;
            var yemekListesi1 = _context.Menus.Where(x => x.Type.Equals("Breakfast")).Select(x => x.FoodName).ToList();  //duzenle
            ViewBag.breakfast = yemekListesi1;
            var yemekListesi2 = _context.Menus.Where(x => x.Type.Equals("Dessert")).Select(x => x.FoodName).ToList();  //duzenle
            ViewBag.dessert = yemekListesi2;
            var yemekListesi3 = _context.Menus.Where(x => x.Type.Equals("Drink")).Select(x => x.FoodName).ToList();  //duzenle
            ViewBag.drink= yemekListesi3;
            var yemekListesi4 = _context.Menus.Where(x => x.Type.Equals("Burger")).Select(x => x.FoodName).ToList();  //duzenle
            ViewBag.burger = yemekListesi4;
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TableID,OrderID,OrderName,Amount")] Order order)
        {  //hata var pancake dene
            
            //int table = @ViewBag.TableNo;
            if (ModelState.IsValid)
            {
                var sonuc = _context.Orders.FirstOrDefault(x => x.TableID == order.TableID && x.OrderName.Equals(order.OrderName));
                
                //if (!FoodExists(order.OrderName, order.TableID))
                if(sonuc == null)
                {
                    _context.Add(order);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Det", new { id = order.TableID });
                    //return View("Create");
                }
                else
                {
                    var deneme = _context.Orders.Where(x => x.OrderName == order.OrderName && x.TableID == order.TableID).FirstOrDefault();
                    deneme.Amount += order.Amount;
                    _context.Update(deneme);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Det", new { id = order.TableID });
                }
                    
                    
            }
            return View(order);
        }

        /*public ActionResult Bill(int? id) {
            

            
            return View();
        }*/

        // GET: Orders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,TableID,OrderName,Amount")] Order order)
        {
            if (id != order.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

       

       
        public ActionResult DeleteTable(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = _context.Orders.Where(x => x.TableID == id).ToList();
            //var data = _context.Orders.SqlQuery<Order>("Select * from Orders").Where(i => i.TableID == id).ToList();

            foreach (var item in data)
            {
                _context.Orders.Remove(item);

            }
                _context.SaveChanges();

                return View("OrderPage");
        }

        
     
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var order = await _context.Orders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

     
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderID == id);
        }

        private bool TableExists(int id)
        {
            return _context.Orders.Any(e => e.TableID == id);

        }

        
    }
}
