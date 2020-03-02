
namespace BusinessEntities
{
   public class LoanCalCulatorEntities
    {
        /// <summary>
        /// Bengali meaning is : Asol (p)
        /// </summary>
        public double  _IPrincipal { get; set; }
        /// <summary>
        /// Bengali meaning is : Suder Her (r)
        /// </summary>
        public double _IRate { get; set; }
        /// <summary>
        /// Bengali meaning is : somoy (t)
        /// </summary>
        public double _ITime { get; set; }
        /// <summary>
        /// Bengali meaning is : Sud-Asol (A)
        /// </summary>
        public double _IAmount { get; set; }
        /// <summary>
        /// Bengali meaning is : Mot Sud (R)
        /// </summary>
        public double _ITotalInterest { get; set; }

        /// <summary>
        /// No of period means like  No of Emi paid Period
        /// </summary>
        public double _INoOfPeriod { get; set; }
        
        /// <summary>
        ///Others Balence 
        /// </summary>
        public double _IOthersBalence { get; set; }
    }
}
