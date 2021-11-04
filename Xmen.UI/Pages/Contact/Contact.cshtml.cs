using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Xmen.UI.Pages.Contact
{

    /// <summary>
    /// Login Form (input fields => username, password)
    /// Use Tag-Helpers to bind to the code-behind property
    /// Feedback property is shown to the user if ModelState.IsValid == true
    /// Check if Input from user is valid.
    /// </summary>
    
    public class ContactModel : PageModel
    {
        //Check this out => https://docs.microsoft.com/en-us/aspnet/core/mvc/views/working-with-forms?view=aspnetcore-5.0

        /// <summary>
        /// Model Binding is the process in which incoming data is mapped to C# Objects
        /// </summary>

        [BindProperty]
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        public string Feedback { get; set; }


        /// <summary>
        /// Forms are created mainly to collect data from the user.
        /// In the case of Razor Pages, form data is submitted to the "page model" for processing
        /// The page model uses a process called "model binding" to map the incoming data to C# Objects
        /// This allows us to decide whether the data we are working is valid.
        /// Validation is necessary to be able to trigger the proper response for the end user as well as
        /// storing the right type of data.
        /// Apart from OnGet there are other methods which are named following the HTTP methods naming conventions
        /// id est OnGet, OnPost, OnDelete, OnPut 
        /// By using specific tag-helpers we can configure specific methods to handle any sort of request
        /// This allows us to break Razor Pages conventions
        /// </summary>
        /// 
        public ContactModel()
        {

        }
        /// <summary>
        /// The OnGet method is triggered when the browser requests the page to load.
        /// </summary>
        public void OnGet()
        {

        }
        /// <summary>
        /// OnPost is recognized by Razor pages as a form submission handler that 
        /// can be used to map incoming data in our "Page Model"
        /// OnPost handles the data submitted by the User. Proper asp tag helpers are used
        /// in conjunction with these razor specific methods.
        /// 
        /// When Posting Data, Razor Pages will try to convert form input to the FormData C# 
        /// object we've described above.
        /// </summary>
        public void OnPost()
        {

        }
        public void OnPostSubscribe()
        {
            if (ModelState.IsValid)
            {
                Feedback = "You Have Subscribed!";
            }
        }
    }
}
