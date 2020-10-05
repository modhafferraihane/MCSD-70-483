using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonneModel personne = new PersonneModel();
            //Définis personne
            ViewModel viewModel = new ViewModel(personne);
        }

    }
    class PersonneModel : IModel
    {
        public void Créer()
        {
            
        }

        public void mettreajour()
        {
            
        }

        public void supprimer()
        {
            
        }
    }
    interface IModel
    {
        void Créer();
        void mettreajour();
        void supprimer();
    }
    interface IView
    {
        void afficher();
    }
    class ViewModel : INotifyPropertyChanged
    {
        IModel _model;
        IView _view;
        private object Propriété;

        public ViewModel(IModel model)
        {
            _model = model;
        }
        public ViewModel(IModel model,IView view)
        {
            _model = model;
            _view = view;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Propriété)));
        }

        void créer()
        {
            //Du code
            _model.Créer();
        }
        void mettreajour()
        {
            //Du code
            _model.mettreajour();
        }
        void supprimer()
        {
            //Du code
            _model.supprimer();
        }
    }
}
