using AduabaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AduabaApp.AduabaInterface
{
    public interface IUser
    {
        void RegisterUser(ApplicationUser user);
        void LogIn(ApplicationUser logincredentials);
        void SocialSignIn();
        void ResetPassword();
        void AddItemToCart(Item item);
        void AddListOfItemToCart(List<Item> items);
        void RemoveItemFromCart(Item itemToRemove);
        void RemoveItemsFromCart(List<Item >itemsToRemove);
        void MakeOnlinePayment(PaymentCard userCard);
        void AddItemToWishList(Item item);
        void AddListOfItemToWishList(List<Item> items);
        void RemoveItemFromWishList(Item itemToRemove);
        void RemoveItemsFromWishList(List<Item> itemsToRemove);
        void ConvertWishListToOrder(WishListItems listItems);

        void EditAccountDetails(ApplicationUser newDetails);
        void KeepTrackOfOrder();





    }
}
