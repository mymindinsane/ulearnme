namespace Mazes
{
	public static class SnakeMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			MoveRight(robot,width);
			MoveDown(robot,height);
			MoveLeft(robot,width);
			if (!robot.Finished)
			{
				MoveDown(robot,height);
				MoveOut(robot,width,height);
			}
		}

		public static void MoveRight(Robot robot, int сount)
		{
			for (int i = 0; i < сount-3; i++)
				robot.MoveTo(Direction.Right);
				
		}

		public static void MoveDown(Robot robot, int сount)
		{
			for (int i = 0; i <2; i++)
				robot.MoveTo(Direction.Down);
		}

		public static void MoveLeft(Robot robot, int count)
		{
			for (int i=0 ;i < count-3;i++)
				robot.MoveTo(Direction.Left);
		}
	}
}