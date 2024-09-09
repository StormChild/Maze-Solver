Feature: MazeSolver

As a human player, I would like to load, solve and recall 20x20 text based puzzles

@current
Scenario: Loading a maze
	Given I have the following maze
"""
S_________
*XXXXXXXX*
*X*_____X_
*X*XXXX_X_
*X*X__X_X_
*X*X__X_X_
*X*X____X_
*X*XXXXXX_
*X*_______
XXXXXXXXG_
"""
	When I parse the maze
	Then I should have the following maze as the current maze
"""
S_________
*XXXXXXXX*
*X*_____X_
*X*XXXX_X_
*X*X__X_X_
*X*X__X_X_
*X*X____X_
*X*XXXXXX_
*X*_______
XXXXXXXXG_
"""

