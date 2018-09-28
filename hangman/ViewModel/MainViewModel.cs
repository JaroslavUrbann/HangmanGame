using System;
using Base.ViewModel;
using Base.Command;
using System.Windows;

namespace hangman.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        #region Globální proměnné ViewModelu
        private string _slovo;
        private string _slovo2;
        private int _obrazek;
        private Model.NovaHra NH;
        private Model.RegistrujPismeno RP;
        #endregion

        #region Deklarace bindovatelných vlastností
        public string Slovo { get { return _slovo; } set { _slovo = value; ChangeProperty("Slovo"); } }
        public string Slovo2 { get { return _slovo2; } set { _slovo2 = value; ChangeProperty("Slovo2"); } }
        public int Obrazek { get { return _obrazek; } set { _obrazek = value; ChangeProperty("Obrazek"); } }
        #endregion

        #region Deklarace Command
        public Command<string> _registrujPismeno { get; set; }
        public Command _novaHra { get; set; }
        #endregion

        #region Metody pro obsluhu Command

        public void RegistrujPismeno(string _pismeno)
        {
            if (Slovo2 == Slovo) { NovaHra(); }
            else
            {
                Slovo2 = RP.Registrace(Slovo2, Slovo, _pismeno);
                Obrazek = RP.chyb;
                if (Slovo2 == Slovo) { MessageBox.Show("Vyhra"); }
                if (Obrazek == 12) { Slovo2 = Slovo; MessageBox.Show("Prohra"); };
            }
       }

        public void NovaHra()
        {
            Slovo = NH.VraceckaSlova();
            Slovo2 = NH.VraceckaSlova2();
            RP.chyb = 0;
            Obrazek = 0;
        }

        #endregion

        public MainViewModel()
        {
            Obrazek = 0;
            _registrujPismeno = new Command<string>(RegistrujPismeno);
            _novaHra = new Command(NovaHra);
            RP = new Model.RegistrujPismeno();
            NH = new Model.NovaHra();
        }

        public new void ChangeProperty(string propertyName) { base.ChangeProperty(propertyName); }
    }
}
