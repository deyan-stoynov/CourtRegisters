using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace CourtRegisters.Repository
{
    public class ProtocolsRepository : IDisposable
    {
        private CourtRegistersDBEntities _context;
        public CourtRegistersDBEntities Context
        {
            get
            {
                return _context;
            }
        }

        public ProtocolsRepository()
        {
            _context = new CourtRegistersDBEntities();
        }

        public ProtocolsRepository(CourtRegistersDBEntities context)
        {
            _context = context;
        }

        public IQueryable<tblRegisterProtocol> GetAll()
        {
            return Context.tblRegisterProtocols;
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public bool Save(ref tblRegisterProtocol model)
        {
            bool success = false;
            Context.Connection.Open();
            using (DbTransaction transaction = Context.Connection.BeginTransaction())
            {
                if (model.ID == 0)
                {
                    var counterRepo = new CountersRepository(Context);
                    counterRepo.SetIncomeNumber(model);
                    model = Add(model);
                }
                else
                {
                    model = Edit(model);
                }
                Context.SaveChanges();
                transaction.Commit();
                Context.Refresh(System.Data.Objects.RefreshMode.StoreWins, model);
                success = true;
            }
            return success;
        }

        public tblRegisterProtocol Add(tblRegisterProtocol model)
        {
            Context.tblRegisterProtocols.AddObject(model);
            return model;
        }

        private tblRegisterProtocol Edit(tblRegisterProtocol model)
        {
            var dbModel = new tblRegisterProtocol() { ID = model.ID };

            Context.tblRegisterProtocols.Attach(dbModel);
            //dbModel.Canceled = true;
            Context.tblRegisterProtocols.ApplyCurrentValues(model);

            return dbModel;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
