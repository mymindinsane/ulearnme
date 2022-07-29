namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
			MoveRight(robot,width);
			MoveDown(robot,height);
		}

		public static void MoveRight(Robot robot, int сount)
		{
			for (int i = 0; i < сount; i++)
				robot.MoveTo(Direction.Right);
				
		}

		public static void MoveDown(Robot robot, int сount)
		{
			for (int i = 0; i < сount; i++)
				robot.MoveTo(Direction.Down);
		}
				
				
		
	}   
	
	
	
}