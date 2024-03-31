namespace SomerenModel
{
    /// <summary>
    /// Represents the stock level of a drink.
    /// </summary>
    /// <remarks>
    /// This enumeration provides a simple way to categorize the availability of drinks based on their stock count.
    /// </remarks>
    public enum StockLevel
    {
        /// <summary>
        /// Indicates that no drinks are available in stock.
        /// </summary>
        Empty = 0,
        /// <summary>
        /// Indicates that the drink stock is low and nearing depletion. 
        /// A stock count of 10 is considered the threshold for this category.
        /// </summary>
        NearlyDepleted = 10,
        /// <summary>
        /// Indicates that the drink stock is at a sufficient level for normal operations.
        /// This level applies to stock counts greater than 10.
        /// </summary>
        Sufficient
    }
}
