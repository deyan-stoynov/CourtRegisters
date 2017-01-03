using System;
using System.Collections.Generic;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Text;

namespace CourtRegisters.Repository
{
    public class CountersRepository
    {
        private CourtRegistersDBEntities _context;
        public CourtRegistersDBEntities Context
        {
            get
            {
                return _context;
            }
        }

        public CountersRepository(CourtRegistersDBEntities context)
        {
            _context = context;
        }

        public EntityObject SetIncomeNumber(EntityObject record)
        {
            var thisYear = DateTime.Today.Year;
            if (record is tblRegisterBidder)
            {
                var counter = Context.Counters.FirstOrDefault(it => it.TableEnum == (int)enTableEnum.RegBidder && it.Year == thisYear);
                if (counter == null)
                {
                    counter = InitCounter(enTableEnum.RegBidder, thisYear);
                }
                ((tblRegisterBidder)record).IncomeNumber = counter.NextNum.Value;
                counter.LastNum = counter.NextNum.Value;
            }
            else if (record is tblRegisterProtocol)
            {
                var counter = Context.Counters.FirstOrDefault(it => it.TableEnum == (int)enTableEnum.RegProtocol && it.Year == thisYear);
                if (counter == null)
                {
                    counter = InitCounter(enTableEnum.RegProtocol, thisYear);
                }
                ((tblRegisterProtocol)record).IncomeNumber = counter.NextNum.Value;
                counter.LastNum = counter.NextNum.Value;
            }
            else if (record is tblRegisterPublicSalesRoom)
            {
                var counter = Context.Counters.FirstOrDefault(it => it.TableEnum == (int)enTableEnum.RegPublicSaleRoom && it.Year == thisYear);
                if (counter == null)
                {
                    counter = InitCounter(enTableEnum.RegPublicSaleRoom, thisYear);
                }
                ((tblRegisterPublicSalesRoom)record).IncomeNumber = counter.NextNum.Value;
                counter.LastNum = counter.NextNum.Value;
            }

            Context.SaveChanges();
            return record;
        }

        private Counter InitCounter(enTableEnum table, int year)
        {
            Counter counter = new Counter();
            counter.NextNum = 1;
            counter.TableEnum = (int)table;
            counter.Year = year;

            Context.Counters.AddObject(counter);

            return counter;
        }
    }
}
