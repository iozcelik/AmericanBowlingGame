namespace AmericanBowlingGame
{
    public sealed class MissingFrame : Frame {
        public MissingFrame(int firstRoll, int secondRoll) {
            rolls = new[] { firstRoll, secondRoll };
        }
    }
}