using AduabaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.AduabaInterface
{
    public interface ITransaction
    {
        void ProcessPayment();
        void AddCardToDb(PaymentCard card);
        void RemoveCardFromDb();
        void IsCardValid();
        void AddToPaymentRecord();
        void  GetPaymentRecord();
        
    }
}
