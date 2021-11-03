using System;

namespace HeronSeTriangulo
{
    class Program
    {
        static string RetornaTipoTriangulo(double[] _triangulo){
            if( _triangulo[0] == _triangulo[1] &&
                _triangulo[1] == _triangulo[2] &&
                _triangulo[2] == _triangulo[0]){
                return "Equilátero";
            }
            if( _triangulo[0] != _triangulo[1] &&
                _triangulo[1] != _triangulo[2] &&
                _triangulo[2] != _triangulo[0]){
                return "Escaleno";
            }
            else{
                return "Isósceles";
            }
        }
        static void Main(string[] args)
        {
            double[] _triangulo = new double[3];
            Console.WriteLine("--- Teorema de Heron ---");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Digite o {i+1}º lado do triângulo: ");
                double.TryParse(Console
                .ReadLine()
                .ToString(), out _triangulo[i]);
                if(_triangulo[i] < 0){
                    Console.WriteLine("Você digitou um valor menor que zero.");
                    return;
                }
            }

            if(_triangulo[0] < (_triangulo[1]+_triangulo[2])){
                if(_triangulo[0] > Math.Abs(_triangulo[1]-_triangulo[2])){
                    if(_triangulo[1] < (_triangulo[1]+_triangulo[2])){
                        if(_triangulo[1] > Math.Abs(_triangulo[0] - _triangulo[2])){
                            if(_triangulo[2] < (_triangulo[0] + _triangulo[1])){
                                if(_triangulo[2] > Math.Abs(_triangulo[0] - _triangulo[1])){
                                    string _tipoTriangulo = RetornaTipoTriangulo(_triangulo);
                                    Console.WriteLine($"\nTipo do triângulo: {_tipoTriangulo}");

                                    double _s = (_triangulo[0]+_triangulo[1]+_triangulo[2])/2;
                                    double _area = Math.Round(Math
                                    .Sqrt(_s*(_s-_triangulo[0])*(_s-_triangulo[1])*(_s-_triangulo[2])),2);

                                    Console.WriteLine($"Área do Triângulo: {_area}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}