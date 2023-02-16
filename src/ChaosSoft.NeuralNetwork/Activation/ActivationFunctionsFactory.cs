using System;

namespace ChaosSoft.NeuralNetwork.Activation;

public class ActivationFunctionsFactory
{
    /// <summary>
    /// Creates activation function of specified type.
    /// </summary>
    /// <typeparam name="T">activation function type</typeparam>
    /// <param name="type">type of activation function</param>
    /// <returns>instance of activation function</returns>
    public static IActivationFunction Get<T>(T type) where T : IActivationFunction =>
        (T)Activator.CreateInstance(type.GetType());
}
