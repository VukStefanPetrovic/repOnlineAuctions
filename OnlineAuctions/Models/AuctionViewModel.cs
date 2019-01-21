using Brick.PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAuctions.Models
{
    public class AuctionViewModel
    {

        public AuctionViewModel()
        {

        }

        [Required]
        public string Name { get; set; }

        public int Duration { get; set; }

        [Required]
        public int startingPrice { get; set; }

        
        public HttpPostedFileBase Image { get; set; }
    }


    public class AuctionViewModelList
    {

        public IPagedList<Auction> Auctions { get; set; }

        
        public string Name { get; set; }

        [Display(Name = "State")]
        public string List { get; set; }

        
        public decimal? LowPrice { get; set; }

        
        public decimal? HighPrice { get; set; }

        /*
        [Display(Name = "Only mine")]
        public bool Only { get; set; }*/

        public IEnumerable<SelectListItem> thisState { get; set; }

    }

}