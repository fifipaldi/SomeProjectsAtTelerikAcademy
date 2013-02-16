using System;
using System.Threading;


class JustAvoidTheFallingRocks
{
    static int dwarfSize = 1;

    static int firstRockPositionX = 0;
    static int firstRockPositionY = 0;
    static int secondRockPositionX = 0;
    static int secondRockPositionY = 0;
    static int thirdRockPositionX = 0;
    static int thirdRockPositionY = 0;
    static int fourthRockPositionX = 0;
    static int fourthRockPositionY = 0;
    static int fifthRockPositionX = 0;
    static int fifthRockPositionY = 0;
    static int sixthRockPositionX = 0;
    static int sixthRockPositionY = 0;
    static int seventhRockPositionX = 0;
    static int seventhRockPositionY = 0;
    static int eighthRockPositionX = 0;
    static int eighthRockPositionY = 0;
    static int ninthRockPositionX = 0;
    static int ninthRockPositionY = 0;
    static int tenthRockPositionX = 0;
    static int tenthRockPositionY = 0;
    static int eleventhRockPositionX = 0;
    static int eleventhRockPositionY = 0;
    static int twelfthRockPositionX = 0;
    static int twelfthRockPositionY = 0;
    static int thirteenthRockPositionX = 0;
    static int thirteenthRockPositionY = 0;
    static int fourteenthRockPositionX = 0;
    static int fourteenthRockPositionY = 0;
    static int fifteenthRockPositionX = 0;
    static int fifteenthRockPositionY = 0;


    static bool rockDirectionDown = true;

    static int dwarfPosition = 0;

    static int playerResult = 0;

    static void RemoveScrollBars()
    {
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 40;
    }

    static void DrawDwarf()
    {
        for (int x = dwarfPosition; x < dwarfPosition + dwarfSize; x++)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintAtPosition(x, Console.WindowHeight - 2, '(');
            PrintAtPosition(x + 1, Console.WindowHeight - 2, '0');
            PrintAtPosition(x + 2, Console.WindowHeight - 2, ')');

        }
    }

    static void PrintAtPosition(int x, int y, char symbol)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(symbol);
    }

    static void SetInitialPositions()
    {
        dwarfPosition = (Console.WindowWidth / 2) - 2;
        firstRockPositionX = Console.WindowWidth / 2;
        firstRockPositionY = 2;
        secondRockPositionX = Console.WindowWidth / 4;
        secondRockPositionY = 5;
        thirdRockPositionX = Console.WindowWidth / 2 + Console.WindowWidth / 4;
        thirdRockPositionY = 8;
        fourthRockPositionX = 1;
        fourthRockPositionY = 3;
        fifthRockPositionX = Console.WindowWidth - 2;
        fifthRockPositionY = 5;
        sixthRockPositionX = 3;
        sixthRockPositionY = 15;
        seventhRockPositionX = 7;
        seventhRockPositionY = 3;
        eighthRockPositionX = Console.WindowWidth / 4 + 6;
        eighthRockPositionY = 13;
        ninthRockPositionX = Console.WindowWidth / 4 + 1;
        ninthRockPositionY = 15;
        tenthRockPositionX = Console.WindowWidth / 2 + Console.WindowWidth / 4 + 2;
        tenthRockPositionY = 15;
        eleventhRockPositionX = Console.WindowWidth / 2;
        eleventhRockPositionY = 8;
        twelfthRockPositionX = Console.WindowWidth / 2 + 5;
        twelfthRockPositionY = 10;
        thirteenthRockPositionX = Console.WindowWidth - 4;
        thirteenthRockPositionY = 2;
        fourteenthRockPositionX = Console.WindowWidth / 4 + 5;
        fourteenthRockPositionY = 3;
        fifteenthRockPositionX = Console.WindowWidth / 2 + 6;
        fifteenthRockPositionY = 1;

    }

    static void MoveDwarfRight()
    {
        if (dwarfPosition < Console.WindowWidth - (dwarfSize + 2))
        {
            dwarfPosition++;
        }
    }

    static void MoveDwarfLeft()
    {
        if (dwarfPosition > 0)
        {
            dwarfPosition--;
        }
    }

    static void DrawFirstRock()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        PrintAtPosition(firstRockPositionX, firstRockPositionY, '@');
        PrintAtPosition(firstRockPositionX - 1, firstRockPositionY, '+');
        PrintAtPosition(firstRockPositionX - 2, firstRockPositionY, '+');
    }

    static void DrawSecondRock()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        PrintAtPosition(secondRockPositionX, secondRockPositionY, '*');
    }

    static void DrawThirdRock()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        PrintAtPosition(thirdRockPositionX, thirdRockPositionY, '%');
    }

    static void DrawFourthRock()
    {
        Console.ForegroundColor = ConsoleColor.White;
        PrintAtPosition(fourthRockPositionX, fourthRockPositionY, '&');
    }

    static void DrawFifthRock()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        PrintAtPosition(fifthRockPositionX, fifthRockPositionY, '&');
    }

    static void DrawSixthRock()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        PrintAtPosition(sixthRockPositionX, sixthRockPositionY, '@');
    }

    static void DrawSeventhRock()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        PrintAtPosition(seventhRockPositionX, seventhRockPositionY, '^');
        PrintAtPosition(seventhRockPositionX - 1, seventhRockPositionY, '#');
        PrintAtPosition(seventhRockPositionX - 2, seventhRockPositionY, '^');
    }

    static void DrawEighthRock()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        PrintAtPosition(eighthRockPositionX, eighthRockPositionY, '$');
        PrintAtPosition(eighthRockPositionX - 1, eighthRockPositionY, '$');
        PrintAtPosition(eighthRockPositionX - 2, eighthRockPositionY, '$');
    }

    static void DrawNinthhRock()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        PrintAtPosition(ninthRockPositionX, ninthRockPositionY, '!');

    }

    static void DrawTenthRock()
    {
        Console.ForegroundColor = ConsoleColor.White;
        PrintAtPosition(tenthRockPositionX, tenthRockPositionY, '^');
        PrintAtPosition(tenthRockPositionX - 1, tenthRockPositionY, '&');
        PrintAtPosition(tenthRockPositionX - 2, tenthRockPositionY, '^');
    }

    static void DrawEleventhRock()
    {
        Console.ForegroundColor = ConsoleColor.Gray;
        PrintAtPosition(eleventhRockPositionX, eleventhRockPositionY, '%');

    }

    static void DrawTwelfthRock()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        PrintAtPosition(twelfthRockPositionX, twelfthRockPositionY, '(');
        PrintAtPosition(twelfthRockPositionX - 1, twelfthRockPositionY, '=');
        PrintAtPosition(twelfthRockPositionX - 2, twelfthRockPositionY, ')');

    }

    static void DrawThirteenthRock()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        PrintAtPosition(thirteenthRockPositionX, thirteenthRockPositionY, '@');
        PrintAtPosition(thirteenthRockPositionX - 1, thirteenthRockPositionY, '-');
        PrintAtPosition(thirteenthRockPositionX - 2, thirteenthRockPositionY, '@');
    }

    static void DrawFourteenthRock()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        PrintAtPosition(fourteenthRockPositionX, fourteenthRockPositionY, '@');

    }

    static void DrawFifteenthRock()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        PrintAtPosition(fifteenthRockPositionX, fifteenthRockPositionY, '@');

    }

    static void PrintResult()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(Console.WindowWidth / 2 - 4, 0);
        Console.Write("Score: {0}", playerResult);
    }

    static void MoveFirstRock()
    {
        if (rockDirectionDown)
        {
            firstRockPositionY++;
        }
        if (firstRockPositionY >= Console.WindowHeight - 1)
        {
            SetFirstRockAtStartPosition();
            playerResult++;
        }
        if (firstRockPositionY >= Console.WindowHeight - 2)
        {
            if (firstRockPositionX >= dwarfPosition
                && firstRockPositionX <= dwarfPosition + dwarfSize + 1 || firstRockPositionX - 1 >= dwarfPosition
                && firstRockPositionX - 1 <= dwarfPosition + dwarfSize + 1 || firstRockPositionX - 2 >= dwarfPosition
                && firstRockPositionX - 2 <= dwarfPosition + dwarfSize + 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveSecondRock()
    {
        if (rockDirectionDown)
        {
            secondRockPositionY++;
        }
        if (secondRockPositionY >= Console.WindowHeight - 1)
        {
            SetSecondRockAtStartPosition();
            playerResult++;
        }
        if (secondRockPositionY >= Console.WindowHeight - 2)
        {
            if (secondRockPositionX >= dwarfPosition
                    && secondRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveThirdRock()
    {
        if (rockDirectionDown)
        {
            thirdRockPositionY++;
        }
        if (thirdRockPositionY >= Console.WindowHeight - 1)
        {
            SetThirdRockAtStartPosition();
            playerResult++;
        }
        if (thirdRockPositionY >= Console.WindowHeight - 2)
        {
            if (thirdRockPositionX >= dwarfPosition
                    && thirdRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveFourthRock()
    {
        if (rockDirectionDown)
        {
            fourthRockPositionY++;
        }
        if (fourthRockPositionY >= Console.WindowHeight - 1)
        {
            SetFourthRockAtStartPosition();
            playerResult++;
        }
        if (fourthRockPositionY >= Console.WindowHeight - 2)
        {
            if (fourthRockPositionX >= dwarfPosition
                    && fourthRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveFifthRock()
    {
        if (rockDirectionDown)
        {
            fifthRockPositionY++;
        }
        if (fifthRockPositionY >= Console.WindowHeight - 1)
        {
            SetFifthRockAtStartPosition();
            playerResult++;
        }
        if (fifthRockPositionY >= Console.WindowHeight - 2)
        {
            if (fifthRockPositionX >= dwarfPosition
                    && fifthRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveSixthRock()
    {
        if (rockDirectionDown)
        {
            sixthRockPositionY++;
        }
        if (sixthRockPositionY >= Console.WindowHeight - 1)
        {
            SetSixthRockAtStartPosition();
            playerResult++;
        }
        if (sixthRockPositionY >= Console.WindowHeight - 2)
        {
            if (sixthRockPositionX >= dwarfPosition
                    && sixthRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveSeventhRock()
    {
        if (rockDirectionDown)
        {
            seventhRockPositionY++;
        }
        if (seventhRockPositionY >= Console.WindowHeight - 1)
        {
            SetSeventhRockAtStartPosition();
            playerResult++;
        }
        if (seventhRockPositionY >= Console.WindowHeight - 2)
        {
            if (seventhRockPositionX >= dwarfPosition
                    && seventhRockPositionX < dwarfPosition + dwarfSize + 1 || seventhRockPositionX - 1 >= dwarfPosition
                    && seventhRockPositionX - 1 < dwarfPosition + dwarfSize + 1 || seventhRockPositionX - 2 >= dwarfPosition
                    && seventhRockPositionX - 2 < dwarfPosition + dwarfSize + 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveEighthRock()
    {
        if (rockDirectionDown)
        {
            eighthRockPositionY++;
        }
        if (eighthRockPositionY >= Console.WindowHeight - 1)
        {
            SetEighthRockAtStartPosition();
            playerResult++;
        }
        if (eighthRockPositionY >= Console.WindowHeight - 2)
        {
            if (eighthRockPositionX >= dwarfPosition
                && eighthRockPositionX <= dwarfPosition + dwarfSize + 1 || eighthRockPositionX - 1 >= dwarfPosition
                && eighthRockPositionX - 1 <= dwarfPosition + dwarfSize + 1 || eighthRockPositionX - 2 >= dwarfPosition
                && eighthRockPositionX - 2 <= dwarfPosition + dwarfSize + 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveNinthRock()
    {
        if (rockDirectionDown)
        {
            ninthRockPositionY++;
        }
        if (ninthRockPositionY >= Console.WindowHeight - 1)
        {
            SetNinthRockAtStartPosition();
            playerResult++;
        }
        if (ninthRockPositionY >= Console.WindowHeight - 2)
        {
            if (ninthRockPositionX >= dwarfPosition
                    && ninthRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveTenthRock()
    {
        if (rockDirectionDown)
        {
            tenthRockPositionY++;
        }
        if (tenthRockPositionY >= Console.WindowHeight - 1)
        {
            SetTenthRockAtStartPosition();
            playerResult++;
        }
        if (tenthRockPositionY >= Console.WindowHeight - 2)
        {
            if (tenthRockPositionX >= dwarfPosition
                    && tenthRockPositionX < dwarfPosition + dwarfSize + 1 || tenthRockPositionX - 1 >= dwarfPosition
                && tenthRockPositionX - 1 <= dwarfPosition + dwarfSize + 1 || tenthRockPositionX - 2 >= dwarfPosition
                && tenthRockPositionX - 2 <= dwarfPosition + dwarfSize + 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveEleventhRock()
    {
        if (rockDirectionDown)
        {
            eleventhRockPositionY++;
        }
        if (eleventhRockPositionY >= Console.WindowHeight - 1)
        {
            SetEleventhRockAtStartPosition();
            playerResult++;
        }
        if (eleventhRockPositionY >= Console.WindowHeight - 2)
        {
            if (eleventhRockPositionX >= dwarfPosition
                    && eleventhRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveTwelfthRock()
    {
        if (rockDirectionDown)
        {
            twelfthRockPositionY++;
        }
        if (twelfthRockPositionY >= Console.WindowHeight - 1)
        {
            SetTwelfthRockAtStartPosition();
            playerResult++;
        }
        if (twelfthRockPositionY >= Console.WindowHeight - 2)
        {
            if (twelfthRockPositionX >= dwarfPosition
                && twelfthRockPositionX <= dwarfPosition + dwarfSize + 1 || twelfthRockPositionX - 1 >= dwarfPosition
                && twelfthRockPositionX - 1 <= dwarfPosition + dwarfSize + 1 || twelfthRockPositionX - 2 >= dwarfPosition
                && twelfthRockPositionX - 2 <= dwarfPosition + dwarfSize + 1)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveThirteenthRock()
    {
        if (rockDirectionDown)
        {
            thirteenthRockPositionY++;
        }
        if (thirteenthRockPositionY >= Console.WindowHeight - 1)
        {
            SetThirteenthRockAtStartPosition();
            playerResult++;
        }
        if (thirteenthRockPositionY >= Console.WindowHeight - 2)
        {
            if (thirteenthRockPositionX >= dwarfPosition
                    && thirteenthRockPositionX < dwarfPosition + dwarfSize + 2 || thirteenthRockPositionX - 1 >= dwarfPosition
                    && thirteenthRockPositionX - 1 < dwarfPosition + dwarfSize + 2 || thirteenthRockPositionX - 2 >= dwarfPosition
                    && thirteenthRockPositionX - 2 < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveFourteenthRock()
    {
        if (rockDirectionDown)
        {
            fourteenthRockPositionY++;
        }
        if (fourteenthRockPositionY >= Console.WindowHeight - 1)
        {
            SetFourteenthRockAtStartPosition();
            playerResult++;
        }
        if (fourteenthRockPositionY >= Console.WindowHeight - 2)
        {
            if (fourteenthRockPositionX >= dwarfPosition
                    && fourteenthRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void MoveFifteenthRock()
    {
        if (rockDirectionDown)
        {
            fifteenthRockPositionY++;
        }
        if (fifteenthRockPositionY >= Console.WindowHeight - 1)
        {
            SetFifteenthRockAtStartPosition();
            playerResult++;
        }
        if (fifteenthRockPositionY >= Console.WindowHeight - 2)
        {
            if (fifteenthRockPositionX >= dwarfPosition
                    && fifteenthRockPositionX < dwarfPosition + dwarfSize + 2)
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 - 5, Console.WindowHeight / 2);
                Console.WriteLine("GAME OVER !!!");
                Console.ReadKey();
                SetInitialPositions();
                playerResult = 0;
            }
        }
    }

    static void SetFirstRockAtStartPosition()
    {
        firstRockPositionX = Console.WindowWidth / 2;
        firstRockPositionY = 1;
    }

    static void SetSecondRockAtStartPosition()
    {
        secondRockPositionX = Console.WindowWidth / 4;
        secondRockPositionY = 5;
    }

    static void SetThirdRockAtStartPosition()
    {
        thirdRockPositionX = Console.WindowWidth / 2 + Console.WindowWidth / 4;
        thirdRockPositionY = 2;
    }

    static void SetFourthRockAtStartPosition()
    {
        fourthRockPositionX = 1;
        fourthRockPositionY = 3;
    }

    static void SetFifthRockAtStartPosition()
    {
        fifthRockPositionX = Console.WindowWidth - 2;
        fifthRockPositionY = 5;
    }

    static void SetSixthRockAtStartPosition()
    {
        sixthRockPositionX = 3;
        sixthRockPositionY = 4;
    }

    static void SetSeventhRockAtStartPosition()
    {
        seventhRockPositionX = 7;
        seventhRockPositionY = 3;
    }

    static void SetEighthRockAtStartPosition()
    {
        eighthRockPositionX = Console.WindowWidth / 4 + 6;
        eighthRockPositionY = 2;
    }

    static void SetNinthRockAtStartPosition()
    {
        ninthRockPositionX = Console.WindowWidth / 4 + 1;
        ninthRockPositionY = 1;
    }

    static void SetTenthRockAtStartPosition()
    {
        tenthRockPositionX = Console.WindowWidth / 2 + Console.WindowWidth / 4 + 2;
        tenthRockPositionY = 3;
    }

    static void SetEleventhRockAtStartPosition()
    {
        eleventhRockPositionX = Console.WindowWidth / 2;
        eleventhRockPositionY = 5;
    }

    static void SetTwelfthRockAtStartPosition()
    {
        twelfthRockPositionX = Console.WindowWidth / 2 + 5;
        twelfthRockPositionY = 3;

    }

    static void SetThirteenthRockAtStartPosition()
    {
        thirteenthRockPositionX = Console.WindowWidth - 4;
        thirteenthRockPositionY = 2;

    }

    static void SetFourteenthRockAtStartPosition()
    {
        fourteenthRockPositionX = Console.WindowWidth / 4 + 5;
        fourteenthRockPositionY = 1;
    }

    static void SetFifteenthRockAtStartPosition()
    {
        fifteenthRockPositionX = Console.WindowWidth / 2 + 6;
        fifteenthRockPositionY = 1;
    }

    static void Main()
    {
        Console.Title = "Just Avoid The Falling Rocks Video Game";
        RemoveScrollBars();
        SetInitialPositions();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    MoveDwarfLeft();
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    MoveDwarfRight();
                }
            }
            MoveFirstRock();
            MoveSecondRock();
            MoveThirdRock();
            MoveFourthRock();
            MoveFifthRock();
            MoveSixthRock();
            MoveSeventhRock();
            MoveEighthRock();
            MoveNinthRock();
            MoveTenthRock();
            MoveEleventhRock();
            MoveTwelfthRock();
            MoveThirteenthRock();
            MoveFourteenthRock();
            MoveFifteenthRock();

            Console.Clear();

            DrawDwarf();

            DrawFirstRock();
            DrawSecondRock();
            DrawThirdRock();
            DrawFourthRock();
            DrawFifthRock();
            DrawSixthRock();
            DrawSeventhRock();
            DrawEighthRock();
            DrawNinthhRock();
            DrawTenthRock();
            DrawEleventhRock();
            DrawTwelfthRock();
            DrawThirteenthRock();
            DrawFourteenthRock();
            DrawFifteenthRock();

            PrintResult();

            Thread.Sleep(100);

        }
    }
}

