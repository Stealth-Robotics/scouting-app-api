using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ScoutingAPICore
{
	public class BooleanProperty : IScoutedProperty
	{
		public string Header
		{ get; set; }

		public UIElement UIForm()
		{
			return new CheckBox();
		}
	}
}
