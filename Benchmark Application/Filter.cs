using System;
using System.Collections.Generic;//add system collection generic
using System.Linq;//add system linq 
using System.Text;
using System.Threading.Tasks;

//namespace allow user access to other classes in the sama namespace
namespace Benchmark_Application
{
    //This is class filter to search and sort lists of objects 
    /// <summary>
    /// This is class <c>filter</c> to search and sort lists of objects
    /// <list type="bullet">
    /// <item>
    /// <term>SortAZ</term>
    /// <description>sort type name by A-Z</description>
    /// </item>
    /// <item>
    /// <term>SortZA</term>
    /// <description>sort type name by Z-A</description>
    /// </item>
    /// <item>
    /// <term>Search</term>
    /// <description>search type name</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// This class can search and sort method
    /// </remarks>
    public class Filter
    {
        //This is method called SortAZ, and parameter sortlist
        /// <summary>
        /// This is method called SortAZ, and parameter sortlist
        /// </summary>
        /// <remarks>
        /// Use Linq expression to sort
        /// </remarks>
        /// <param name="sortlist">a list after sorted</param>
        /// <returns>
        /// a sort list after Linq experssion method
        /// </returns>
        /// see <see cref="Filter.Search(List{MyClass}, string)"/> to sort list data
        public List<MyClass> SortAZ (List<MyClass>sortlist)
        {
            /* Use LINQ query expression to sort A-Z by type name,
             * tolist means convert data to match sortlist*/
            sortlist = (from n in sortlist
                        orderby n.TypeName
                        select n).ToList();
            //return list of data to sortlist
            return sortlist;
        }

        //This is method called SortZA, and parameter sortlist
        /// <summary>
        /// This is method called SortZA, and parameter sortlist
        /// </summary>
        /// <remarks>
        /// use Lambda experssion to sort
        /// </remarks>
        /// <param name="sortlist">a list after sorted</param>
        /// <returns>
        /// a sort list after Lambda experssion method
        /// </returns>
        public List<MyClass> SortZA(List<MyClass> sortlist)
        {
            /*Lambda Expression
             * sort list Z-A by type name using desceding method
             * and convert data to match sortlist*/
            sortlist = sortlist.OrderByDescending(x => x.TypeName).ToList();
            //return list of data to sortlist
            return sortlist;
        }

        //This is method called search, and two parameters
        /// <summary>
        /// This is method called search, and two parameters
        /// </summary>
        /// <remarks>
        /// Use Linq expression to search
        /// </remarks>
        /// <param name="searchlist">a list after searched</param>
        /// <param name="term">a string text</param>
        /// <returns>
        /// a search list after Linq experssion method
        /// </returns>
        /// see <see cref="Filter.SortAZ(List{MyClass})"/> to sort list data
        public List<MyClass> Search(List<MyClass> searchlist, string term)
        {
            /* Use LINQ query expression to search by type name,
             * Convert any character to lower case and search any term contained
             * tolist means convert data to match sortlist*/
            searchlist = (from n in searchlist
                          where n.TypeName.ToLower().Contains(term.ToLower())
                          select n).ToList();
            //return list of data to sortlist
            return searchlist;
        }
    }
}
