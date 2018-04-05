/*
 * Created by SharpDevelop.
 * User: 0099398
 * Date: 4/5/2018
 * Time: 11:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hang_Man
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Welcome to United States Hangman!");
			string[] states = new string[50];
			states[0] = "alabama";
			states[1] = "alaska";
			states[2] = "arizona";
			states[3] = "arkansas";
			states[4] = "california";
			states[5] = "colorado";
			states[6] = "conneticut";
			states[7] = "delaware";
			states[8] = "florida";
			states[9] = "goergia";
			states[10] = "hawaii";
			states[11] = "idaho";
			states[12] = "illinois";
			states[13] = "indiana";
			states[14] = "iowa";
			states[15] = "kansas";
			states[16] = "kentucky";
			states[17] = "louisiana";
			states[18] = "maine";
			states[19] = "maryland";
			states[20] = "massachusetts";
			states[21] = "michigan";
			states[22] = "minnesota";
			states[23] = "mississippi";
			states[24] = "missouri";
			states[25] = "montana";
			states[26] = "nebraska";
			states[27] = "nevada";
			states[28] = "new hampshire";
			states[29] = "new jersey";
			states[30] = "new mexico";
			states[31] = "new york";
			states[32] = "north carolina";
			states[33] = "north dakota";
			states[34] = "ohio";
			states[35] = "oklahoma";
			states[36] = "oregon";
			states[37] = "pennsylvania";
			states[38] = "rhode island";
			states[39] = "south carolina";
			states[40] = "south dakota";
			states[41] = "tennessee";
			states[42] = "texas";
			states[43] = "utah";
			states[44] = "vermont";
			states[45] = "virginia";
			states[46] = "washington";
			states[47] = "west virginia";
			states[48] = "wisconsin";
			states[49] = "wyoming";
			
			Random rand = new Random();
			var wordChoice = rand.Next(0, 49);
			string mysteryWord = states[wordChoice];
			char[] guess = new char[mysteryWord.Length];
			Console.Write("Enter your guess: ");
			
			for (int x = 0; x < mysteryWord.Length; x++) {
				guess[x] = '*';
			}
			
			while (true) {
				char playerGuess = char.Parse(Console.ReadLine());
				for (int j = 0; j < mysteryWord.Length; j++) {
					if (playerGuess == mysteryWord[j]) {
						guess[j] = playerGuess;
					
					}
				
				}
				Console.WriteLine(guess);
			}
			
			
			Console.Write("Press any key to continue");
				Console.ReadKey(true);
			
			}
	}
}