using System;
using System.Collections.Generic;//add system collections generic
using System.ComponentModel;
using System.Data;
using System.Drawing;//add system Drawing
using System.Linq;//add system Linq
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//add system windows form

//namespace allow user access to other classes in the sama namespace
namespace Benchmark_Application
{
    /// <summary>
    /// This is public partial class for form1
    /// </summary>
    /// <remarks>
    /// This is public partial class to declare paramters for form 1
    /// </remarks>
    public partial class Form1 : Form
    {
        //declare a random parameter for seed
        Random seed = new Random();
        //declare integer planettypeid
        int planetTypeId;
        //declare integer planetid
        int planetId;
        // This is for loading ,sort, save operation
        List<MyClass> planets = new List<MyClass>();
        //Declare screen picture
        Graphics screen;

        /// <summary>
        /// This is public form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // set up screen and initialise planet id
            screen = picScreen.CreateGraphics();
            planetId = 0;
        }

        /// <summary>
        /// This is button to load new object to form
        /// </summary>
        /// <remarks>
        /// this button to load a moving boject and text info
        /// </remarks>
        private void picScreen_Click(object sender, EventArgs e)
        {       
            //set increment operator
            planetId++;            
            //planet type set to random seed types from 3 types from Myclass
            planetTypeId = seed.Next(3) + 1;
            //declare the full name for new object, convert int planetid to string
            string fullPlanetId = "New Planet" + " " + planetId.ToString();           
            //Declare a loadpic as new local variable
            PictureBox loadpic = new PictureBox();

            //use switch statement to load different picture by three planet type id
            switch(planetTypeId)
            {
                //set case 1 is picture picearth
                case 1:
                    loadpic = picEarth;
                    break;
                //set case 2 is picture picmercury
                case 2:
                    loadpic = picMercury;
                    break;
                //set case 3 is picture picVenus
                case 3:
                    loadpic = picVenus;
                    break;
            }
            //Declare new loacl variable newplanet to hold new data
            MyClass newplanet = new MyClass(fullPlanetId, loadpic, planetTypeId);
            //add a new objects to myclass planets
            planets.Add(newplanet);
            //Call this procedure to make objects moving
            MoveAndShowPlanets(sender, e);     
        }

        /// <summary>
        /// This button to show object and text infor in the list box
        /// </summary>
        /// <remarks>
        /// update moveing speed data to list box 
        /// </remarks>
        private void btnShowStatus_Click(object sender, EventArgs e)
        {
            //call this method to update data in the list box
            updatelistbox();
        }

        /// <summary>
        /// This button to load initial data
        /// </summary>
        /// <remarks>
        /// initial data inculde text infor and picture
        /// </remarks>
        private void btnLoadInitialData_Click(object sender, EventArgs e)
        {
            //Declare a new object called a to call myclass class
            List<MyClass> a = new List<MyClass>();
            //Clear any data in the list box
            lbxDisplay.Items.Clear();
            //Declare a new object called fm to call filemanager class
            FileManager fm = new FileManager();
            //retrieve a list of planets information from filemanager to a(myclass), except image
            a = fm.LoadPlanets("planets.txt");
            //Declare integer seed
            int seed;
            //Declare string ID
            string Id;
            //Declare integer count ,set to 0
            int count = 0;
            //Declare object loadpic in the picture box
            PictureBox loadpic = new PictureBox();

            //use foreach to load different picture
            foreach (MyClass planet in a)
            {
                // set count equals 0 would load picearth and continue to load other pictures
                if (count == 0)
                {
                    loadpic = picEarth;
                }
                // set count equals 1 would load picmercury and continue to load other pictures
                else if  (count == 1)
                {
                    loadpic = picMercury ;
                }
                // set count equals 2 would load picvenus and continue to load other pictures
                else if  (count == 2)
                {
                    loadpic = picVenus;
                }
                
                //set ID to each planet picture, passing to planetID in myclass
                Id = planet.PlanetId;
                //set seed to each planet picture, passing to typeID in myclass
                seed = planet.TypeId;
                //make an active object from retrieved file data and also set up image from loadpic
                MyClass planetfromFile = new MyClass(Id, loadpic , seed);
                //Call MoveAndShowPlanets method
                MoveAndShowPlanets(sender, e);
                //Add data from myclass to form
                planets.Add(planetfromFile);
                //set for each statement to count increment
                count++;
            }
            
            //call this method to update data in the list box
            updatelistbox();
        }

        /// <summary>
        /// This method for object moving and display
        /// </summary>
        //This is method for object moveing and displaying
        public void MoveAndShowPlanets(object sender, EventArgs e)
        {
            //clear screen and set up background color
            screen.Clear(Color.LawnGreen);
            
            //use for each statement to make each object move
            foreach (MyClass eachplanet in planets)
            {
                //object moveing
                eachplanet.Move();
                //call drawpic method(myclass) to display objects
                eachplanet.DrawPic(screen);
            }
            
            //set timer is true and run MoveAndShowPlanets procedure 
            timer1.Enabled = true;
        }

        /// <summary>
        /// This is timer procedure
        /// </summary>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //call MoveAndShowPlanets procedure
            MoveAndShowPlanets(sender, e);
        }

        /// <summary>
        /// This button to remove object from form
        /// </summary>
        /// <remarks>
        /// remove image and text infor from list box 
        /// </remarks>
        private void btnRemoveSelectedObj_Click(object sender, EventArgs e)
        {
            //Declare integer count
            int count = 0;
            //use if statement to check whether here are items in the list box 
            if (lbxDisplay.Items.Count>0) {
                //Declare x variable as a index for select item in the list box
                var x = lbxDisplay.SelectedIndex;
                //remove selec index item and planets data
                planets.RemoveAt(x);
                //remove text selected from list box
                lbxDisplay.Items.Remove(lbxDisplay.SelectedItem);
            }
            //messagebox display if no text in the list box
            else
            {
                MessageBox.Show("Please select a item to remove");
            }
            
        }

        /// <summary>
        /// This button to clear all objects from form
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clear the listbox items
            lbxDisplay.Items.Clear();
            //clear data including picture and file data from form
            planets.Clear();          
        }

        /// <summary>
        /// This button to load data from another text file 
        /// </summary>
        private void btnLoadPreviousSaving_Click(object sender, EventArgs e)
        {
            //Declare a new object called a to call myclass class
            List<MyClass> a = new List<MyClass>();
            //Clear any data in the list box
            lbxDisplay.Items.Clear();
            //Declare a new object called fm to call filemanager class
            FileManager fm = new FileManager();
            //retrieve a list of planets information from filemanager to a(myclass), except image
            a = fm.LoadPlanets("NewData.txt");
            //Declare integer seed
            int seed;
            //Declare string ID
            string Id;
            //Declare integer count ,set to 0
            int count = 0;
            //Declare object loadpic in the picture box
            PictureBox loadpic = new PictureBox();

            //use foreach to load different picture
            foreach (MyClass planet in a)
            {
                // set count equals 0 would load picearth and continue to load other pictures
                if (count == 0)
                {
                    loadpic = picEarth;
                }
                // set count equals 1 would load picmercury and continue to load other pictures
                else if (count == 1)
                {
                    loadpic = picMercury;
                }
                // set count equals 2 would load picvenus and continue to load other pictures
                else if (count == 2)
                {
                    loadpic = picVenus;
                }
                
                //set ID to each planet picture, passing to planetID in myclass
                Id = planet.PlanetId;
                //set seed to each planet picture, passing to typeID in myclass
                seed = planet.TypeId;
                //make an active object from retrieved file data and also set up image from loadpic
                MyClass planetfromFile = new MyClass(Id, loadpic, seed);
                //Call MoveAndShowPlanets method
                MoveAndShowPlanets(sender, e);
                //Add data from myclass to form
                planets.Add(planetfromFile);
                //set for each statement to count increment
                count++;
            }

            //call this method to update data in the list box
            updatelistbox();
        }

        /// <summary>
        /// This button to sort term Z to A by type name
        /// </summary>
        private void btnSortZA_Click(object sender, EventArgs e)
        {
            //Declare a new object called typenamesort to call filter class
            Filter typenamesort = new Filter();
            
            //use sortZA method in the filter class to implement and return to planets
            planets = typenamesort.SortZA(planets);
            //call this method to update data in the list box
            updatelistbox();
        }

        /// <summary>
        /// This button to sort term A-Z by type name
        /// </summary>
        private void btnSortAZ_Click(object sender, EventArgs e)
        {
            //Declare a new object called typename to call filter class
            Filter typename = new Filter();
            
            //use sortAZ method in the filter class to implement and return to planets
            planets = typename.SortAZ(planets);
            //call this method to update data in the list box
            updatelistbox();
        }

        /// <summary>
        /// This button to search term contains in type name
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Declare a new object called searchresult to call filter class
            Filter searchresult = new Filter();
            //declare text value to string called searchterm
            string searchTerm = txbSearch.Text;
            //Declare a as a new local variable
            List<MyClass> a = new List<MyClass>();
            
            //call Search method from filter by preset two paramters, return to a variable
            a = searchresult.Search(planets, searchTerm);
            //call this method to update data in the list box
            lbxDisplay.Items.Clear();
            //add a list array data in the list box
            lbxDisplay.Items.AddRange(a.ToArray());
        }

        /// <summary>
        /// This is procedure to update list box data
        /// </summary>
        /// <remarks>
        /// procedure called by several button using
        /// </remarks>
        //This is private method in Form1 called updatelistbox
        private void updatelistbox()
        {
            //clear any data in the listbox
            lbxDisplay.Items.Clear();
            //add a list array data in the list box
            lbxDisplay.Items.AddRange(planets.ToArray());
        }

        /// <summary>
        /// This button to save displayed object to text file
        /// </summary>
        private void btnSaveCurrentList_Click(object sender, EventArgs e)
        {
            //use if statement to save file to local disk
            //if no data in the list box 
            if (planets .Count()==0)
            {
                //Declare a new fm object to call filemanager
                FileManager fm = new FileManager();
                //call saveplanet method in the filemangaer class
                fm.SavePlanet(planets, "NewData.txt");
                //show message box
                MessageBox.Show("Data has not been saved.");
            }
            else
            {
                /*if data count greater than 0 then execute same method
                 * to use saveplanet method in filemanager class
                 * and display a message box to user*/
                FileManager fm = new FileManager();
                fm.SavePlanet(planets, "NewData.txt");
                MessageBox.Show("All the data has been saved.");                  
            }
        }
    }
}
