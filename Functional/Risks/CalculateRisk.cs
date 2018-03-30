using LaYumba.Functional;

namespace Functional.Risks
{
    public class CalculateRisk
    {
        public static Risk CalculateRiskProfile(Age age)
            => (age.Value < 60) ? Risk.Low : Risk.Medium;

        public Option<Risk> RiskOf(Subject subject)
             => subject.Age.Map(CalculateRiskProfile);
    }
}