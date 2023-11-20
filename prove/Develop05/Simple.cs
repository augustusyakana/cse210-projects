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

    public override int EarnPoints(int total)
    {
       return base.EarnPoints(total);
    }

    public override string saveInfo()
    {
        return base.saveInfo();
    }
}