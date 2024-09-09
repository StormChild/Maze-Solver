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
            maze.Should().Be(_maze.current_maze);
        }
    }
}
