using System;
using System.Collections.Generic;//add system collections generic
using System.IO;//add system IO
using System.Linq;//add system Linq
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//add system windows form

//namespace allow user access to other classes in the sama namespace
namespace Benchmark_Application
{
    //This is class FileManager to write and read file
    /// <summary>
    /// This is class <c>Filemanager</c> to write and read file
    /// <list type="bullet">
    /// <item>
    /// <term>LoadPlanets</term>
    /// <description>loading file</description>
    /// </item>
    /// <item>
    /// <term>SavePlanet</term>
    /// <description>save date to file</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// This class can write and read file
    /// </remarks>
    public class FileManager
    {
        // this is a method to add planets file and picture
        /// <summary>
        /// this is a method to add planets file and picture
        /// </summary>
        /// <remarks>
        /// load files and set up a string parameter
        /// </remarks>
        /// <param name="filename">a string to specify file</param>
        /// <returns>
        /// loaded files
        /// </returns>
        public List<MyClass> LoadPlanets(string filename)
        {
            //Declare a new steamreader to read file(fn)
            StreamReader sr = new StreamReader(filename);
            //delcare a new list objects called loadplanets
            List<MyClass> loadplanets = new List<MyClass>();

            //declare variables for object parameters
            //declare string picid
            string picId;
            //declare a new pic call picturebox
            PictureBox pic = new PictureBox();
            //delcare a integer seed
            int seed;

            //use while loop to read file until the last line reached
            while (!sr.EndOfStream)
            {
                //store each line to string called temp
                string temp = sr.ReadLine();
                //set array values and separate each line by ','
                string[] values = temp.Split(',');
                //the first data pass to picid
                picId = values[0];
                //the second data pass to seed and convert to integer
                seed = int.Parse(values[1]);

                //create new object, note: picture will be set up in form application
                MyClass s = new MyClass(picId,pic,seed);
                //add these file to loadplanets
                loadplanets.Add(s);
            }
            //close the streamreader and release txt file
            sr.Dispose();
            // reture the populated list of planets objects have been read from file
            return loadplanets;
        }

        //This is method called saveplanet to save data to local file
        //two parameters m means data to save and filename means save to which file
        /// <summary>
        /// This is method called saveplanet to save data to local file
        /// </summary>
        /// <remarks>
        /// save data to local planet by two parameters: list m and a string
        /// </remarks>
        /// <param name="m">a list data</param>
        /// <param name="filename">a string to specify file</param>
        public void SavePlanet(List <MyClass>m,string filename)
        {
           //declare a new sw object to write data to file
            StreamWriter sw = new StreamWriter(filename);
            /*use for loop write each line to sw which file needed to write in
             * by setting count each line*/
            for(int i=0;i<m.Count();i++)
            {
                sw.WriteLine(m[i].PlanetId + "," + m[i].TypeId);
            }
            //close the streamwriter and release the file
            sw.Dispose();   
        }
    }
}

