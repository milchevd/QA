namespace E05
{
	public class T08
	{
		static void Main_(string[] args)
		{
			int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

			int pieces = width * length; // each piece is 1x1
										 // the number of pieces is the same as the area

			while(pieces >= 0)
			{
				String input = Console.ReadLine();
				if (input == "STOP")
					break; // cycle ends, we're good

				pieces -= int.Parse(input);
            }

			if (pieces >=0)
				Console.WriteLine($"{pieces} pieces are left.");
			else
				Console.WriteLine($"No more cake left! You need {-pieces} pieces more.");
        }
    }
}

