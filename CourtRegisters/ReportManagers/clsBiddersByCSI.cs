using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace CourtRegisters.Reports
{
    public class BiddersByCSI
    {
        public static IEnumerable<tblRegisterBidder> PopulateBidders(int nIdCSI, string sCaseNumber)
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                IEnumerable<tblRegisterBidder> listBidders = (from eBidders in db.tblRegisterBidders.Include("tblCSI")
                                                              where eBidders.tblCSI.IdCSI == nIdCSI
                                                              && eBidders.CaseNumber == sCaseNumber
                                                       select eBidders);
                return listBidders.ToList();            
            }
        }
        public static IEnumerable<ReportParameter> PrepareParameters(int nIdCSI, string sCaseNumber)
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                tblRegisterBidder oBidder = (from eBidders in db.tblRegisterBidders.Include("tblCSI")
                                                 where eBidders.tblCSI.IdCSI == nIdCSI
                                                 && eBidders.CaseNumber == sCaseNumber
                                                 select eBidders).FirstOrDefault();

                yield return new ReportParameter("CaseNumber", oBidder.CaseNumber);
                yield return new ReportParameter("CSIName", oBidder.tblCSI.CSIName);
                yield return new ReportParameter("PostingDate", DateTime.Now.ToString("dd.MM.yyyy 'г.' HH:mm 'ч.'"));

            }
        }
    }
}
