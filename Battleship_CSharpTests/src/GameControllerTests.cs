using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace Tests
{
    [TestClass()]
    public class GameControllerTests
    {

        [TestMethod()]
        public void SwitchStateTest()
        {
            // expected value
            GameState expected = GameState.ViewingGameMenu;

            // act
            GameController.SwitchState(expected);
            GameState actual = GameController.CurrentState;

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void AddNewState()
        {
            // expected value
            GameState expected = GameState.Deploying;

            // act
            GameController.AddNewState(expected);
            GameState actual = GameController.CurrentState;

            // assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void EndCurrentState()
        {
            // expected value
            GameState origState = GameController.CurrentState;
            GameState newState = GameState.Deploying;

            // act
            GameController.AddNewState(newState);

            //assert setup correct
            GameState actualState = GameController.CurrentState;
            Assert.AreEqual(newState, actualState);

            // act
            GameController.EndCurrentState();

            // assert result correct
            actualState = GameController.CurrentState;
            Assert.AreEqual(origState, actualState);
        }



    }
}