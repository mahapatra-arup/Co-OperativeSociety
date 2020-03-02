using BusinessEntities;
using SocietyDataAccess.Setting;


namespace SocietyBusinessAccess.Setting
{
    public class DecimalPointBA
    {
        //Object Type
        DecimalPointDA decimalPointDA = new DecimalPointDA();

        /// <summary>
        /// Update Decimal point Number
        /// </summary>
        /// <param name="decimalPointTools"></param>
        /// <returns></returns>
        public bool UpdateOfUpdateOfDecimalPointTools(DecimalPointTool decimalPointTools)
        {
            return decimalPointDA.UpdateOfDecimalPointTools(decimalPointTools);
        }

        /// <summary>
        /// Get DecimalPointTool Details
        /// </summary>
        /// <returns></returns>
        public DecimalPointTool GetDecimalPointTool()
        {
            return decimalPointDA.GetDecimalPointTool();
        }
    }
}
