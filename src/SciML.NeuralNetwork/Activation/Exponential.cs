using System;

namespace SciML.NeuralNetwork.Activation;

public sealed class Exponential : IActivationFunction
{
    public string Name => "Exponential";

    public double Phi(double arg) => Math.Exp(arg);

    public double Dphi(double arg) => Math.Exp(arg);
}
