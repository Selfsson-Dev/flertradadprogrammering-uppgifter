using LoanManagementSys.Managers;

namespace LoanManagementSys
{
    /// <summary>
    /// 
    ///This class administers a list of productsList, adding a new object,
    ///removing an existing, etc.  The list contains productsList that are 
    ///available for loan.  When a product is loaned by a member the 
    ///product is removed from this list and placed in the LoanItenmList,
    ///and when returned, the object is added to the list again.
    /// </summary>

    public class ProductManager : GenericManager<Product>
    {
        public List<Product> productsList = new();

        //Products receive an Id sarting from 100 and then
        //everyting a new product is created, the id is
        //incremented.

        private int lastProductID = 100;

        /// Returns a product at a position = index in the list
        public ProductManager()
        {
            AddTestProducts();
        }

        //Fill the list with some test objects.
        private void AddTestProducts()
        {
            for (int i = 0; i < 15; i++)
            {
                AddNewTestProduct();
            }
        }

        //Return true if the list of items is empty, an thus no product available for loaning.
        public bool NoProductsAvailable()
        {
            return (productsList == null) || (productsList.Count <= 0);
        }

        //This method is called for adding a new tests object in the list.
        public Product AddNewTestProduct()
        {
            Product product = new Product(); // Assume Product constructor and methods are defined elsewhere
            product.ID = lastProductID.ToString();
            product.Name = $"Product{lastProductID++}";
            productsList.Add(product);
            return product;
        }
    }
}
