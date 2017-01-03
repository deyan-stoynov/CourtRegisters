using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourtRegisters.Repository
{
    public class CSIRepository : IDisposable
    {
        private CourtRegistersDBEntities _context;
        public CourtRegistersDBEntities Context
        {
            get
            {
                return _context;
            }
        }

        public CSIRepository()
        {
            _context = new CourtRegistersDBEntities();
        }

        public CSIRepository(CourtRegistersDBEntities context)
        {
            _context = context;
        }

        public List<tblCSI> GetAll()
        {
            return Context.tblCSIs.ToList();
        }

        public List<tblCSI> GetAllActive()
        {
            return Context.tblCSIs.Where(it => it.IsActive).OrderBy(it => it.CSINumber).ToList();
        }



        public void Save()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
