namespace leetcode
{
    public class Salary
    {
        public string Currency{get; set;}
        public decimal Amount{get; set;}

        public decimal CalculateTotal()
        {
             return Amount *12;
            
             
        }
        
    }
}