using System;

namespace SciML.NeuralNetwork.Activation;

public sealed class HyperbolicTangentV2 : IActivationFunction
{
    public string Name => "Hyperbolic tangent v2";

    public double Phi(double arg) =>
        arg < 22d ?
        1d - 2d / (Math.Exp(2d * arg) + 1d) :
        Math.Sign(arg);

    public double Dphi(double arg)
    {
        double tmp = ActivationFunctionsMath.Sech(arg);
        return tmp * tmp;
    }
}
