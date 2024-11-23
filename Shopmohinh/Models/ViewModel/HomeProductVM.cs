using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopmohinh.Models.ViewModel
{
    public class HomeProductVM
    {
        public string SearchTerm { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 10;
        //danh sách nổi bậc
        public List<Product> FeaturedProducts { get; set; }
        // danh sách sản phẩm mới đã phân trang
        public PagedList.IPagedList<Product> NewProducts { get; set; }
    }
}