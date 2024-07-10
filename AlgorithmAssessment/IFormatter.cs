namespace AlgorithmAssessment
{
    public interface IFormatter<TInput, TValues>
    {
        string FormatInput(TInput input, TValues values);
    }    
}