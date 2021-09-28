using CardDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// This file should probably actually be in the Models folder, FYI

namespace CardDemo
{
	public class Poker
	{
		public static string GetHand(List<Card> cards)
		{
			// Put the algorithm here to determine the different hands
			// If no value, return null
			return "STRAIGHT";
		}
	}
}
