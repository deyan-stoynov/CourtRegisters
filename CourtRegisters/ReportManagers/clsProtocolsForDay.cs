using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Reporting.WinForms;
using System.Data;

namespace CourtRegisters.Reports
{
    public class ProtocolsForDay
    {
        public static IEnumerable<vwProtocolsForDay> PopulateProtocols(int nIdCSI, DateTime StartDate, DateTime EndDate)
        {
            using (CourtRegistersDBEntities db = new CourtRegistersDBEntities())
            {
                DateTime dtFrom = StartDate;//.AddDays(-1);
                EndDate = EndDate.AddDays(1);
                IEnumerable<vwProtocolsForDay> listProtocols = from eProtocol in db.vwProtocolsForDays
                                                               where eProtocol.PostingDate > dtFrom && eProtocol.PostingDate < EndDate &&
                                                               (nIdCSI == 0 || eProtocol.IdCSI == nIdCSI)
                                                               orderby  eProtocol.ID 
                                                               select eProtocol;
                return listProtocols.ToList();
            }
        }
    }

}
