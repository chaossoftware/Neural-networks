using System;

namespace ChaosSoft.NeuralNetwork.Activation;

public sealed class Gaussian : IActivationFunction
{
    public string Name => "Gaussian";

    public double Phi(double arg) => Math.Exp(-arg * arg);

    public double Dphi(double arg) => -2d * arg * Math.Exp(-arg * arg);
}
