using System;

namespace SciML.NeuralNetwork.Activation;

public sealed class Logistic : IActivationFunction
{
    public string Name => "Logistic";

    public double Phi(double arg) =>
        1 / (1 + Math.Pow(Math.E, -arg));

    public double Dphi(double arg)
    {
        double fx = Phi(arg);
        return fx * (1 - fx);
    }
}
