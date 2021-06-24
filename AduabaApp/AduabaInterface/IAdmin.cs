using AduabaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.AduabaInterface
{
   public interface IAdmin
    {
        void Login();
        void AddItemtoStore(Item item);
        void AddItemsToStore(List<Item> items);
        void RemoveItemFromStore(Item item);
        void RemoveItemsFromStore(List<Item>item);
        void ConfirmOrder(Order orderToConfirm);
        void RemoveUnavailableItemsFromView();

    }
}
