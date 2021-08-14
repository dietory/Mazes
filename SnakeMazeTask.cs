namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int stepsH = 1;
			Direction direction = Direction.Right;
			while(stepsH <= height - 2)
            {
				MoveToNextSide(robot, direction, width - 3);
				if (stepsH >= height - 2) break;
				robot.MoveTo(Direction.Down);
				robot.MoveTo(Direction.Down);
				stepsH += 2;
				direction = direction == Direction.Right ? Direction.Left : Direction.Right;
			}
		}

		public static void MoveToNextSide(Robot robot, Direction direction, int steps)
        {
			for(int i = 1; i <= steps; i++)
            {
				robot.MoveTo(direction);
            }
        }
	}
}