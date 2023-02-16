using System;

namespace ChaosSoft.NeuralNetwork.Activation;

public sealed class Cosine : IActivationFunction
{
    public string Name => "Cosine";

    public double Phi(double arg) => Math.Cos(arg);

    public double Dphi(double arg) => Math.Cos(arg);
}
