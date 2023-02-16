using System;

namespace ChaosSoft.NeuralNetwork.Activation;

public static class ActivationFunctionsMath
{
    /// <summary>
    /// Gets hyperbolic secant of argument.
    /// </summary>
    /// <param name="arg">input argument</param>
    /// <returns>value of hyperbolic secant</returns>
    public static double Sech(double arg) =>
        Math.Abs(arg) < 22d ?
        2d / (Math.Exp(arg) + Math.Exp(-arg)) :
        0d;
}
