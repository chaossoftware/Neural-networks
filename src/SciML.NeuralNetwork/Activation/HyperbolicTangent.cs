using System;

namespace SciML.NeuralNetwork.Activation;

public sealed class HyperbolicTangent : IActivationFunction
{
    public string Name => "Hyperbolic tangent";

    public double Phi(double arg) =>
        Math.Tanh(arg);

    public double Dphi(double arg)
    {
        double th = Math.Tanh(arg);
        return 1d - th * th;
    }
}
