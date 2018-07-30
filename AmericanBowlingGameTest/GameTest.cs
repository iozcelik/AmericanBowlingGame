using AmericanBowlingGame;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmericanBowlingGameTest {
    [TestClass]
    public class GameTest {
        private Game game;
        [TestMethod]
        public void SuperBowler_300() {
            game = new Game();
            for (int i = 0; i < 10; i++) {
                game.Strike();
            }
            game.Bonus(10);
            game.Bonus(10);

            var result = game.GetScore();
            Assert.AreEqual(300, result);
        }

        [TestMethod]
        public void MissAlwaysSecondRoll_90() {
            game = new Game();
            for (int i = 0; i < 10; i++) {
                game.Missing(9, 0);
            }

            var result = game.GetScore();
            Assert.AreEqual(90, result);
        }

        [TestMethod]
        public void Spare_150() {
            game = new Game();
            for (int i = 0; i < 10; i++) {
                game.Spare(5);
            }
            game.Bonus(5);

            var result = game.GetScore();
            Assert.AreEqual(150, result);
        }
    }
}
