using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace TestDemo
{
	public partial class Animation : UserControl
	{
		public Animation()
		{
			// Required to initialize variables
			InitializeComponent();

            this.Rotate.Begin();
		}
    }
}