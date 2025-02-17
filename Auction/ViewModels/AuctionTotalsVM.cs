﻿using Auction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.ViewModels
{
    public class AuctionTotalsVM
    {
        public decimal LiveTotal { get; set; }

        public decimal SilentTotal { get; set; }

        public List<MultiBidderItemTotal> MultiTotals { get; set; }

        public decimal EarlyTicketsTotal { get; set; }

        public decimal DoorTicketsTotal { get; set; }
        
        public decimal AuctionTotal { get; set; }
        
        public string Theme { get; set; }

        public string Date { get; set; }

        public int LiveCount { get; set; }

        public int SilentCount { get; set; }

        public int EarlyTicketCount { get; set; }

        public int DoorTicketCount { get; set; }

        public int BidderCount { get; set; }

    }
}
