namespace ChaosSoft.NeuralNetwork.Activation;

public sealed class Linear : IActivationFunction
{
    public string Name => "Linear";

    public double Phi(double arg) => arg;

    public double Dphi(double arg) => 2d * arg;
}
