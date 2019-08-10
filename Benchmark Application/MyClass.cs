using System;
using System.Collections.Generic;//add system collections generic
using System.Drawing;//add system drawing
using System.Linq;//add sysytem Linq
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//add system windows form

//namespace allow user access to other classes in the sama namespace
namespace Benchmark_Application
{
    //This is MyClass to store data and objects
    /// <summary>
    /// This is <c>MyClass</c> to store data and objects
    /// <list type="bullet">
    /// <item>
    /// <term>DrawPic</term>
    /// <description>picture display method</description>
    /// </item>
    /// <item>
    /// <term>Move</term>
    /// <description>simulate moving method</description>
    /// </item>
    /// </list>
    /// </summary>
    /// <remarks>
    /// This class can set initual data, picture and simulate object moveing
    /// </remarks>
    public class MyClass
    {
        //private variables or fields
        /// <summary>
        /// Store for private properties
        /// </summary>
        /// <remarks>
        /// fields include planetId, typeid, typename, Xposition, Yposition, width, height, xstep, ystep and planetpic
        /// </remarks>
        private string planetId;//private variables planet ID
        private int typeId;//private variables  plantes type ID
        private string typeName;//private variables planet type name
        private int xPosition;//private variables X position
        private int yPosition;//private variables Y position
        private int width;//private variables width
        private int height;//private variables height
        private int xSetp;//private variables X move speed
        private int ySetp;//private variables Y move speed
        private PictureBox planetPic;//private variables picture

        //public property allow user to access these variables
        /// <summary>
        /// store for public properties
        /// </summary>
        /// <remarks>
        /// fields includ planetId, typeid, typename, Xposition, Yposition, width, height, xstep, ystep and planetpic
        /// </remarks>
        //pubulic property planet ID
        ///<value>gets the value of PlanetId</value>
        public string PlanetId { get => planetId; set => planetId = value; }
        //pubulic property  plantes type ID
        ///<value>gets the value of TypeId</value>
        public int TypeId { get => typeId; set => typeId = value; }
        //pubulic property planet type name
        ///<value>gets the value of TypeName</value>
        public string TypeName { get => typeName; set => typeName = value; }
        //pubulic property X position
        ///<value>gets the value of XPosition</value>
        public int XPosition { get => xPosition; set => xPosition = value; }
        //pubulic property Y position
        ///<value>gets the value of YPosition</value>
        public int YPosition { get => yPosition; set => yPosition = value; }
        //pubulic property width
        ///<value>gets the value of Width</value>
        public int Width { get => width; set => width = value; }
        //pubulic property height
        ///<value>gets the value of Height</value>
        public int Height { get => height; set => height = value; }
        //pubulic property X move speed
        ///<value>gets the value of XSetp</value>
        public int XSetp { get => xSetp; set => xSetp = value; }
        //pubulic property Y move speed
        ///<value>gets the value of YSetp</value>
        public int YSetp { get => ySetp; set => ySetp = value; }
        //pubulic property picture
        ///<value>gets the value of PlantePic</value>
        public PictureBox PlanetPic { get => planetPic; set => planetPic = value; }      

        //This is construtor would be set initial data
        //constructor with three parameters
        /// <summary>
        /// This is construtor would be set initial data
        /// </summary>
        /// <remarks>
        /// constructor with three parameters: id, myclasspic and seed
        /// </remarks>
        /// <param name="id">a string number</param>
        /// <param name="myclasspic">a picture parameter</param>
        /// <param name="seed">an integer number</param>
        public MyClass(string id, PictureBox myclasspic, int seed)
        {
            //set public property PlanetId to id
            PlanetId = id;
            //set public property TypeId to seed
            TypeId = seed;

            //set up type name by swith statement
            switch (TypeId)
            {
                //set case 1 and typename
                case 1:
                    TypeName = "Earth";
                    break;
                //set case 2 and typename
                case 2:
                    TypeName = "Mercury";
                    break;
                //set default and typename
                default:
                    TypeName = "Venus";
                    break;
            }

            // load picture
            PlanetPic = myclasspic ;
            //set up picture location by (x,y,w,h)
            XPosition = seed * 20;
            YPosition = seed * 10;
            Width = PlanetPic.Width;
            Height = PlanetPic.Height;
            //moving speed
            XSetp = seed * 5; 
            YSetp = seed * 5 / 3;
        }


        //This is method display a picture on the background
        /// <summary>
        /// This is method display a picture on the background
        /// </summary>
        /// <param name="canvas">a canvas to specify the object location and size</param>
        public void DrawPic(Graphics canvas)
        {
            //Declare pic as image
            Image pic;
            //set up get image from planetePic
            pic = PlanetPic.Image;
            //set up image in the specific location by XPosition, YPosition, Width, Height and picture source
            canvas.DrawImage(pic, XPosition, YPosition, Width, Height);
        }
        //This is method will simulate moving, change object position
        /// <summary>
        /// This is method will simulate moving, change object position
        /// </summary>
        /// <remarks>
        /// simulate object moveing by changing object X,Y position
        /// </remarks>
        /// <example>
        /// <code>
        /// if Xposition=590, width=400 or Xposition=-100
        /// {
        ///   Xstep=-10(-Xstep)
        /// }
        /// Xposition= 590-10
        /// if Yposition=590, height=400 or Yposition=-100
        /// {
        ///   Ystep=-10(-Ystep)
        /// }
        /// Yposition= 590-10
        /// </code>
        /// </example>
        public void Move()
        {
            /*use if statement to check object width can not greater than screen picture size
             * or X position less than 0*/
            if ((XPosition + Width >= 980) || (XPosition <= 0))
            // change direction if on the edge
            { XSetp = -XSetp; }
            // move one step on x direction
            XPosition = XPosition + XSetp;

            /*use if statement to check object height can not greater than screen picture size
             * or y position less than 0*/
            if ((YPosition + Height >= 517) || (YPosition <= 0))
            // change direction if on the edge
            { YSetp = -YSetp; }
            // move one step on Y direction
            YPosition = YPosition + YSetp;
        }

        //This is override method
        // enable a object can be displayed as a string
        /// <summary>
        /// This is override method
        /// </summary>
        /// <remarks>
        /// enable a object can be displayed as a string
        /// </remarks>
        /// <returns>
        /// the string message would be displayed
        /// </returns>
        public override string ToString()
        {
            // return string displayed
            return PlanetId + " (" + TypeName + "). X speed: " + XSetp.ToString() + ", Y speed: " + YSetp.ToString();
        }
    }
}

