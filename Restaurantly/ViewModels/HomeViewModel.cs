// ViewModels/HomeViewModel.cs
using Restaurantly.Models;
using System.Collections.Generic;

namespace Restaurantly.ViewModels
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public BookTable BookTable { get; set; }
        public Contact Contact { get; set; }
    }
}
