namespace AmericanBowlingGame
{
    public sealed class SpareFrame : Frame {
        public SpareFrame(int roll) {
            rolls = new[] { roll, 10- roll };
        }
    }
}