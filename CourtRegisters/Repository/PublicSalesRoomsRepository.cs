using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace CourtRegisters.Repository
{
    public class PublicSalesRoomsRepository : IDisposable
    {
        private CourtRegistersDBEntities _context;
        public CourtRegistersDBEntities Context
        {
            get
            {
                return _context;
            }
        }

        public PublicSalesRoomsRepository()
        {
            _context = new CourtRegistersDBEntities();
        }

        public PublicSalesRoomsRepository(CourtRegistersDBEntities context)
        {
            _context = context;
        }

        public IQueryable<tblRegisterPublicSalesRoom> GetAll()
        {
            return Context.tblRegisterPublicSalesRooms;
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public bool Save(ref tblRegisterPublicSalesRoom model)
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

        public tblRegisterPublicSalesRoom Add(tblRegisterPublicSalesRoom model)
        {
            Context.tblRegisterPublicSalesRooms.AddObject(model);
            return model;
        }

        private tblRegisterPublicSalesRoom Edit(tblRegisterPublicSalesRoom model)
        {
            var dbModel = new tblRegisterPublicSalesRoom() { ID = model.ID };

            Context.tblRegisterPublicSalesRooms.Attach(dbModel);
            Context.tblRegisterPublicSalesRooms.ApplyCurrentValues(model);

            return dbModel;
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
