namespace _7MilitaryElite
{
    public interface IMission
    {
        string Name { get; set; }
        string State { get; set; }

        void CompleteMission();
        string ToString();
    }
}