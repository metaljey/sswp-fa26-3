
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace sswp_fa26_3.Pages
{
    public class TherizinosaurusModel : PageModel
    {
        public string? Story { get; set; }

        public string[] Stories =
        {
            "One day, Therizinosaurus discovered a mysterious forest full of giant plants. Its long claws helped it reach the highest branches!",

            "A hungry Therizinosaurus walked through the jungle searching for food. Suddenly, it found a tree covered with delicious leaves!",

            "Therizinosaurus met a tiny dinosaur who was afraid of its giant claws. But instead of fighting, they became friends!",

            "One morning, Therizinosaurus woke up and found enormous footprints near its home. It followed them and discovered a new prehistoric friend!",

            "A storm approached the prehistoric forest. Therizinosaurus used its powerful claws to pull branches closer and find shelter beneath the trees!",

            "Therizinosaurus entered a mysterious valley where no dinosaur had ever traveled. Its adventure was only beginning!"
        };

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Random random = new Random();

            int index = random.Next(Stories.Length);

            Story = Stories[index];
        }
    }
}
