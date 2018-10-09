namespace Team_AAA.Task1
{
    using System.Collections.Generic;

    /// <summary>  
    ///  Interface IReadable for realization method Read() in class Currency.  
    /// </summary>  
    public interface IReadable
    {

        /// <summary>  
        ///  Method Read() in class Currency.  
        /// </summary>  
        void Read(List<Currency> ls);
    }

}
