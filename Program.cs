string file = "ticketing.csv";
    string choice;
    do{
        //initial Menu
        Console.WriteLine("1) Preview records");
        Console.WriteLine("2) Add Ticket data");
        Console.WriteLine("Enter any other key to exit");
        // Reponses
        choice = Console.ReadLine();

        if(choice == "1")
        {
            if(File.Exists(file))
            {
               StreamReader sr = new StreamReader(file);
                        while (!sr.EndOfStream){
                            string line = sr.ReadLine();
                            // convert string to array
                            string[] arr = line.Split(',');
                            // display array data
                            Console.WriteLine("\n ID: {0} \n Summery: {1} \n Status: {2} \n Priority: {3} \n Submitter: {4} \n Assigned: {5} \n Watching: {6} \n -------------------------------------------------------------------------------------------------------------- \n", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]);
                        } 
            } 
            else{
                Console.WriteLine("file does not exits");
            }  
        }

        else if(choice == "2")
        {
            string exit = "run";
            StreamWriter sw = new StreamWriter(file);
            int UID = 0;
                do{
                    //Initial Questions and loop break
                Console.WriteLine(" Add a Ticket (Y/N)");
                string response = Console.ReadLine().ToUpper();
                if (response != "Y" || response != "YES"){ exit = "exit";}
                
                //creating UID
                UID += 1;

                // adding summery

                Console.WriteLine("Enter a Ticket Summery");
                string? summery = Console.ReadLine();

                //Ticket Status
                Console.WriteLine("Ticket Status");
                string? status = Console.ReadLine();

                //Ticket Priority
                Console.WriteLine("Rate Priority 1-10");
                string? priority = Console.ReadLine();

                //Ticket Submitter

                Console.WriteLine("Submitter Name");
                string? name = Console.ReadLine();

                // Assigned Worker
                Console.WriteLine("Assign a worker \n Zack  \n Jack \n Elijah");
                string? assigned = Console.ReadLine();
                

                // Assigned watcher
                Console.WriteLine("Assign a worker \n Jeff  \n Patrick \n Matthew");
                string? watcher = Console.ReadLine();

                sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", UID, summery, status, priority, name, assigned, watcher);

                }while(exit == "run");
                sw.Close();
        }
    }while(choice == "1" || choice == "2");
