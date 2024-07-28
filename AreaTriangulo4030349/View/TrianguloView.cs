using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using AreaTriangulo4030349.Models;
using System.Windows.Input;


namespace AreaTriangulo4030349.View
{
    internal class TrianguloView : INotifyPropertyChanged
    {
        private Triangulo _triangulo;
        private double? _ladoA;
        private double? _ladoB;
        private double? _ladoC;
        private double? _area;

        public TrianguloView()
        {
            _triangulo = new Triangulo();
            CalcularAreaCommand = new Command(CalcularArea);
        }

        public double? LadoA
        {
            get => _ladoA;
            set
            {
                if (_ladoA != value)
                {
                    _ladoA = value;
                    OnPropertyChanged();
                    ActualizarTriangulo();
                }
            }
        }

        public double? LadoB
        {
            get => _ladoB;
            set
            {
                if (_ladoB != value)
                {
                    _ladoB = value;
                    OnPropertyChanged();
                    ActualizarTriangulo();
                }
            }
        }

        public double? LadoC
        {
            get => _ladoC;
            set
            {
                if (_ladoC != value)
                {
                    _ladoC = value;
                    OnPropertyChanged();
                    ActualizarTriangulo();
                }
            }
        }

        public double? Area
        {
            get => _area;
            private set
            {
                if (_area != value)
                {
                    _area = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularAreaCommand { get; }

        private void CalcularArea()
        {
            if (LadoA.HasValue && LadoB.HasValue && LadoC.HasValue)
            {
                _triangulo.LadoA = LadoA.Value;
                _triangulo.LadoB = LadoB.Value;
                _triangulo.LadoC = LadoC.Value;

                Area = _triangulo.CalcularArea();
            }
            else
            {
                Area = null; // Si falta algún lado, no se puede calcular el área.
            }
        }

        private void ActualizarTriangulo()
        {
            _triangulo.LadoA = LadoA ?? 0;
            _triangulo.LadoB = LadoB ?? 0;
            _triangulo.LadoC = LadoC ?? 0;
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
