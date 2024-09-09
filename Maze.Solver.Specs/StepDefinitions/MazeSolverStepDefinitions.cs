using System;
using TechTalk.SpecFlow;

namespace Maze.Solver.Specs.StepDefinitions
{
    [Binding]
    public class MazeSolverStepDefinitions
    {
        [Given(@"I have the following maze")]
        public void GivenIHaveTheFollowingMaze(string multilineText)
        {
            throw new PendingStepException();
        }

        [When(@"I parse the maze")]
        public void WhenIParseTheMaze()
        {
            throw new PendingStepException();
        }

        [Then(@"I should have the following maze as the current maze")]
        public void ThenIShouldHaveTheFollowingMazeAsTheCurrentMaze(string multilineText)
        {
            throw new PendingStepException();
        }
    }
}
