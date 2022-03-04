bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("What block did a grassblock give you?");
    Console.WriteLine("");
    Console.WriteLine("All possibilities are: 'blastfurnace', 'crimsonfence', 'lightgreyterracotta', 'dirt', 'acacianfence'.");
    Console.WriteLine("");
    Console.WriteLine("Remember to write all the words together and in lowercase for it to work");

    string block = Console.ReadLine();

    #region strings
    string diamond = "";
    string enchant = "";
    string gApple = "";
    string endcity = "";
    string totem = "";
    string pearls = "";
    string potions = "";
    string iron = "";
    string proChestDrops = "";
    #endregion

    #region if-statements
    if (block == "blastfurnace")
    {
        #region strings
        diamond = "";
        enchant = "";
        gApple = "";
        endcity = "daisy";
        totem = "";
        pearls = "";
        potions = "";
        iron = "";
        proChestDrops = "";
        #endregion

        PrintInfo();
    }
    else if (block == "crimsonfence")
    {
        #region strings
        diamond = "";
        enchant = "";
        gApple = "Seagrass";
        endcity = "";
        totem = "";
        pearls = "";
        potions = "";
        iron = "";
        proChestDrops = "Diorite and yellow flowers --> wooden button";
        #endregion

        PrintInfo();
    }
    else if (block == "lightgreyterracotta")
    {
        #region strings
        diamond = "Pine leaves";
        enchant = "";
        gApple = "";
        endcity = "";
        totem = "";
        pearls = "";
        potions = "";
        iron = "";
        proChestDrops = "";
        #endregion

        PrintInfo();
    }
    else if (block == "dirt")
    {
        #region strings
        diamond = "";
        enchant = "";
        gApple = "";
        endcity = "kelp --> light grey wool";
        totem = "";
        pearls = "";
        potions = "";
        iron = "";
        proChestDrops = "";
        #endregion

        PrintInfo();
    }
    else if (block == "acacianfence")
    {
        #region strings
        diamond = "dirtpath";
        enchant = "";
        gApple = "";
        endcity = "";
        totem = "";
        pearls = "";
        potions = "";
        iron = "red mushroom blocks";
        proChestDrops = "";
        #endregion

        PrintInfo();
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("There doesn't seem to be any data for this block. Please try again!");
        Console.WriteLine("");

        Exit();
    }
    #endregion

    void PrintInfo()
    {
        Console.WriteLine("");
        #region PrintInfo if-statements
        if (diamond != "") Console.WriteLine($"You get diamonds by breaking {diamond}");
        if (enchant != "") Console.WriteLine($"You get enchant items by breaking {enchant}");
        if (gApple != "") Console.WriteLine($"You get golden apples by breaking {gApple}");
        if (endcity != "") Console.WriteLine($"You get endcity by breaking {endcity}");
        if (totem != "") Console.WriteLine($"You get totems by breaking {totem}");
        if (pearls != "") Console.WriteLine($"You get pearls by breaking {pearls}");
        if (potions != "") Console.WriteLine($"You get potions by breaking {potions}");
        if (iron != "") Console.WriteLine($"You get iron by breaking {iron}");
        if (proChestDrops != "") Console.WriteLine($"You get chest drops by breaking {proChestDrops}");
        #endregion

        #region PrintInfo string reset
        diamond = "";
        enchant = "";
        gApple = "";
        endcity = "";
        totem = "";
        pearls = "";
        potions = "";
        iron = "";
        proChestDrops = "";
        #endregion

        Exit();
    }

    void Exit()
    {
        Console.WriteLine("Write 'exit' to exit the application");
        string exit = Console.ReadLine();

        if (exit == "exit")
        {
            isRunning = false;
        }
    }
}
