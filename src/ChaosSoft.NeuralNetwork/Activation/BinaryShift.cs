namespace ChaosSoft.NeuralNetwork.Activation;

public sealed class BinaryShift : IActivationFunction
{
    public string Name => "Binary shift";

    public double Phi(double arg) => arg % 1d;

    public double Dphi(double arg) => 1d;
}
