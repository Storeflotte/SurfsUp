﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SurfsUp.Models;

namespace SurfsUp.Controllers
{
    public class WetsuitController : Controller
    {
        private readonly IWetsuitRepository _wetsuitRepository;
        private readonly IBookingRepository _bookingRepository;
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public WetsuitController(IWetsuitRepository wetsuitRepository, IBookingRepository bookingRepository, AppDbContext context, UserManager<AppUser> userManager)
        {
            _wetsuitRepository = wetsuitRepository;
            _bookingRepository = bookingRepository;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var wetsuits = await _wetsuitRepository.GetAllWetsuits();

            return View(wetsuits);
        }

        //KEVIN

        // Handle booking submission
        [HttpPost]
        public async Task<IActionResult> Book(int wetsuitId, WetsuitSize pickSize, DateTime dateFrom, DateTime dateTo)
        {
            var wetsuit = await _wetsuitRepository.GetWetsuitById(wetsuitId);

            if (wetsuit == null)
            {
                ViewBag.ErrorMessage = "Våddragt eksisterer ikke.";
                return View("Index");
            }

            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;
            var name = user.Name;
            var email = user.Email;

            var conflictingBooking = _context.Bookings.Any(b => b.WetsuitId == wetsuitId
                              && b.DateFrom < dateTo
                              && b.DateTo > dateFrom);

            if (conflictingBooking)
            {
                ViewBag.ErrorMessage = "Våddragt er allerede booket, i de valgte dage.";
                return View("Index");
            }

            try
            {
                var booking = new Booking
                {
                    WetsuitId = wetsuitId,
                    DateFrom = dateFrom,
                    DateTo = dateTo,
                    Wetsuit = wetsuit,
                    IsConfirmed = false, // By default, not confirmed
                    UserId = userId,
                    Name = name,
                    Email = email,
                    WetsuitSize = pickSize
                };
                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index");

            }
            catch (DbUpdateConcurrencyException ex)
            {

                ViewBag.ErrorMessage = "Våddragten er allerede booket, i de valgte dage.";
                return View("Index");
            }
        }


        // Display the cart (list of bookings)
        public async Task<IActionResult> Cart()
        {
            var user = await _userManager.GetUserAsync(User);
            var id = user.Id;

            var userBookings = await _bookingRepository.GetBookingsByUserId(id);

            return View(userBookings);
        }
        public async Task<IActionResult> AdminCart()
        {
            var bookings = await _bookingRepository.GetAllBookings();

            return View(bookings);
        }

        [HttpDelete]
        // Optional: To remove a booking from the cart
        public async Task<IActionResult> RemoveBooking(int bookingId)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking == null)
                return NotFound();

            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction("Cart");
        }
    }
}

