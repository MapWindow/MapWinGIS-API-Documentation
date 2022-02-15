﻿
#if nsp
namespace MapWinGIS
{
#endif
    using System;

    /// <summary>
    /// Represents a set of visualization options for shapefile layer.
    /// </summary>
    /// <remarks>
    /// The set of options is represented by instance of ShapeDrawingOptions class which can be accessed by ShapefileCategory.DrawingOptions,
    /// while ShapefileCategory.Expression is used for mapping this options to particular shapes.
    /// </remarks>
    /// Here is a diagram for the ShapefileCategory class.
    /// \dot
    /// digraph shapefilecategory_diagram {
    /// nodesep = 0.3;
    /// ranksep = 0.3;
    /// splines = ortho;
    /// 
    /// node [shape= "polygon", peripheries = 3, fontname=Helvetica, fontsize=9, color = gray, style = filled, height = 0.2, width = 0.8];
    /// cat [ label="ShapefileCategory" URL="\ref ShapefileCategory"];
    /// 
    /// node [color = tan, peripheries = 1, height = 0.3, width = 1.0];
    /// sdo [ label="ShapeDrawingOptions" URL="\ref ShapeDrawingOptions"];
    /// 
    /// node [style = dashed, color = gray];
    /// lst [ label="ShapefileCategories" URL="\ref ShapefileCategories"];
    /// 
    /// edge [ dir = none, style = solid, fontname = "Arial", fontsize = 9, fontcolor = blue, color = "#606060", labeldistance = 0.6 ]
    /// cat -> sdo [ URL="\ref ShapefileCategory.DrawingOptions", tooltip = "ShapefileCategory.DrawingOptions", headlabel = "   1"];
    /// lst -> cat [ URL="\ref ShapefileCategories.get_Item()", tooltip = "ShapefileCategories.get_Item()", headlabel = "   n"];
        /// }
    /// \enddot
    /// <a href = "diagrams.html">Graph description</a>
    ///  \new48 Added in version 4.8
    #if nsp
        #if upd
            public class ShapefileCategory : MapWinGIS.IShapefileCategory
        #else        
            public class IShapefileCategory
        #endif
    #else
        public class ShapefileCategory
    #endif
    {
        /// <summary>
        /// Gets or sets visualization options associated with the category.
        /// </summary>
        public ShapeDrawingOptions DrawingOptions
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets expression which defines shapes which belong to the category.
        /// </summary>
        public string Expression
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        
        /// <summary>
        /// Gets or sets the name of the category. The names must not be unique.
        /// </summary>
        public string Name
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets maximum value of the value range the category covers.
        /// </summary>
        /// <remarks>The value is used when cvRange is set as ShapefileCategory.ValueType.</remarks>
        /// \new493 Added in version 4.9.3
        public object MaxValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException();}
        }

        /// <summary>
        /// Gets or sets minimum value of the value range the category covers.
        /// </summary>
        /// <remarks>The value is used when either cvSingleValue, cvRange 
        /// is set for ShapefileCategory.ValueType.</remarks>
        /// \new493 Added in version 4.9.3
        public object MinValue
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Gets or sets value type for the category. 
        /// </summary>
        /// <remarks>Depending on value type either ShapefileCategory.MinValue/ShapefileCategory.MaxValue properties
        /// or ShapefileCategory.Expression are used in the calculation process. ShapefileCategories.Generate
        /// method will set cvSingleValue for unique values classification and ctRange for any 
        /// interval classification. These values are faster to apply. However manual setting of 
        /// ShapefileCategory.Expression property will change it to cvExpression.</remarks>
        /// \new493 Added in version 4.9.3
        public tkCategoryValue ValueType
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
#if nsp
}
#endif

