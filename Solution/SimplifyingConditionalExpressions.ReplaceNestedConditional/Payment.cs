namespace SimplifyingConditionalExpressions.ReplaceNestedConditional
{
    /*
     * Problem:
     * You have a group of nested conditionals and it’s hard to determine the normal flow of code execution.
     * 
    */
    public class Payment
    {
        private bool IsDead;
        private bool IsSeparated;
        private bool IsRetired;
        private double Value;

        public Payment(bool isDead,
            bool isSeparated,
            bool isRetired,
            double value) 
        {
            IsDead = isDead;
            IsSeparated = isSeparated;
            IsRetired = isRetired;
            Value = value;
        }

        public double GetPayAmount()
        {
            double result;

            if (this.IsDead)
            {
                result = DeadAmount();
            }
            else
            {
                if (this.IsSeparated)
                {
                    result = SeparatedAmount();
                }
                else
                {
                    if (this.IsRetired)
                    {
                        result = RetiredAmount();
                    }
                    else
                    {
                        result = NormalPayAmount();
                    }
                }
            }

            return result;
        }

        private double SeparatedAmount() => 22;

        private double RetiredAmount() => this.Value * 2;

        private double NormalPayAmount() => this.Value;

        private double DeadAmount() => this.Value * 0.5;
    }
}
