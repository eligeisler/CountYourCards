using CountYourCards.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CountYourCards.Views {

    public partial class Formular : ContentPage {
        public Formular(FormularViewModel vm) {
            InitializeComponent();
            this.BindingContext = vm;
        }
    }
}