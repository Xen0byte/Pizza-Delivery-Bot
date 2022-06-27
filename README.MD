### The Challenge

You have a robot.

You are also given a file along the lines of:

```
1 1 E
RFRFRFRF
1 1 E

3 2 N
FRRFLLFFRRFLL
3 3 N

0 3 W
LLFFFLFLFL
2 4 S
```

The file contains zero to many (in this case, three) journeys.

Here is the first one:

```
1 1 E
RFRFRFRF
1 1 E
```

Each journey starts with the initial coordinates of the robot (1 1, in this case), and the direction it is pointing in; in this case E = East.

The directions are as follows:

```
N = North
E = East
S = South
W = West
```

Following the starting conditions, are a list of commands:

```
RFRFRFRF
```

Each character is a command, either to turn (L = left, R = right) or to move forwards (F).

Finally, the journey ends with another set of coordinates and a direction. This is the expected position and orientation of your robot at the end of the journey.

Your program should check that the robot ends its journey at the specified coordinates, and facing in the given direction.

The assignment is to parse the input file, set the start position of your robot, then have it execute the instructions, and check its final position with the expected position.
