using SomerenDAL;
using SomerenModel;
using System.Collections.Generic;

namespace SomerenService
{
    public class PurchaseService
    {
        private PurchaseDao purchaseDao;

        public PurchaseService()
        {
            purchaseDao = new PurchaseDao();
        }

        public List<Purchase> GetPurchases()
        {
            return purchaseDao.GetAllPurchases();
        }

        public void CreatePurchase(Purchase purchase)
        {
            purchaseDao.CreatePurchase(purchase);
        }
    }
}
