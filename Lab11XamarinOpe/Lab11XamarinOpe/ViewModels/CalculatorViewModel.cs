using Lab11XamarinOpe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;


using System.Windows.Input;


namespace Lab11XamarinOpe.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private int operand1;
        private int operand2;
        private int result;

        public int Operand1
        {
            get { return operand1; }
            set
            {
                operand1 = value;
                OnPropertyChanged();
            }
        }

        public int Operand2
        {
            get { return operand2; }
            set
            {
                operand2 = value;
                OnPropertyChanged();
            }
        }

        public int Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand => new Command(Add);
        public ICommand SubtractCommand => new Command(Subtract);
        public ICommand MultiplyCommand => new Command(Multiply);
        public ICommand DivideCommand => new Command(Divide);

        public CalculatorViewModel()
        {
        }

        private void Add()
        {
            Result = Operand1 + Operand2;
        }

        private void Subtract()
        {
            Result = Operand1 - Operand2;
        }

        private void Multiply()
        {
            Result = Operand1 * Operand2;
        }

        private void Divide()
        {
            if (Operand2 != 0)
                Result = Operand1 / Operand2;
            else
                Result = 0; // Manejo del error de división por cero
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
