namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			int stepsW = 1;
			int stepsH = 1;
			while(stepsH <height-2 || stepsW < width -2)
            {
				if (stepsW < width - 2)
                {
					robot.MoveTo(Direction.Right);
					stepsW++;
				}
					
				if (stepsH < height - 2)
                {
					robot.MoveTo(Direction.Down);
					stepsH++;
				}
					
            }
		}
	}
}