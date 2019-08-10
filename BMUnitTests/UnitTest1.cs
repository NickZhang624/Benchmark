using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Benchmark_Application;//add system Benchmark_Application
using System.Windows.Forms;//add system windows form
using System.Drawing;//add drawing
using System.IO;
using System.Collections.Generic;//add system collections generic
using System.Linq;

//This name space for testing, therefore different others name space
namespace BMUnitTests
{
    //This is index for different class testing
    /// <summary>
    /// //This is index for different class testing
    /// </summary>
    /// <remarks>
    /// for public class MyClass
    /// </remarks>
    [TestClass]
    //This is test for public class MyClass
    public class MyClassUnitTest
    {
        //This is test method for string PlanetId
        /// <summary>
        /// This is test method for string PlanetId
        /// </summary>
        [TestMethod]
        public void TestMyClassPlanetId()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to PlanetId
            c.PlanetId = "Test Id1";
            //test sample date equal to myclass public property
            Assert.AreEqual("Test Id1", c.PlanetId);
        }

        //This is test method for int TypeId
        /// <summary>
        /// This is test method for int TypeId
        /// </summary>
        [TestMethod]
        public void TestMyClassTypeId()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to TypeId
            c.TypeId = 6;
            //test sample date equal to myclass public property
            Assert.AreEqual(6, c.TypeId);
        }

        //This is test method for string TypeName
        /// <summary>
        /// This is test method for string TypeName
        /// </summary>
        [TestMethod]
        public void TestMyClassTypeName()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to TypeName
            c.TypeName = "Earth";
            //test sample date equal to myclass public property
            Assert.AreEqual("Earth", c.TypeName);
        }

        //This is test method for int XPosition
        /// <summary>
        /// This is test method for int XPosition
        /// </summary>
        [TestMethod]
        public void TestMyClassXPosition()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to XPosition
            c.XPosition = 50;
            //test sample date equal to myclass public property
            Assert.AreEqual(50, c.XPosition);
        }

        //This is test method for int YPosition
        /// <summary>
        /// This is test method for int YPosition
        /// </summary>
        [TestMethod]
        public void TestMyClassYPosition()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to YPosition
            c.YPosition = 50;
            //test sample date equal to myclass public property
            Assert.AreEqual(50, c.YPosition);
        }

        //This is test method for int Width
        /// <summary>
        /// This is test method for int Width
        /// </summary>
        [TestMethod]
        public void TestMyClassWidth()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to Width
            c.Width = 250;
            //test sample date equal to myclass public property
            Assert.AreEqual(250, c.Width);
        }

        //This is test method for int Height
        /// <summary>
        /// This is test method for int Height
        /// </summary>
        [TestMethod]
        public void TestMyClassHeight()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to Height
            c.Height = 450;
            //test sample date equal to myclass public property
            Assert.AreEqual(450, c.Height);
        }

        //This is test method for int XStep
        /// <summary>
        /// This is test method for int XStep
        /// </summary>
        [TestMethod]
        public void TestMyClassXStep()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to XSetp
            c.XSetp = 20;
            //test sample date equal to myclass public property
            Assert.AreEqual(20, c.XSetp);
        }

        //This is test method for int YStep
        /// <summary>
        /// This is test method for int YStep
        /// </summary>
        [TestMethod]
        public void TestMyClassYStep()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to YSetp
            c.YSetp = 20;
            //test sample date equal to myclass public property
            Assert.AreEqual(20, c.YSetp);
        }

        //This is test method for picture PlanetPic
        /// <summary>
        /// This is test method for picture PlanetPic
        /// </summary>
        [TestMethod]
        public void TestMyClassPlanetPic()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to PlanetPic
            c.PlanetPic = pictureBox;
            //test sample date equal to myclass public property
            Assert.AreEqual(pictureBox, c.PlanetPic);
        }

        //This is test method for class member drawpic
        /// <summary>
        /// This is test method for class member drawpic
        /// </summary>
        [TestMethod]
        public void TestMyClassDrawPic()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data
            c.XPosition = 1;
            c.YPosition = 2;
            c.Width = 3;
            c.Height = 4;
            Graphics screen;
            screen = c.PlanetPic.CreateGraphics();
            screen.Clear(Color.LawnGreen);
            c.DrawPic(screen);
            //test sample date equal to myclass member DrawPic
            Assert.AreEqual(pictureBox, c.PlanetPic);
            Assert.AreEqual(1, c.XPosition);
            Assert.AreEqual(2, c.YPosition);
            Assert.AreEqual(3, c.Width);
            Assert.AreEqual(4, c.Height);
        }

        //This is test method for class member move
        /// <summary>
        /// This is test method for class member move
        /// </summary>
        [TestMethod]
        public void TestMyClassMove()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data
            c.TypeId = 50;
            c.XPosition = 1000;
            c.Width = 200;    
            c.XSetp = 250;
            c.YPosition = 1000;
            c.Height = 200;
            c.YSetp = 250;
            //Use move method to check data match
            c.Move();
            //if ((c.XPosition + c.Width >= 980) || (c.XPosition <= 0))
            //{ c.XSetp = -c.XSetp; }
            //c.XPosition = c.XPosition + c.XSetp;
            //if ((c.YPosition + c.Height >= 517) || (c.YPosition <= 0))
            //{ c.YSetp = -c.YSetp; }
            //c.YPosition = c.YPosition + c.YSetp;
            //test sample date equal to myclass member move
            Assert.AreEqual(750, c.XPosition);
            Assert.AreEqual(750, c.YPosition);
        }

        //This is test method for class member tostring
        /// <summary>
        /// This is test method for class member tostring
        /// </summary>
        [TestMethod]
        public void TestMyClassToString()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);
            //set up sample data to PlanetPic
            c.PlanetId = "Test Id1";
            c.TypeName = "Earth";
            c.XSetp = 1;
            c.YSetp = 5;
            //test sample date equal to myclass public property
            Assert.AreEqual("Test Id1 (Earth). X speed: 1, Y speed: 5", c.ToString());
        }

        //This is test method for class constructor
        /// <summary>
        /// This is test method for class constructor
        /// </summary>
        [TestMethod]
        public void TestMyClassConstructor()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare string i and set up sample data
            string i = "Test Id1";
            //Declare int h and set up sample data
            int h = 6;
            //Declare myclass c
            MyClass c = new MyClass(i, pictureBox, h);        
            //test sample date equal to myclass constructor
            Assert.AreEqual(i, c.PlanetId);
            Assert.AreEqual(h, c.TypeId);
        }
    }


    //This is index for different class testing
    /// <summary>
    /// //This is index for different class testing
    /// </summary>
    /// <remarks>
    /// for public class Filter
    /// </remarks>
    [TestClass]
    //This is test for public class Filter
    public class FilterUnitTest
    {
        //This is test method for sortAZ
        /// <summary>
        /// This is test method for sortAZ
        /// </summary>
        [TestMethod]
        public void TestFilterSortAZ()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c1,c2,c3 and set up sample data
            MyClass c1 = new MyClass("Test Id1", pictureBox, 6);
            c1.TypeName = "Earth";

            MyClass c2 = new MyClass("Test Id1", pictureBox, 6);
            c2.TypeName = "Mercury";

            MyClass c3 = new MyClass("Test Id1", pictureBox, 6);
            c3.TypeName = "Venus";
            //Create a list for sample data
            List<MyClass> ListExpected = new List<MyClass>();
            ListExpected.Add(c1);
            ListExpected.Add(c2);
            ListExpected.Add(c3);
            //create a list for application
            List<MyClass> clist = new List<MyClass>();
            clist.Add(c3);
            clist.Add(c2);
            clist.Add(c1);
            //declare f, use sortAZ method add to application list
            Filter f = new Filter();
            clist = f.SortAZ(clist);
            //compare sample data list with application list
            CollectionAssert.AreEqual(ListExpected, clist);
        }

        //This is test method for sortZA 
        /// <summary>
        /// This is test method for sortZA
        /// </summary>
        [TestMethod]
        public void TestFilterSortZA()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c1,c2,c3 and set up sample data
            MyClass c1 = new MyClass("Test Id1", pictureBox, 6);
            c1.TypeName = "Earth";

            MyClass c2 = new MyClass("Test Id1", pictureBox, 6);
            c2.TypeName = "Mercury";

            MyClass c3 = new MyClass("Test Id1", pictureBox, 6);
            c3.TypeName = "Venus";
            //Create a list for sample data
            List<MyClass> ListExpected = new List<MyClass>();
            ListExpected.Add(c3);
            ListExpected.Add(c2);
            ListExpected.Add(c1);
            //create a list for application
            List<MyClass> clist = new List<MyClass>();
            clist.Add(c1);
            clist.Add(c2);
            clist.Add(c3);
            //declare f, use sortZA method add to application list
            Filter f = new Filter();
            clist = f.SortZA(clist);
            //compare sample data list with application list
            CollectionAssert.AreEqual(ListExpected, clist);
        }

        //This is test method for Search
        /// <summary>
        /// This is test method for Search
        /// </summary>
        [TestMethod]
        public void TestFilterSearch()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c1,c2,c3 and set up sample data
            MyClass c1 = new MyClass("Test Id1", pictureBox, 6);
            c1.TypeName = "Earth";

            MyClass c2 = new MyClass("Test Id1", pictureBox, 6);
            c2.TypeName = "Mercury";

            MyClass c3 = new MyClass("Test Id1", pictureBox, 6);
            c3.TypeName = "Venus";
            //Create a list for sample data
            List<MyClass> clist = new List<MyClass>();
            clist.Add(c1);
            clist.Add(c2);
            clist.Add(c3);
            //declare f, results. Use search method add to application list
            Filter f = new Filter();
            List<MyClass> results = new List<MyClass>();
            results = f.Search(clist, "a");
            //use collectionassert contains and doesnotcontain check data
            CollectionAssert.Contains(results, c1);
            CollectionAssert.DoesNotContain(results, c2);
            CollectionAssert.DoesNotContain(results, c3);
        }
    }


    //This is index for different class testing
    /// <summary>
    /// //This is index for different class testing
    /// </summary>
    /// <remarks>
    /// for public class FileManager
    /// </remarks>
    [TestClass]
    //This is test for public class FileManager
    public class FileManagerUnitTest
        {
        //This is test method for filemanager load planets
        /// <summary>
        /// This is test method for filemanager load planets
        /// </summary>
        [TestMethod]

        public void TestFileManagerLoadPlanets()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("planet 1", pictureBox, 1);


            /*************************************************************
             * Unit Test for FileManager LoadPlanets Failed
             This below it is my train of thought for testing solution
             ************************************************************
             
             I need to test sample list data match to my FileManger LoadPlanet loading list data
             Successfully loaed txt file to list from Benchmark Application\BMunitTests\bin\Debug
             But result failed as I know my method to set up a sample list it is wrong*/

            c.PlanetId = "planet 1";
            c.TypeId = 1;
            List<MyClass> m = new List<MyClass>();
            m.Add(c);

            //Delcare new fm
            FileManager fm = new FileManager();
            //Create a new list
            List<MyClass> list = new List<MyClass>();
            //loading txt file by filemanager to list
            list = fm.LoadPlanets("planets.txt");
            //use collectionassert to check two list if it is equal
            CollectionAssert.AreEqual(m, list);
            }

        //This is test method for filemanager save planets
        /// <summary>
        /// This is test method for filemanager save planets
        /// </summary>
        [TestMethod]
        public void TestFileManagerSavePlanets()
        {
            //Declare new picturebox
            PictureBox pictureBox = new PictureBox();
            //picture soure from local file
            pictureBox.Image = Image.FromFile("Earth.png");
            //Declare myclass c
            MyClass c = new MyClass("Test Id1", pictureBox, 6);


            /*************************************************************
             * Unit Test for FileManager SavePlanet Failed
             This below it is my train of thought for testing solution
             ************************************************************

             My idea is using load method to verify save method
             Loading A text file to A_LIST, then save A_LIST to B text file(no data in this file)
             Back to first step but loading B text file to B_LIST, from here I Can match A_LIST with B_LIST
             But result is failed*/

            //Delcare new fm
            FileManager fm = new FileManager();
            //Create a new list
            List<MyClass> list = new List<MyClass>();
            //loading txt file by filemanager load method to list
            list = fm.LoadPlanets("planets.txt");

            /*save txt file by filemanager save method to file
             * that means "planets.txt" = "NewData.txt"(I have checked file, ABSOLUTELY matching!!!!!!)*/
            fm.SavePlanet(list, "NewData.txt");

            //create a new Newlist
            List<MyClass> Newlist = new List<MyClass>();
            //Read file "NewData.txt" just saved to a new list
            Newlist = fm.LoadPlanets("NewData.txt");
           
            //matching two list
            CollectionAssert.AreEqual(Newlist ,list);
        }

    }

}
