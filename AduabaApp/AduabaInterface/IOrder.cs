using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.AduabaInterface
{
    public interface IOrder
    {
        void AddToOrderRecords();
        void ShowPastRecords();
        void ShowStatusOfOrder();
        void TrackOrderInfo();

    }
}
