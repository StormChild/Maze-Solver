# Maze Solver

## Requirements

Visual Studion 2022
Specflow Extension for Visual Studio 2022

## Introduction

As a caveat I don't think this test id doable in one hour, just writing the tests will take more than than never mind solving the problems.
I thought I'd use the time to show off BDD style testing and development. Unfortunately I spent too much time on it already.

So what I have done is the following:

1. Create a specflow project with initial specs
2. Create a class to solve mazes
3. Create a minimal api to load and retrieve mazes

## Solution

I have researched pathfinding algorithms such as Djikstra (spelling?) and A* but I wanted to take another approach, namely from the perspective of a "player" The following is what I would do:

1. If Im not on a journey initialize the journey at starting point
2. Look for ajacent open tiles (explored = false and open = true)
3. If there are multiple open tiles, mark the tile as a junction
4. Move to the first clockwise open tile and add it to the journey as explored
5. If it is the goal, this is the end
6. If there are no open tiles this is a dead end, move back to the last junction and decrement the ajacent_open_tiles by 1 and remove the list of the journey up to the junction tile then back to 2.
7. If the junction has no more unexplored branches (ajacent open tiles) remove the junction status from the journey and move back another junction.
8. If I am out of open tiles and haven't found the goal, this maze is unsolvable.
