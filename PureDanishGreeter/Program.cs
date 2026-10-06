using System;

namespace PureDanishGreeter;

public class PureDanishGreeter
{
	public string Execute(string name, int time)
	{
		if (time is >= 6 and < 9)
		{
			return $"Godmorgen, {name}!";
		}

		if (time is >= 9 and < 12)
		{
			return $"God formiddag, {name}!";
		}

		if (time is >= 12 and < 18)
		{
			return $"God eftermiddag, {name}!";
		}

		if (time is >= 19 and < 24)
		{
			return $"God aften, {name}!";
		}

		if (time is >= 0 and < 5)
		{
			return $"Godnat, {name}!";
		}

		throw new ArgumentOutOfRangeException(nameof(time));
	}
}