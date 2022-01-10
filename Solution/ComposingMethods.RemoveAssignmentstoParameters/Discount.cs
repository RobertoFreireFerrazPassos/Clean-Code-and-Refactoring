using ComposingMethods.RemoveAssignmentstoParameters.Discounts;

namespace ComposingMethods.RemoveAssignmentstoParameters
{
    public static class Discount
    {
        /*
         * Problem:
         * Some value is assigned to a parameter inside method’s body.
        */
        public static double Apply(Product product) {
            if (product.quantity > 50) {
                product.value = _10PercentDiscount.ApplyDiscount(product.value);
            }

            return product.value;
        }
    }
}
