using System;
using TechTalk.SpecFlow;

namespace Maze.Solver.Specs.StepDefinitions
{
    [Binding]
    public class MazeSolverStepDefinitions
    {
        Maze _maze = new Maze();
        
        [When(@"I parse the following maze")]
        public void WhenIParseTheFollowingMaze(string maze)
        {
            _maze.parse(maze);
        }


        [Then(@"I should have the following maze as the current maze")]
        public void ThenIShouldHaveTheFollowingMazeAsTheCurrentMaze(string maze)
        {
            _maze.current_maze.Should().Be(maze);
        }

        [Then(@"my position should be ""([^""]*)""")]
        public void ThenMyPositionShouldBe(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I parse the following maze")]
        public void GivenIParseTheFollowingMaze(string multilineText)
        {
            throw new PendingStepException();
        }

        [When(@"I move to the next tile")]
        public void WhenIMoveToTheNextTile()
        {
            throw new PendingStepException();
        }

        [When(@"I move to position ""([^""]*)""")]
        public void WhenIMoveToPosition(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The fact that I'm on a junction should be true")]
        public void ThenTheFactThatImOnAJunctionShouldBeTrue()
        {
            throw new PendingStepException();
        }

        [Then(@"There should be (.*) ajacent open tiles")]
        public void ThenThereShouldBeAjacentOpenTiles(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the following tiles have been explored")]
        public void GivenTheFollowingTilesHaveBeenExplored(Table table)
        {
            throw new PendingStepException();
        }

        [Given(@"I am currently on tile ""([^""]*)""")]
        public void GivenIAmCurrentlyOnTile(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"I should be at the junction ""([^""]*)""")]
        public void ThenIShouldBeAtTheJunction(string p0)
        {
            throw new PendingStepException();
        }

    }
}
