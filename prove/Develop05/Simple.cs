using System.Reflection.Metadata;

public class Simple : Goal
{
    public Simple(bool complete, string type, string name, string description, int basePoints) : base(complete, type, name, description, basePoints)
    {

    }

    public override string AssembleGoal()
    {
        return base.AssembleGoal();
    }

    public override int EarnPoints(int points, int total)
    {
       return base.EarnPoints(points, total);
    }
}