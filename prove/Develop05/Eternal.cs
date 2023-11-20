public class Eternal : Goal
{
    public Eternal(bool complete, string type, string name, string description, int basePoints) : base(complete, type, name, description, basePoints)
    {

    }

    public override string AssembleGoal()
    {
        return $"{tracker} {getName()} {getDescription()}";
    }
    public override int EarnPoints(int points, int total)
    {
        return base.EarnPoints(points, total);
    }


}