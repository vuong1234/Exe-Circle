using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceItem
{
    public class InvoiceItem
    {
        private string Id;
        private string Desc;
        private int Qty;
        private double UnitPrice;

        public InvoiceItem( string ID, string De, int Qt, double Un)
        {
            Id = ID;
            Desc = De;
            Qty = Qt;
            UnitPrice = Un;
        }

        public string GetId()
        {
            return Id;
        }

        public string GetDesc()
        {
            return Desc;
        }

        public int GetQty()
        {
            return Qty;
        }

        public void SetQty( int NewQty)
        {
            Qty = NewQty;
        }

        public double GetUnitPrice()
        {
            return UnitPrice;
        }

        public void SetUnitPrice( double NewUnitPrice)
        {
            UnitPrice = NewUnitPrice;
        }

        public double GetTotal()
        {
            return 1;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
