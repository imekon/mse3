﻿using System.Windows.Media.Media3D;
using mse.Models;
using mse.Models.Parameters;

namespace mse.ViewModels
{
    public class ShapeViewModel : ViewModelBase
    {
        protected readonly Shape shape;
        protected readonly Visual3D visual;

        public ShapeViewModel(Shape shape, Visual3D visual)
        {
            this.shape = shape;
            this.visual = visual;
        }

        public ShapeViewModel(Shape shape) : this(shape, null)
        {
            
        }

        public string Name
        {
            get { return shape.Parameters.GetParameter<string>("name").Value; }
            set
            {
                var name = "";
                if (SetProperty(ref name, value))
                {
                    shape.Parameters.SetParameter("name", new StringValue(name));
                }
            }
        }

        public Visual3D Visual => visual;
    }
}