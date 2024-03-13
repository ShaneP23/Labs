//Lab 3
//Due:2-13-22
//CIS 199-03
//Grading ID:S2223
//The purpose of this lab is to calculate the diameter, surface area, and volume.
//The user inputs the radius and the outputs are calculated and presented.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class lab3 : Form
    {
        public lab3()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)   //click calculate button
        {
            double Radius; //radius entered by user
            double Diameter; //Diameter
            double SurfaceA; //Surface area
            double Volume; //voulme

            Radius = double.Parse(radiusOfSphereTxtBox.Text);  //system reads the radius entered

            Diameter = 2 * Radius; //calculates diameter
            SurfaceA= 4*Math.PI * Math.Pow(Radius,2);  //calculates surface area
            Volume = (4 * Math.PI * Math.Pow(Radius, 3)) / 3;  //calculates volume

            diameterOutputLbl.Text = "{Diameter}";  //Assign the diameter calculation to the diameter output label
            surfaceAreaOutputLbl.Text = "{SurfaceA}";  //Assign the surface area calculation to the surface area label
            volumeOutputLbl.Text = "{Volume}";  //Assign the volume calculation to the volume label
        }

    }
}
