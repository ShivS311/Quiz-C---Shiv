// Avg Calc
#nullable disable

// Welcome
Console.Clear();
Console.WriteLine("WELCOME TO THE DISTANCE CALCULATOR!");

// Main Loop
double scoreCounter = 0;

Console.Write("\n1. What is the most IMPORTANT piece in chess?: ");
string ques1 = Console.ReadLine().ToLower();;

// Q1
if (ques1 == "king") {
  Console.WriteLine("Q1 Answer: King");
  Console.WriteLine("Correct!");
  scoreCounter++;
} else {
  Console.WriteLine("Q1 Answer: King");
  Console.WriteLine("Incorrect!");
}

// Q2
Console.Write("\n2. What is the Most POWERFUL piece in chess?: ");
string ques2 = Console.ReadLine().ToLower();;

// Process Input
if (ques2 == "queen") {
  Console.WriteLine("Q2 Answer: Queen");
  Console.WriteLine("Correct!");
  scoreCounter++;
} else {
  Console.WriteLine("Q2 Answer: Queen");
  Console.WriteLine("Incorrect!");
}

// Q3
Console.Write("\n3. How many small squares are on a chess board?: ");
string ques3 = Console.ReadLine().ToLower();;

// Process Input
if (ques3 == "64") {
  Console.WriteLine("Q3 Answer: 64");
  Console.WriteLine("Correct!");
  scoreCounter++;
} else {
  Console.WriteLine("Q3 Answer: 64");
  Console.WriteLine("Incorrect!");
}

// Q4
Console.Write("\n4. Who is your Computing Science Teacher?: ");
string ques4 = Console.ReadLine().ToLower();

// Process Input
if (ques4 == "mr.veldkamp" || ques4 == "mr.v") {
  Console.WriteLine("Q4 Answer: Mr.VeldKamp or Mr.V");
  Console.WriteLine("Correct!");
  scoreCounter++;
} else {
  Console.WriteLine("Q4 Answer: Mr.VeldKamp or Mr.V");
  Console.WriteLine("Incorrect!");
}

double avg1 = ((scoreCounter / 4) * 100);

// OutPut
Console.WriteLine($"\nYour Results:");

Console.WriteLine($"Your Score is {scoreCounter}/4 ({avg1}%)");

if (scoreCounter == 4) {
  Console.WriteLine("\n100% YA!");
} else if (scoreCounter == 3) {
  Console.WriteLine("\nGoodJob!");
} else if (scoreCounter == 2) {
  Console.WriteLine("\n50% its okay u can do better!");
} else {
  Console.WriteLine("\nYou need to STUDY!");
}