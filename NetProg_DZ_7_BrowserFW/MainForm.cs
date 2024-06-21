using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetProg_DZ_7_BrowserFW
{

	public partial class MainForm : Form
	{
		string GoogleSearch = "https://www.google.ru/search?q=%D0%BF%D1%80%D0%B8%D0%B2%D0%B5%D1%82";
		string YandexSearch = "https://ya.ru/search/?text=";
		string BingSearch = "https://www.bing.com/search?q=";
		public MainForm()
		{
			InitializeComponent();
			comboBoxSearchSystem.SelectedIndex = 0;
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			webBrowserMain.ScriptErrorsSuppressed = true;
			if (comboBoxSearchSystem.SelectedIndex == 0)
			{				
				string request = GoogleSearch+textBoxUri.Text;
				webBrowserMain.Navigate(request);
			}
			if (comboBoxSearchSystem.SelectedIndex == 1)
			{
				string request = YandexSearch + textBoxUri.Text;
				webBrowserMain.Navigate(request);
			}
			if (comboBoxSearchSystem.SelectedIndex == 2)
			{
				string request = BingSearch + textBoxUri.Text;
				webBrowserMain.Navigate(request);
			}
		}
	}

}
