﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalAppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Ragnarok4 : ContentPage
	{
		public Ragnarok4 ()
		{
			InitializeComponent ();
            //calling function
            SetUpImages();
		}


        private void SetUpImages()
        {
            // function to set up images
            var assembly = typeof(MainPage);
            

            string strFilename8 = "FinalAppProject.Assets.Images.RagnarokImage8.jpg";
            RagnarokImage8.Source = ImageSource.FromResource(strFilename8, assembly);


            string strFilename9 = "FinalAppProject.Assets.Images.RagnarokImage9.jpg";
            RagnarokImage9.Source = ImageSource.FromResource(strFilename9, assembly);


            string strFilename10 = "FinalAppProject.Assets.Images.RagnarokImage10.jpg";
            RagnarokImage10.Source = ImageSource.FromResource(strFilename10, assembly);


            string strFilename11 = "FinalAppProject.Assets.Images.RagnarokImage11.jpg";
            RagnarokImage11.Source = ImageSource.FromResource(strFilename11, assembly);


        }
    }
}