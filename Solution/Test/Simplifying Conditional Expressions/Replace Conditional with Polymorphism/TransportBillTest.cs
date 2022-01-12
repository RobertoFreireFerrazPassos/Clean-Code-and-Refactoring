using SimplifyingConditionalExpressions.ReplaceWithPolymorphism;
using Xunit;

namespace Test.Simplifying_Conditional_Expressions.Replace_Conditional_with_Polymorphism
{
    public class TransportBillTest
    {
        [Theory(DisplayName = "Must Get Transport Bill")]
        [Trait("Replace Conditional with Polymorphism", "TransportBill")]
        [InlineData(TransportationTypeEnum.BUS,0, 7, 49)]
        [InlineData(TransportationTypeEnum.CAR,13,0,1300)]
        public void MustGetTransportBill(TransportationTypeEnum transportationType, int hours, 
            int loadKg, int expectedResult)
        {
            var transportBill = new TransportBill(transportationType, hours, loadKg);

            var result = transportBill.GetBill();

            Assert.Equal(expectedResult, result);
        }
    }
}
