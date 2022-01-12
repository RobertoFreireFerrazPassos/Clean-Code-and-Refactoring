using System;

namespace SimplifyingConditionalExpressions.ReplaceWithPolymorphism
{
    /*
     * 
     * Problem:
     * You have a conditional that performs various actions depending on object type or properties.
     * 
    */
    public class TransportBill
    {
        private TransportationTypeEnum TransportationType;
        private int Hours;
        private int LoadKg;
        private static readonly int BUS_KG_PRICE = 7;
        private static readonly int CAR_HOUR_PRICE = 100;

        public TransportBill(TransportationTypeEnum transportationType,
                            int hours,
                            int loadKg) {
            Hours = hours;
            LoadKg = loadKg;
            TransportationType = transportationType;
        }

        public double GetBill()
        {
            switch (TransportationType)
            {
                case TransportationTypeEnum.CAR:
                    return GetCarBill();
                case TransportationTypeEnum.BUS:
                    return GetBusBill();
                default:
                    throw new ArgumentException(ErrorMessageConstant.TRANSPORTATION_TYPE_NOT_FOUND);
            }
        }

        private double GetBusBill()
        {
            return TransportBill.BUS_KG_PRICE * LoadKg;
        }

        private double GetCarBill()
        {
            return TransportBill.CAR_HOUR_PRICE * Hours;
        }
    }
}
