using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ShapesUtil.Draw;

namespace ShapesUtil
{
   
    /// <summary>
    /// This is a sample Class to test Class Creation
    /// Class is a grouping of various methods an
    /// </summary>
    class Shape
    {
        public String ShapeName;

        public void DrawShape() { Output("In Shape"); }
        
        
    }

   

    
    /// <summary>
    /// Shape Type Defining 2D/3D
    /// </summary>
    interface IShapeType
    {
        object Dim { get; set; }
        
    }
   

    /// <summary>
    /// Rectangle Class inherited from Shape and Interface ShapeType
    /// </summary>
    class Rectangle : Shape,IShapeType
    {
        #region public variables
        public int len, breadth;
        #endregion

        #region Constructors
        /// <summary>
        /// Default Rect Constructor 
        /// </summary>
        public Rectangle() : this(0, 0) { }
        
        /// <summary>
        /// additional constructor calling with lenght and breadth
        /// </summary>
        /// <param name="len"></param>
        /// <param name="breadth"></param>
        public Rectangle(int len, int breadth)
        {
            //update shape type
            ShapeName = "Rectangle";
            this.Dim = "2D";
            this.len = len;
            this.breadth = breadth;
         }
        #endregion

        public object Dim { get; set; }

        //method implementations
        
     }

    /// <summary>
    /// abstract class Polygon with CalcArea, CalcBorder and Draw Functions
    /// and No of Edges, 0 is point, 1 circle, two line, 3 triangle so on
    /// 0, 1, 2 are special case polygons defined only in this program
    /// polygon less than 3 edges is not defined in general
    /// </summary>
    abstract class Polygon
    {
        public String noofEdges;
        public abstract void CalcArea();
        public abstract void CalcBorder();
    }
}
