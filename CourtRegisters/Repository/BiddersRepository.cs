using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace CourtRegisters.Repository
{
    public class BiddersRepository : IDisposable
    {
        private CourtRegistersDBEntities _context;
        public CourtRegistersDBEntities Context
        {
            get
            {
                return _context;
            }
        }

        public BiddersRepository()
        {
            _context = new CourtRegistersDBEntities();
        }

        public BiddersRepository(CourtRegistersDBEntities context)
        {
            _context = context;
        }

        public IQueryable<tblRegisterBidder> GetAll()
        {
            return Context.tblRegisterBidders;
        }

        public tblRegisterBidder Get(int id)
        {
            return GetAll().FirstOrDefault(it => it.ID == id);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public bool Save(ref tblRegisterBidder model)
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

        private tblRegisterBidder Edit(tblRegisterBidder model)
        {
            var dbModel = new tblRegisterBidder() { ID = model.ID };

            Context.tblRegisterBidders.Attach(dbModel);
            Context.tblRegisterBidders.ApplyCurrentValues(model);

            return dbModel;
        }

        public tblRegisterBidder Add(tblRegisterBidder model)
        {
            Context.tblRegisterBidders.AddObject(model);
            return model;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
