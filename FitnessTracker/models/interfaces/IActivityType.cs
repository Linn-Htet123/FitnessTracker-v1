namespace FitnessTracker.models.interfaces
{
    public interface IActivityType
    {
        int Id { get; }
        string ActivityName { get; }
        string Metric1Name { get; }
        string Metric1Unit { get; }
        string Metric2Name { get; }
        string Metric2Unit { get; }
        string Metric3Name { get; }
        string Metric3Unit { get; }
    }
}
