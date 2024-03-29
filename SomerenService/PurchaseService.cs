using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class PurchaseService
    {
        private PurchaseDao purchaseDao;
        private Purchase newPurchase;
        public Purchase NewPurchase { get { return newPurchase; } }

        public PurchaseService()
        {
            purchaseDao = new PurchaseDao();
        }

        public void AddPurchaseToDatabase(Purchase purchase)
        {
            purchaseDao.AddPurchase(purchase);
        }

        public void SetPurchase(Student student, Drink drink, int quantity)
        {
            newPurchase = new Purchase(student, drink, quantity);
        }

        public void ClearPurchase()
        {
            newPurchase = null;
        }
    }
}
