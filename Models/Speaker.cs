using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConference.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Image { get; set; } = "https://pbs.twimg.com/profile_images/1307714520870260739/lhweJTqL_400x400.jpg";
    }
}
