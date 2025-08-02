using System;
using System.Windows;
using System.Windows.Input;
using TestProj.model;

namespace TestProj.viewmodel
{
    public class UserControlTestVM: ViewModelBase
    {
        private string _textbox;

        public string TextBox
        {
            get => _textbox;
            set
            {
                _textbox = value;
                OnPropertyChanged();
            }
        }

        public ICommand BtnCmd { get; set; }
        
        public UserControlTestVM()
        {
            BtnCmd = new RelayCommand(OnClickedBtn, IsAccessible);
        }

        private void OnClickedBtn(object obj)
        {
            if (String.IsNullOrEmpty(TextBox)) return;
            MessageBox.Show(TextBox);
        }

        private bool IsAccessible(object obj)
        {
            //IsRegistered
            return true;
        }
    }
}