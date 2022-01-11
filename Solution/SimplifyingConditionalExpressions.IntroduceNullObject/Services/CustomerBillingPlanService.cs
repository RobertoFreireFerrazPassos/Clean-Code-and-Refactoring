using Simplifying_Conditional_Expressions.Introduce_Null_Object.Dtos;
using SimplifyingConditionalExpressions.IntroduceNullObject.Entities;
using System;

namespace Simplifying_Conditional_Expressions.Introduce_Null_Object.Services
{
    public class CustomerBillingPlanService
    {
        /*
         * 
         * Problem
         * Since some methods return null instead of real objects, you have many checks for null in your code.
         * 
        */
        public CustomerBillingPlanDto GetPlan(Customer customer) {
            var plan = customer == null ? BillingPlan.GetBasicPlan() : customer.GetPlan();

            return new CustomerBillingPlanDto() {
                CustomerId = customer != null ? customer.Id : Guid.NewGuid(),
                BillingPlan = plan.ToString()
            };
        }
    }
}
