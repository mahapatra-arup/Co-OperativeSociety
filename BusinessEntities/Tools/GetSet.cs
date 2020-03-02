
namespace BusinessEntities
{
    /// <summary>
    ///  Here  'K' Means 'Key' Value Type and 'V' Means 'Value' Value Type
    /// </summary>
    public class GetSetKeyAndValue<K,V>
    {
        public  K Key { get; set; }
        public  V Value { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public class GetSetValues<T1, T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
    }
   
    public class GetSetValues<T1, T2,T3>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
    }

    public class GetSetValues<T1, T2, T3,T4>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }
        public T4 Item4 { get; set; }
    }
}
