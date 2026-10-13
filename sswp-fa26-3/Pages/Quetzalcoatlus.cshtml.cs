
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace sswp_fa26_3.Pages
{
    public class QuetzalcoatlusModel : PageModel
    {
        public Dictionary<string, string> DinoFacts { get; set; } = new()
        {
            { "Type", "Flying reptile (Pterosaur)" },
            { "Period", "Late Cretaceous" },
            { "Wingspan", "About 33 feet" },
            { "Location", "North America" },
            { "Diet", "Small animals" }
        };

        [BindProperty]
        public string? Place { get; set; }

        [BindProperty]
        public string? Action { get; set; }

        [BindProperty]
        public string? Food { get; set; }

        public string? Story { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(Place) &&
                !string.IsNullOrWhiteSpace(Action) &&
                !string.IsNullOrWhiteSpace(Food))
            {
                var words = new Dictionary<string, string>
                {
                    { "PLACE", Place },
                    { "ACTION", Action },
                    { "FOOD", Food }
                };

                Story = $"One day, Quetzalcoatlus flew over " +
                        $"{words["PLACE"]}. Suddenly, it " +
                        $"{words["ACTION"]} through the sky " +
                        $"while searching for {words["FOOD"]}.";
            }
        }
    }
}
