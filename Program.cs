using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SurvivorSimulator
{
    class player
    {
        public string name;
        public bool gender; //false = male, true = female
        public int team;
        public int confidence;
        public int athleticism;
        public int endurance;
        public int survivability;
        public int trickiness;
        public int puzzlesolving;
        public int vote;
        public player target;
        public bool immune;
        public int rank;
        public bool step1 = true;
        public bool step2 = true;
    }
    static class Program
    {
        static List<player> players1 = new List<player> { };
        static List<player> players2 = new List<player> { };
        static List<String> malenames = new List<string> 
        {
            "Liam",
            "Noah",
            "William",
            "James",
            "Logan",
            "Benjamin",
            "Mason",
            "Arvis",
            "Brammimond",
            "Seliph",
            "Elijah",
            "Leif",
            "Oliver",
            "Jacob",
            "Lucas",
            "Jon",
            "Alexander",
            "Julius",
            "Ethan",
            "Daniel",
            "Matthew",
            "Henry",
            "Joseph",
            "Jackson",
            "Samuel",
            "Sebastian",
            "David",
            "Carter",
            "Wyatt",
            "Jayden",
            "John",
            "Owen",
            "Ike",
            "Marth",
            "Rolf",
            "Boyd",
            "Oscar",
            "Alm",
            "Eliwood",
            "Hector",
            "Rhys",
            "Sain",
            "Kent",
            "Will",
            "Dorcas",
            "Rath",
            "Erk",
            "Bartre",
            "Wallace",
            "Lowen",
            "Marcus",
            "Rath",
            "Legault",
            "Jaffar",
            "Harken",
            "Karel",
            "Renault",
            "Athos",
            "Guy",
            "Jacques",
            "Percival",
            "Tobin",
            "Gray",
            "Clive",
            "Python",
            "Zeke",
            "Camus",
            "Brocolli Rob",
            "Conrad",
            "Frederick",
            "Donnel",
            "Owain",
            "Gerome",
            "Sigurd",
            "Lex",
            "Quan",
            "Lewyn",
            "Finn",
            "Oifey",
            "Arion",
            "Lester",
            "Dermont",
            "Arthur",
            "Ares",
            "Zeus",
            "Ephron",
            "Ahron",
            "Cato",
            "Dagon",
            "Cain",
            "Abel",
            "Jeigan",
            "Shinon",
            "Gatrie",
            "Soren",
            "Mordecai",
            "Ranulf",
            "Tibarn",
            "Naesala",
            "Giffca",
            "Greil",
            "Zelgius",
            "Ashnard",
            "Nergal",
            "Ephraim",
            "Gareth",
            "Sephiran",
            "Nasir",
            "Devdan",
            "Danved",
            "Kieran",
            "Zihark"
        };
        static List<String> femalenames = new List<string> 
        {
            "Emma",
            "Olivia",
            "Ava",
            "Isabella",
            "Sophia",
            "Mia",
            "Charlotte",
            "Amelia",
            "Evelyn",
            "Harper",
            "Elizabeth",
            "Sofia",
            "Aria",
            "Victoria",
            "Scarlett",
            "Grace",
            "Chloe",
            "Penelope",
            "Layla",
            "Lillian",
            "Mila",
            "Addison",
            "Luna",
            "Brooklyn",
            "Eleanor",
            "Stella",
            "Hazel",
            "Ellie",
            "Paisley",
            "Audrey",
            "Skylar",
            "Violet",
            "Claire",
            "Bella",
            "Aurora",
            "Lucy",
            "Anna",
            "Samantha",
            "Caroline",
            "Kennedy",
            "Maya",
            "Sarah",
            "Alexa",
            "Ariana",
            "Florina",
            "Fiora",
            "Farina",
            "Isadora",
            "Vaida",
            "Karla",
            "Nino",
            "Leila",
            "Clair",
            "Faye",
            "Mae",
            "Palla",
            "Catria",
            "Est",
            "Lissa",
            "Cordelia",
            "Cherche",
            "Sumia",
            "Erika",
            "Severa",
            "Cynthia",
            "Deirdre",
            "Julia",
            "Tailtui",
            "Lene",
            "Ethlyn",
            "Altena",
            "Titania",
            "Mia",
            "Ilyana",
            "Mist",
            "Marcia",
            "Lethe",
            "Nephenee",
            "Jill",
            "Astra",
            "Tanith",
            "Lucia",
            "Elincia",
            "Ena",
            "Lyn",
            "Petrine",
            "Elena",
            "Eirika",
            "Vanessa",
            "Lute",
            "Neimi",
            "Natasha",
            "Marissa",
            "Tethys",
            "Ariana",
            "Naomi",
            "Sadie",
            "Eva",
            "Emilia",
            "Ruby"
        };
        // players are given a random number of 1-100 in each stat
        static void create_characters(int x, bool team)
        {
            int team1 = 0;
            Random rnd = new Random();
            for(int z = 0; z < x; z++)
            {
                if (team)
                {
                    player addition = new player { };
                    addition.team = 0;
                    //male name
                    if (team1 < x / 2)
                    {
                        addition.name = malenames[rnd.Next(malenames.Count)];
                        malenames.Remove(addition.name);
                        addition.gender = false;
                        team1++;
                    }
                    else
                    {
                        addition.name = femalenames[rnd.Next(femalenames.Count)];
                        femalenames.Remove(addition.name);
                        addition.gender = true;
                        team1++;
                    }
                    addition.confidence = 0;
                    addition.athleticism = rnd.Next(101);
                    addition.endurance = rnd.Next(101);
                    addition.survivability = rnd.Next(101);
                    addition.trickiness = rnd.Next(101);
                    addition.puzzlesolving = rnd.Next(101);
                    addition.confidence = rnd.Next(101);
                    addition.target = null;
                    players1.Add(addition);
                    Console.WriteLine("Added {0} to team {1}", addition.name, addition.team);
                }
                else 
                {
                    player addition = new player { };
                    addition.team = 1;
                    //female name
                    if(team1 < x / 2)
                    {
                        addition.name = femalenames[rnd.Next(femalenames.Count)];
                        femalenames.Remove(addition.name);
                        addition.gender = true;
                        team1++;
                    }
                    else
                    {
                        addition.name = malenames[rnd.Next(malenames.Count)];
                        malenames.Remove(addition.name);
                        addition.gender = false;
                        team1++;
                    }
                    addition.confidence = 0;
                    addition.athleticism = rnd.Next(101);
                    addition.endurance = rnd.Next(101);
                    addition.survivability = rnd.Next(101);
                    addition.trickiness = rnd.Next(101);
                    addition.puzzlesolving = rnd.Next(101);
                    addition.confidence = rnd.Next(101);
                    addition.target = null;
                    players2.Add(addition);
                    Console.WriteLine("Added {0} to team {1}", addition.name, addition.team);
                }
            }
        }
        static int team_challenge()
        {
            int winner = Math.Min(players1.Count, players2.Count);
            List<player> team1 = getcompetitors(0, winner);
            List<player> team2 = getcompetitors(1, winner);
            int team1power = 0;
            foreach(player dude in team1)
            {
                team1power += dude.athleticism + dude.endurance + dude.puzzlesolving;
            }
            int team2power = 0;
            foreach (player dude in team2)
            {
                team2power += dude.athleticism + dude.endurance + dude.puzzlesolving;
            }
            Random rnd = new Random();
            if (rnd.Next(team1power + team2power) <= team1power) winner = 0;
            else winner = 1;

            return winner;
        }
        static player eviction(int team)
        {
            Random rnd = new Random();
            if(team == 0)
            {
                player expend = players1[0];
                foreach(player guy in players1)
                {
                    if (guy.confidence < 50)
                    {
                        guy.target = getworstcompetitor(players1, guy);
                    }
                    else
                    {
                        for (bool x = true; x;)
                        {
                            guy.target = players1[rnd.Next(players1.Count)];
                            if (guy.target != guy) x = false;
                        }
                    }
                }
                for(int x = 0; x < 3; x++)
                {
                    foreach(player guy in players1)
                    {
                        foreach (player dude in players1)
                        {
                            if (guy.target == dude || guy == dude || guy.target == dude.target) continue;
                            else if (rnd.Next(guy.trickiness + dude.confidence) < guy.trickiness) 
                            {
                                Console.WriteLine("{0} convinced {1} to vote for {2}", guy.name, dude.name, guy.target.name);
                                Console.ReadLine();
                                dude.confidence += 2;
                                guy.confidence += 3;
                                dude.target = guy.target; 
                            }
                        }
                    }
                }
                return tribal(players1);
            }
            else
            {
                player expend = players2[0];
                foreach (player guy in players2)
                {
                    if (guy.confidence < 50) guy.target = getworstcompetitor(players2, guy);
                    else
                    {
                        for (bool x = true; x;)
                        {
                            guy.target = players2[rnd.Next(players2.Count)];
                            if (guy.target != guy) x = false;
                        }
                    }
                }
                for (int x = 0; x < 3; x++)
                {
                    foreach (player guy in players2)
                    {
                        foreach (player dude in players2)
                        {
                            if (guy.target == dude || guy == dude || guy.target == dude.target) continue;
                            else if (rnd.Next(guy.trickiness + dude.confidence) < guy.trickiness)
                            {
                                Console.WriteLine("{0} convinced {1} to vote for {2}", guy.name, dude.name, guy.target.name);
                                Console.ReadLine();
                                dude.confidence += 2;
                                guy.confidence += 3;
                                dude.target = guy.target;
                            }
                        }
                    }
                }

                return tribal(players2);
            }
        }
        static player tribal(List<player> guys)
        {
            Console.WriteLine("Time for Tribal");
            Console.ReadLine();
            foreach (player dude in guys)
            {
                if (dude.confidence >= 100) Console.WriteLine("{0} says: I know exactly what is going to happen here tonight", dude.name);
                else if (dude.confidence >= 65) Console.WriteLine("{0} says: I am pretty confident tonight is goint to be a good night", dude.name);
                else if (dude.confidence >= 35) Console.WriteLine("{0} says: We will have to see how the night goes", dude.name);
                else Console.WriteLine("{0} says: I am very scared about how tonight will go", dude.name);
                Console.ReadLine();
            }
            foreach(player dude in guys)
            {
                foreach(player person in guys)
                {
                    if (dude.target == person)
                    {
                        Console.WriteLine("{0}, Voted for {1}", dude.name, person.name);
                        Console.ReadLine();
                        person.vote += 1;
                        break;
                    }
                }
            }
            player gone;
            int highest = 0;
            foreach (player dude in guys)
            {
                if (dude.vote > highest) highest = dude.vote;
            }
            List<player> choppingblock = new List<player> { };
            foreach (player dude in guys)
            {
                if (dude.vote >= highest) choppingblock.Add(dude);
            }
            Random rnd = new Random();
            if (choppingblock.Count > 1) 
            {
                Console.Write("Fire-making contest between: ");
                foreach (player dude in choppingblock) Console.Write("{0}, ", dude.name);
                Console.WriteLine();
                gone = choppingblock[rnd.Next(choppingblock.Count)];
            }
            else gone = choppingblock[0];
            Console.WriteLine("{0} Has been evicted with {1} votes", gone.name, gone.vote);
            foreach(player dude in guys)
            {
                dude.confidence = rnd.Next(25, 101);
                dude.confidence -= dude.vote * 4;
                dude.vote = 0;
            }
            using (StreamWriter sw = File.AppendText(String.Concat(Directory.GetCurrentDirectory(), "\\Players.txt")))
            {
                sw.WriteLine("{0} has been voted out", gone.name);
            }
            return gone;
        }
        static List<player> getcompetitors(int team, int num)
        {
            Random rnd = new Random();
            List<player> people = new List<player> { };
            if (team == 0)
            {
                for(int x = 0; x < num;)
                {
                    player expend = players1[rnd.Next(players1.Count)];
                    if (people.Contains(expend)) continue;
                    Console.WriteLine("{0} will play for Team {1}", expend.name, expend.team);
                    people.Add(expend);
                    x++;
                }
            }
            else
            {
                for (int x = 0; x < num;)
                {
                    player expend = players2[rnd.Next(players2.Count)];
                    if (people.Contains(expend)) continue;
                    Console.WriteLine("{0} will play for Team {1}", expend.name, expend.team);
                    people.Add(expend);
                    x++;
                }
            }

            return people;
        }
        static player getbestcompetitor(List<player> guys, player dude)
        {
            player mystery = dude;
            if (guys[0] == dude) mystery = guys[1];
            else mystery = guys[0];
            foreach (player person in guys)
            {
                if (person == dude || person == mystery || person.immune) continue;
                if ((mystery.athleticism + mystery.endurance + mystery.puzzlesolving + mystery.survivability + mystery.rank) <
                    (person.athleticism + person.endurance + person.puzzlesolving + person.survivability + person.rank)) mystery = person;
            }
            for (bool x = true; x;)
            {
                if(mystery == dude || mystery.immune)
                {
                    Random rnd = new Random();
                    mystery = players1[rnd.Next(players1.Count)];
                    continue;
                }
                x = false;
            }
            return mystery;
        }
        static player getworstcompetitor(List<player> guys, player dude)
        {
            player mystery = dude;
            if (guys[0] == dude) mystery = guys[1];
            else mystery = guys[0];
            foreach (player person in guys)
            {
                if (person == dude || person == mystery || person.immune) continue;
                if ((mystery.athleticism + mystery.endurance + mystery.puzzlesolving + mystery.survivability) > (person.athleticism + person.endurance + person.puzzlesolving + person.survivability)) mystery = person;
            }
            return mystery;
        }
        static player individualcompetition(List<player> guys, int type)
        {
            if (type == 0) return endurancecomp(guys);
            else if (type == 1) return athleticcomp(guys);
            else return puzzlecomp(guys);
        }
        static player endurancecomp(List<player> guys)
        {
            Console.WriteLine("Time for an endurance competition");
            Console.ReadLine();
            List<player> remain = new List<player> { };
            remain.AddRange(guys);
            Random rnd = new Random();
            for(int x = 0; x < 10;)
            {
                foreach(player dude in guys)
                {
                    if(remain.Contains(dude))
                    {
                        if (remain.Count == 1)
                        {
                            Console.WriteLine("{0} has won immunity", dude.name);
                            dude.immune = true;
                            dude.rank += 5;
                            using (StreamWriter sw = File.AppendText(String.Concat(Directory.GetCurrentDirectory(), "\\Players.txt"))) sw.WriteLine("{0} Won an endurance competition", dude.name);
                            return dude;
                        }
                        if (rnd.Next(50) >= dude.endurance) 
                        {
                            Console.WriteLine("{0} has lost", dude.name);
                            remain.Remove(dude);
                        }
                    }
                }
            }
            for(bool x = true; x;)
            {
                foreach(player dude in guys)
                {
                    if(remain.Contains(dude))
                    {
                        if (remain.Count == 1)
                        {
                            Console.WriteLine("{0} has won immunity", dude.name);
                            dude.immune = true;
                            dude.rank += 5;
                            return dude;
                        }
                        if (rnd.Next(101) > dude.endurance) 
                        {
                            Console.WriteLine("{0} has lost", dude.name);
                            remain.Remove(dude); 
                        }
                    }
                }
            }
            return null;
        }
        static player puzzlecomp(List<player> guys)
        {
            Console.WriteLine("Time for a puzzle");
            Console.ReadLine();
            Random rnd = new Random();
            for(bool x = true; x;)
            {
                foreach(player dude in guys)
                {
                    if(dude.step1)
                    {
                        if (rnd.Next(50) <= dude.puzzlesolving) 
                        {
                            Console.WriteLine("{0} has completed the first part", dude.name);
                            dude.rank += 1;
                            dude.step1 = false;
                        }
                    }
                    else if(dude.step2)
                    {
                        if (rnd.Next(200) <= dude.puzzlesolving)
                        {
                            Console.WriteLine("{0} has completed the second part", dude.name);
                            dude.rank += 1;
                            dude.step2 = false;
                        }
                    }
                    else
                    {
                        if(rnd.Next(400) <= dude.puzzlesolving)
                        {
                            Console.WriteLine("{0} has won immunity", dude.name);
                            dude.immune = true;
                            dude.rank += 3;
                            foreach(player person in guys)
                            {
                                person.step1 = true;
                                person.step2 = true;
                            }
                            using (StreamWriter sw = File.AppendText(String.Concat(Directory.GetCurrentDirectory(), "\\Players.txt"))) sw.WriteLine("{0} Won an puzzle competition", dude.name);
                            return dude;
                        }
                    }
                }
            }
            return null;
        }
        static player athleticcomp(List<player> guys)
        {
            Console.WriteLine("Time for an athletic challenge");
            Console.ReadLine();
            Random rnd = new Random();
            for (bool x = true; x;)
            {
                foreach (player dude in guys)
                {
                    if (dude.step1)
                    {
                        if (rnd.Next(50) <= dude.athleticism)
                        {
                            Console.WriteLine("{0} has completed the first part", dude.name);
                            dude.rank += 1;
                            dude.step1 = false;
                        }
                    }
                    else if (dude.step2)
                    {
                        if (rnd.Next(200) <= dude.athleticism)
                        {
                            Console.WriteLine("{0} has completed the second part", dude.name);
                            dude.rank += 1;
                            dude.step2 = false;
                        }
                    }
                    else
                    {
                        if (rnd.Next(400) <= dude.athleticism)
                        {
                            Console.WriteLine("{0} has won immunity", dude.name);
                            dude.rank += 2;
                            dude.immune = true;
                            foreach (player person in guys)
                            {
                                person.step1 = true;
                                person.step2 = true;
                            }
                            using (StreamWriter sw = File.AppendText(String.Concat(Directory.GetCurrentDirectory(), "\\Players.txt"))) sw.WriteLine("{0} Won an athletic competition", dude.name);
                            return dude;
                        }
                    }
                }
            }
            return null;
        }
        static void mergedcamp()
        {
            Random rnd = new Random();
            player expend = players1[0];
            foreach (player guy in players1)
            {
                if (guy.confidence < 50)
                {
                    guy.target = getbestcompetitor(players1, guy);
                }
                else
                {
                    for (bool x = true; x;)
                    {
                        guy.target = players1[rnd.Next(players1.Count)];
                        if (guy.target != guy && !guy.target.immune) x = false;
                    }
                }
            }
            for (int x = 0; x < 3; x++)
            {
                foreach (player guy in players1)
                {
                    foreach (player dude in players1)
                    {
                        if (guy.target == dude || guy == dude || guy.target == dude.target) continue;
                        else if (rnd.Next(guy.trickiness + dude.confidence) < guy.trickiness)
                        {
                            Console.WriteLine("{0} convinced {1} to vote for {2}", guy.name, dude.name, guy.target.name);
                            Console.ReadLine();
                            dude.confidence += 2;
                            guy.confidence += 3;
                            dude.target = guy.target;
                        }
                    }
                }
            }
        }
        static void mergedtribal(List<player> jury, List<player> guys)
        {
            Console.WriteLine("Time for Tribal");
            Console.ReadLine();
            foreach (player dude in guys)
            {
                if (dude.confidence >= 100) Console.WriteLine("{0} says: I know exactly what is going to happen here tonight", dude.name);
                else if (dude.confidence >= 65) Console.WriteLine("{0} says: I am pretty confident tonight is goint to be a good night", dude.name);
                else if (dude.confidence >= 35) Console.WriteLine("{0} says: We will have to see how the night goes", dude.name);
                else Console.WriteLine("{0} says: I am very scared about how tonight will go", dude.name);
                Console.ReadLine();
            }
            foreach (player dude in guys)
            {
                foreach (player person in guys)
                {
                    if (dude.target == person)
                    {
                        Console.WriteLine("{0}, Voted for {1}", dude.name, person.name);
                        Console.ReadLine();
                        person.vote += 1;
                        break;
                    }
                }
            }
            player gone;
            int highest = 0;
            foreach (player dude in guys)
            {
                if (dude.vote > highest) highest = dude.vote;
            }
            List<player> choppingblock = new List<player> { };
            foreach (player dude in guys)
            {
                if (dude.vote >= highest) choppingblock.Add(dude);
            }
            Random rnd = new Random();
            if (choppingblock.Count > 1)
            {
                Console.Write("Fire-making contest between: ");
                foreach (player dude in choppingblock) Console.Write("{0}, ", dude.name);
                Console.WriteLine();
                gone = choppingblock[rnd.Next(choppingblock.Count)];
            }
            else gone = choppingblock[0];
            Console.WriteLine("{0} Has been evicted with {1} votes", gone.name, gone.vote);
            foreach (player dude in guys)
            {
                dude.confidence = rnd.Next(25, 101);
                dude.confidence -= dude.vote * 4;
                dude.vote = 0;
                if (dude.target == gone) dude.rank += 1;
                dude.immune = false;
            }
            using (StreamWriter sw = File.AppendText(String.Concat(Directory.GetCurrentDirectory(), "\\Players.txt"))) sw.WriteLine("{0} has been voted out", gone.name);
            jury.Add(gone);
            guys.Remove(gone);
        }
        static void finalvote(List<player> jury, List<player> team)
        {
            foreach(player dude in jury)
            {
                dude.target = getbestcompetitor(team, dude);
                Random rnd = new Random();
                if (rnd.Next(3) == 1) dude.target = getworstcompetitor(team, dude);
            }
            foreach (player dude in jury)
            {
                foreach (player person in team)
                {
                    if (dude.target == person)
                    {
                        Console.WriteLine("{0}, Voted for {1}", dude.name, person.name);
                        Console.ReadLine();
                        person.vote += 1;
                        break;
                    }
                }
            }
            Console.WriteLine("{0} got {1} votes", team[0].name, team[0].vote);
            Console.WriteLine("{0} got {1} votes", team[1].name, team[1].vote);
            using (StreamWriter sw = File.AppendText(String.Concat(Directory.GetCurrentDirectory(), "\\Players.txt")))
            {
                sw.WriteLine("{0} got {1} votes", team[0].name, team[0].vote);
                sw.WriteLine("{0} got {1} votes", team[1].name, team[1].vote);
            }
            Console.ReadLine();
            Console.WriteLine("And the winner is...");
            Console.ReadLine();
            if(team[0].vote > team[1].vote) Console.WriteLine("{0}", team[0].name);
            else if (team[0].vote < team[1].vote) Console.WriteLine("{0}", team[1].name);
            else Console.WriteLine("{0} and {1} tied!!!", team[0].name, team[1].name);
            Console.ReadLine();
        }
        static void Shuffle<T>(this IList<T> ts)
        {
            int count = ts.Count;
            Random rnd = new Random();
            int last = count - 1;
            for (int i = 0; i < last; i++)
            {
                int r = rnd.Next(count);
                var temp = ts[i];
                ts[i] = ts[r];
                ts[r] = temp;
            }
        }
        static void Main(string[] args)
        {
            string path = Directory.GetCurrentDirectory();
            string message;
            for (bool x = false; x == false;)
            {
                Console.WriteLine("Do you want to add players?");
                message = Console.ReadLine();
                bool t = false;
                if (Boolean.TryParse(message, out t))
                {
                    if (t)
                    {
                        player addition = new player();
                        int i = 0;
                        Console.WriteLine("What team will they join?");
                        message = Console.ReadLine();
                        if (int.TryParse(message, out i))
                        {
                            addition.team = i;
                        }
                        else continue;
                        Console.WriteLine("What is their name?");
                        addition.name = Console.ReadLine();
                        Console.WriteLine("What is their trickiness?");
                        message = Console.ReadLine();
                        if (int.TryParse(message, out i))
                        {
                            addition.trickiness = i;
                        }
                        else continue;
                        Console.WriteLine("What is their athleticism?");
                        message = Console.ReadLine();
                        if (int.TryParse(message, out i))
                        {
                            addition.athleticism = i;
                        }
                        else continue;
                        Console.WriteLine("What is their endurance?");
                        message = Console.ReadLine();
                        if (int.TryParse(message, out i))
                        {
                            addition.endurance = i;
                        }
                        else continue;
                        Console.WriteLine("What is their survivability?");
                        message = Console.ReadLine();
                        if (int.TryParse(message, out i))
                        {
                            addition.survivability = i;
                        }
                        else continue;
                        Console.WriteLine("What is their puzzle-solving?");
                        message = Console.ReadLine();
                        if (int.TryParse(message, out i))
                        {
                            addition.puzzlesolving = i;
                        }
                        else continue;
                        if (addition.team == 0) players1.Add(addition);
                        else players2.Add(addition);
                    }
                    else x = true;
                }
            }
            for(bool x = false; x == false;)
            {
                Console.WriteLine("How many players per team?");
                message = Console.ReadLine();
                int y = 0;
                bool possible = int.TryParse(message, out y);
                if (possible)
                {
                    create_characters(y - players1.Count, true);
                    create_characters(y - players2.Count, false);
                    x = true;
                    using (StreamWriter output = new StreamWriter(string.Concat(path, "\\Players.txt")))
                    {
                        foreach(player dude in players1)
                        {
                            output.WriteLine("{0}: Trickiness: {1} Athleticism: {2} Endurance: {3} Survivability: {4} Puzzlesolving {5}", dude.name, dude.trickiness, dude.athleticism, dude.endurance, dude.survivability, dude.puzzlesolving);
                        }
                        foreach (player dude in players2)
                        {
                            output.WriteLine("{0}: Trickiness: {1} Athleticism: {2} Endurance: {3} Survivability: {4} Puzzlesolving {5}", dude.name, dude.trickiness, dude.athleticism, dude.endurance, dude.survivability, dude.puzzlesolving);
                        }
                    }
                    path = string.Concat(path, "\\Players.txt");
                }
            }
            int r = 0;
            for (bool x = false; x == false;)
            {
                Console.WriteLine("How many players will remain on one team when the merge occurs?");
                message = Console.ReadLine();
                bool possible = int.TryParse(message, out r);
                if (possible) x = true;
            }
            for(int x = r; x < players1.Count && x < players2.Count;)
            {
                players1.Shuffle();
                players2.Shuffle();
                Random rnd = new Random();
                foreach(player guy in players1)
                {
                    guy.confidence += rnd.Next(10);
                    guy.confidence -= rnd.Next(10);
                }
                Console.WriteLine("Time for a challenge");
                Console.ReadLine();
                int n = team_challenge();
                Console.WriteLine("Team {0} Won the challenge", n);
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Team {0} won the challenge", n);
                }
                    Console.ReadLine();
                if (n == 0) players2.Remove(eviction(1));
                else players1.Remove(eviction(0));
            }
            Console.WriteLine("Time for the merge!");
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("Merge");
            }
            Console.ReadLine();
            List<player> jury = new List<player> { };
            players1.AddRange(players2);
            foreach (player dude in players1) dude.confidence = 50;
            for(int x = players1.Count; x > 2; x--)
            {
                players1.Shuffle();
                Random rnd = new Random();
                Console.WriteLine("Time for an individual challenge");
                Console.ReadLine();
                individualcompetition(players1, rnd.Next(3)).immune = true;
                Console.ReadLine();
                mergedcamp();
                mergedtribal(jury, players1);
            }
            finalvote(jury, players1);
        }
    }
}
