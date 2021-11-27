using EnterpriseArchitecture.Entities.Concrete;

namespace EnterpriseArchitecture.Business.Constants
{
    public static class Messages
    {
        #region Product
        public static string ProductAdded = "Product Added.";
        public static string ProductDeleted = "Product Deleted.";
        public static string ProductNameInvalid = "Product Name Invalid.";
        public static string ProductsListed = "Products Listed.";
        public static string MaintenanceTime = "Mainintenance Time.";
        #endregion

        #region Customer
        public static string CustomerAdded = "Customer Added";
        public static string CustomerIdInvalid = "Customer Ids cannot be less than or equal to zero";
        public static string CustomerDeleted = "Customer Deleted";
        public static string CustomersListed = "Customers Listed";
        #endregion

        #region Category
        public static string CategoryAdded = "Category Added";
        public static string CategoryIdInvalid = "Category Ids cannot be less than or equal to zero";
        public static string CategoryDeleted = "Category Deleted";
        public static string CategoriesListed = "Categories Listed";
        #endregion
    }
}