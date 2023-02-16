using System;

namespace ChaosSoft.NeuralNetwork.Activation
{
    public sealed class Sinc : IActivationFunction
    {
        public string Name => "Sinc";

        public double Phi(double arg) =>
            arg == 0 ?
            1 :
            Math.Sin(arg) / arg;

        public double Dphi(double arg) =>
            arg == 0 ?
            0 :
            Math.Cos(arg) / arg - Math.Sin(arg) / (arg * arg);
    }
}
