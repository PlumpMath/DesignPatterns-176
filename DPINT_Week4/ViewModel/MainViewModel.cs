using GalaSoft.MvvmLight;
using System;

namespace DPINT_Week4.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        static SudokuView sudoView = new SudokuView();

        public int[] SudokuField
        {
            get
            {
                Console.WriteLine("returns array");
                return sudoView.SudokuField;
            }
            set
            {
                sudoView.SudokuField = value;
                //deze wordt nooit aangeroepen
                Console.WriteLine("hallow");
            }
        }

        public MainViewModel()
        {
            Console.WriteLine("Console is working");

        }
    }
}