string animal = Console.ReadLine().ToLower(); 
        
        string animalType;
        switch (animal)
        {
            case "dog":
                animalType = "mammal";
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                animalType = "reptile";
                break;
            default:
                animalType = "unknown";
                break;
        }

        Console.WriteLine(animalType);
    

