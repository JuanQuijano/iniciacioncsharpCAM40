using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
Console.Clear();
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("es-ES");

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;
// Config: si true, cualquier tecla no direccional finalizará el juego
bool exitOnNonDirectional = true;
// Config opcional: si true, habilita el aumento de velocidad cuando el jugador es (^-^)
bool enableSpeedBoost = true;

// Console position of the player
int playerX = 0;
int playerY = 0;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings (expanded with intermediate states)
string[] states = {"('-')", "(._.)", "(^-^)", "(o_o)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
int playerStateIndex = 0;
string player = states[playerStateIndex];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    // Check if the Terminal was resized before allowing the game to continue
    if (TerminalResized())
    {
        Console.Clear();
        Console.WriteLine("Console was resized. Program exiting.");
        shouldExit = true;
        break;
    }

    // If the player is in the (X_X) state, immobilize temporarily
    if (IsPlayerInDeadState())
    {
        FreezePlayer();
    }

    // Determine horizontal step based on current playerStateIndex.
    // Higher indices -> slower movement (simulate filling up). Base steps per state:
    // index 0: 1 (normal), index 1: 2, index 2 (happy): 3, index 3: 2, index 4: 0 (immobile handled separately)
    int[] stepsByState = new int[] { 1, 2, 3, 2, 1 };
    int horizontalStep = 1;
    if (enableSpeedBoost && playerStateIndex >= 0 && playerStateIndex < stepsByState.Length)
    {
        horizontalStep = stepsByState[playerStateIndex];
    }

    Move(exitOnNonDirectional, horizontalStep);
    // After moving, check if the player ate the food and update accordingly
    if (!shouldExit && PlayerAteFood())
    {
        ChangePlayer();
        ShowFood();
    }
}
Console.Clear();


// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Returns true if the player's position overlaps the current food position
bool PlayerAteFood()
{
    // Must be on the same Y row
    if (playerY != foodY) return false;

    int playerStart = playerX;
    int playerEnd = playerX + player.Length - 1;
    int foodStart = foodX;
    int foodEnd = foodX + foods[food].Length - 1;

    // Overlap check
    return !(playerEnd < foodStart || playerStart > foodEnd);
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer()
{
    // If special food ##### (index 2) was eaten, go to final state immediately
    if (food == 2)
    {
        playerStateIndex = states.Length - 1; // final (X_X)
    }
    else
    {
        // Otherwise advance one intermediate state (cap at final)
        playerStateIndex = Math.Min(playerStateIndex + 1, states.Length - 1);
    }

    player = states[playerStateIndex];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Temporarily stops the player from moving
void FreezePlayer() 
{
    // Temporarily stop movement and then reset to empty state
    System.Threading.Thread.Sleep(1000);
    playerStateIndex = 0;
    player = states[playerStateIndex];
}

// Returns true if the player's appearance is (X_X)
bool IsPlayerInDeadState()
{
    return player == "(X_X)";
}

// Returns true if the player's appearance is (^-^)
bool IsPlayerHappy()
{
    return player == "(^-^)";
}

// Reads directional input from the Console and moves the player
// If allowNonDirectionalExit is true, any key that is not a directional key
// (Up/Down/Left/Right) or Escape will cause the game to exit.
// horizontalStep controls how much X changes on left/right (default 1)
void Move(bool allowNonDirectionalExit = false, int horizontalStep = 1) 
{
    int lastX = playerX;
    int lastY = playerY;
    var keyInfo = Console.ReadKey(true);
    var key = keyInfo.Key;
    
    switch (key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
        case ConsoleKey.LeftArrow:  
            playerX -= horizontalStep; 
            break;
        case ConsoleKey.RightArrow: 
            playerX += horizontalStep; 
            break;
		case ConsoleKey.Escape:     
            shouldExit = true; 
            break;
        default:
            // If configured, allow any non-directional key to end the game
            if (allowNonDirectionalExit)
            {
                shouldExit = true;
            }
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}