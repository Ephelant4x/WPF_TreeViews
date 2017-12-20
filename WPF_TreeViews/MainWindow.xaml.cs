using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_TreeViews
{
    public partial class MainWindow : Window
    {
        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>

        #endregion

        #region On Loaded
        /// <summary>
        /// When the application first opens
        /// </summary>
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Get logical drives on machine 
            foreach (var drive in Directory.GetLogicalDrives())
            {
                //Create new item for it
                var item = new TreeViewItem();
                
                //Set header and path
                item.Header = drive;
                item.Tag = drive;

                item.Items.Add(null);

                //Add to main tree-view
                FolderView.Items.Add(item);
            }
        }
        #endregion


    }
}
