using System;
using System.Windows;
using System.Windows.Controls;
using TestProj.viewmodel;

namespace TestProj.view.usercontrol
{
    public partial class UserControlTest : UserControl
    {
        private UserControlTestVM _vm;
        public UserControlTest()
        {
            InitializeComponent();
            _vm = new UserControlTestVM();
            DataContext = _vm;
        }
    }
}