using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourtRegisters.ReportManagers
{
    public class clsBidderByDate
    {
        public static IEnumerable<BidderByDate> PopulateBidders(DateTime dtDate)
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                IEnumerable<BidderByDate> listBidders = db.Get_BidderByDate_SP(dtDate);
                                                        
                return listBidders.ToList();
            }
        }
    }
}
