namespace ChaosSoft.NeuralNetwork.Activation;

public sealed class LogisticV2 : IActivationFunction
{
    public string Name => "Logistic v2";

    public double Phi(double arg) => arg * (1d - arg);

    public double Dphi(double arg) => 1d - 2d * arg;
}
