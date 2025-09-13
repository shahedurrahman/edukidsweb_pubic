using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace EduKidsWeb.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Full name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Phone")]
        public string Phone { get; set; } = string.Empty;

        [BindProperty]
        [Required(ErrorMessage = "Message is required")]
        [MinLength(10, ErrorMessage = "Message must be at least 10 characters long")]
        [Display(Name = "Message")]
        public string Message { get; set; } = string.Empty;

        [TempData]
        public string? SuccessMessage { get; set; }

        [TempData]
        public string? ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                // Here you would typically:
                // 1. Save the contact form data to database
                // 2. Send an email notification
                // 3. Log the contact request

                // For now, we'll just simulate processing
                await Task.Delay(100); // Simulate async operation

                // Set success message
                SuccessMessage = "Thank you for contacting us! We'll get back to you soon.";

                // Clear the form data after successful submission
                FullName = string.Empty;
                Email = string.Empty;
                Phone = string.Empty;
                Message = string.Empty;

                // Redirect to prevent re-submission on refresh
                return RedirectToPage("/Contact");
            }
            catch (Exception ex)
            {
                // Log the exception (you would use a proper logging framework)
                ErrorMessage = "Sorry, there was an error processing your request. Please try again later.";
                return Page();
            }
        }
    }
}