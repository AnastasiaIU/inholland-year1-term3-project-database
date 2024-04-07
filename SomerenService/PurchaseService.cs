using SomerenDAL;
using SomerenModel;

namespace SomerenService
{
    public class PurchaseService
    {
        private PurchaseDao purchaseDao = new PurchaseDao();
        /// <summary>
        /// Gets the currently staged purchase that is prepared but not yet finalized or persisted to the database.
        /// </summary>
        /// <value>
        /// The <see cref="Purchase"/> object representing the purchase details that are pending creation. This property returns <c>null</c> if no purchase is currently staged.
        /// </value>
        public Purchase StagedPurchase { get; private set; }

        public void CreatePurchase(Purchase purchase)
        {
            purchaseDao.CreatePurchase(purchase);
        }

        /// <summary>
        /// Stages a purchase for creation based on the provided details. This method prepares a new <see cref="Purchase"/> object and stores it, making it ready for eventual persistence to the database.
        /// </summary>
        /// <param name="student">The <see cref="Student"/> who is making the purchase.</param>
        /// <param name="drink">The <see cref="Drink"/> being purchased.</param>
        /// <param name="quantity">The quantity of the drink being purchased.</param>
        /// <remarks>
        /// Calling this method will overwrite any previously staged purchase. To finalize and persist the staged purchase, call <see cref="CreatePurchase(Purchase)"/> with the staged purchase.
        /// </remarks>
        public void StagePurchaseForCreation(Student student, Drink drink, int quantity)
        {
            StagedPurchase = new Purchase(student, drink, quantity);
        }

        /// <summary>
        /// Clears the currently staged purchase, if any. This method is used to reset or cancel the purchase process before the staged purchase is finalized and persisted.
        /// </summary>
        /// <remarks>
        /// After calling this method, <see cref="StagedPurchase"/> will return <c>null</c>, indicating that there is no longer a purchase awaiting creation. Use this method to cancel or restart the purchase staging process.
        /// </remarks>
        public void ClearStagedPurchase()
        {
            StagedPurchase = null;
        }
    }
}
