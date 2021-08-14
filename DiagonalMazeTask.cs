using System;

namespace Mazes
{
	public static class DiagonalMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			if (width > height)
            {
				int stepSize = (int)Math.Round((double)width / height); ;
				MoveOut(robot, Direction.Right, stepSize, width, height);
            }
			else
            {
				int stepSize = (int)Math.Round((double)height / width);
				MoveOut(robot, Direction.Down, stepSize, height, width);
			}
		}

		public static void MoveOut(Robot robot, Direction direction, int stepSize, int directLength, int subDirectLength)
        {
			for (int i = 1; i < directLength - 2; i += stepSize)
            {
				MoveToDirect(robot, direction, stepSize);
				int subPosition = direction == Direction.Right ? robot.Y : robot.X; 
				if (subPosition < subDirectLength - 2)
					robot.MoveTo(direction == Direction.Right ? Direction.Down : Direction.Right);
            }
        }

		public static void MoveToDirect(Robot robot, Direction direction, int stepSize)
        {
			for (int i = 0; i < stepSize; i++)
            {
				robot.MoveTo(direction);
            }
        }
	}
}