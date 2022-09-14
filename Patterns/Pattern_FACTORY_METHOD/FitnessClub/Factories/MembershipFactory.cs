using Pattern_FACTORY_METHOD.FitnessClub.Domain;

namespace Pattern_FACTORY_METHOD.FitnessClub.Factories;
internal abstract class MembershipFactory
{
    public abstract IMembership GetMembership();
}
