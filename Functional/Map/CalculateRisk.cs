using LaYumba.Functional;

namespace Functional.Map
{
    public static class CalculateRisk
    {
        public static Risk CalculateRiskProfile(Age age)
            => (age.Value < 60) ? Risk.Low : Risk.Medium;

        public static Option<Risk> RiskOf(Subject subject)
             => subject.Age.Map(CalculateRiskProfile);
    }
}