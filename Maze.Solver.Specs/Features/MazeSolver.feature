Feature: MazeSolver

As a human player, I would like to load, solve and recall 20x20 text based puzzles

@current
Scenario: Loading a maze
	When I parse the following maze
"""
S_________
XXXXXXXXXX
XXX_____X_
XXXXXXX_X_
XXXX__X_X_
XXXX__X_X_
XXXX____X_
XXXXXXXXX_
XXX_______
XXXXXXXXG_
"""
	Then I should have the following maze as the current maze
"""
S_________
XXXXXXXXXX
XXX_____X_
XXXXXXX_X_
XXXX__X_X_
XXXX__X_X_
XXXX____X_
XXXXXXXXX_
XXX_______
XXXXXXXXG_
"""

Scenario: Get to the starting point
	When I parse the following maze
"""
S_________
XXXXXXXXXX
XXX_____X_
XXXXXXX_X_
XXXX__X_X_
XXXX__X_X_
XXXX____X_
XXXXXXXXX_
XXX_______
XXXXXXXXG_
"""
	Then my position should be "1, 1"

Scenario: Move to the next tile
	Given I parse the following maze
"""
S_________
XXXXXXXXXX
XXX_____X_
XXXXXXX_X_
XXXX__X_X_
XXXX__X_X_
XXXX____X_
XXXXXXXXX_
XXX_______
XXXXXXXXG_
"""
	When I move to the next tile
	Then my position should be "1, 2"

Scenario: Move to a junction
	Given I parse the following maze
"""
S_________
XXXXXXXXXX
XXX_____X_
XXXXXXX_X_
XXXX__X_X_
XXXX__X_X_
XXXX____X_
XXXXXXXXX_
XXX_______
XXXXXXXXG_
"""
	When I move to position "7, 8"
	Then The fact that I'm on a junction should be true
	And There should be 2 ajacent open tiles

Scenario: Get to a dead end
	Given I parse the following maze
"""
S_________
XXXXXXXXXX
XXX_____X_
XXXXXXX_X_
XXXX__X_X_
XXXX__X_X_
XXXX____X_
XXXXXXXXX_
XXX_______
XXXXXXXXG_
"""
	And the following tiles have been explored
	| Tile   |
	| "5, 5" |
	| "5, 6" |
	| "6, 5" |
	| "7, 5" |
	| "7, 6" |
	| "7, 8" |
	And I am currently on tile "6, 6"
	When I move to the next tile
	Then I should be at the junction "7, 9"
