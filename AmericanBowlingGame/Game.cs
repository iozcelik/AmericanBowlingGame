using System;
using System.Collections.Generic;

namespace AmericanBowlingGame {
    public class Game {
        readonly List<Frame> frames = new List<Frame>();

        public void Missing(int firstRoll, int secondRoll) {
            frames.Add(new MissingFrame(firstRoll, secondRoll));
        }

        public void Spare(int roll) {
            frames.Add(new SpareFrame(roll));
        }

        public void Strike() {
            frames.Add(new StrikeFrame());
        }

        public void Bonus(int roll) {
            frames.Add(new BonusFrame(roll));
        }

        public int GetScore() {
            var score = 0;
            try {
                for (int i = 0; i < frames.Count; i++) {
                    var currentFrame = frames[i];
                    switch (currentFrame) {
                        case MissingFrame missingFrame:
                            score += missingFrame.rolls[0] + missingFrame.rolls[1];
                            break;
                        case SpareFrame _:
                            score += 10 + frames[i + 1].rolls[0];
                            break;
                        case StrikeFrame _:
                            score += 10 + frames[i + 1].rolls[0] + frames[i + 2].rolls[0];
                            break;
                    }
                }
            } catch (Exception e) {
                Console.WriteLine(e);
            }

            return score;
        }
    }
}
