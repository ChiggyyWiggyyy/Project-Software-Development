namespace bicycleNamespace
{
    class Manufacturer 
    {
        public string Name{ get; set;}
        public string Country{get; set;}
        public string Category{get; set;}
        public Manufacturer(string pName, string pCountry,string pCategory)
        {
            Name = pName;
            Country = pCountry;
            Category = pCategory;
        }
        public void ListDetails()
        {
            Console.WriteLine("Manufacturer Data");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Country: " + Country);
            Console.WriteLine("Category: " + Category);
            Console.ReadKey();
        }
    }
    abstract class Component
    {
        public string? Name { get; set; }
        public float Price { get; set; }

        public void ListDetails()
        {
            Console.WriteLine("Component Data");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price.ToString("F2") + "Rupee");
            Console.WriteLine();
            Console.ReadKey();          
        }
    }

    class MechComponent : Component
    {
        public string Material { get; set; }
        public MechComponent(string mName, float mPrice, string mMaterial)
        {
            Name = mName;
            Price = mPrice;
            Material = mMaterial;
            program.AllComponents.Add(this);
        }
    }

    class ElecComponent : Component
    {
        public string PowerUsage{ get; set; }
        public ElecComponent(string eName,float ePrice, string ePowerUsage )
        {
            Name = eName;
            Price = ePrice;
            PowerUsage = ePowerUsage;
            program.AllComponents.Add(this);
        }
    }

    class AccessoriesComponent : Component
    {
        public string Utility { get; set; }
        public AccessoriesComponent(string hName, float hPrice, string hUtility)
        {
            Name = hName;
            Price = hPrice;
            Utility = hUtility;
            program.AllComponents.Add(this);
        }
    }

    class RiderApparelComponent : Component
    {
        public string RiderGears { get; set; }
        public RiderApparelComponent(string dName, float dPrice, string dRiderGears)
        {
            Name = dName;
            Price = dPrice;
            RiderGears = dRiderGears;
            program.AllComponents.Add(this);
        }
    }
    class Bicycle
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public Manufacturer BicycleManufacturer { get; set; }
       private List<RiderApparelComponent> RiderApparelComponents = new List<RiderApparelComponent>();
       private List<ElecComponent> ElecComponents = new List<ElecComponent>();
       private List<MechComponent> MechComponents = new List<MechComponent>();
       private List<AccessoriesComponent> AccessoriesComponents = new List<AccessoriesComponent>();

        public Bicycle(string biName, float biPrice, Manufacturer biManufacturer)
        {
            Name = biName;
            Price = biPrice;
            BicycleManufacturer = biManufacturer;
            program.AllBicycles.Add(this);
        }

        public void ListDetails()
        {
            Console.WriteLine("Bicycle Data");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Manufacturer: " + BicycleManufacturer.Name);
            Console.WriteLine("Price: " + Price.ToString("F2") + "Rupees");
            Console.ReadKey();
        }

        public void AddAccessoriesComponent(AccessoriesComponent hComponenet)
        {
            AccessoriesComponents.Add(hComponenet);
            Price += hComponenet.Price;
        }
        
        public void AddElecComponent(ElecComponent eComponent)
        {
            ElecComponents.Add(eComponent);
            Price += eComponent.Price;
        }

        public void AddRiderApparelComponent(RiderApparelComponent dComponent)
        {
            RiderApparelComponents.Add(dComponent);
            Price += dComponent.Price;
        }

        public void AddMechComponent(MechComponent mComponent)
        {
            MechComponents.Add(mComponent);
            Price += mComponent.Price;
        }

        public void ListComponents()
        {
            Console.Write(Name + " has the following components: ");

            foreach(var item in MechComponents)
            {
                Console.Write(item.Name + ", ");
            }
            
            foreach(var item in ElecComponents)
            {
                Console.Write(item.Name + ", ");
            }
        
            foreach(var item in RiderApparelComponents)
            {
                Console.Write(item.Name + ", ");
            }
           
            foreach(var item in AccessoriesComponents)
            {
                Console.Write(item.Name + ", ");
            }
            
        }

            public void ListComponentDetails()
        {
            Console.WriteLine(Name + "  has the following components in detail: ");

            foreach (var item in MechComponents)
            {
                item.ListDetails();
            }
            foreach (var item in ElecComponents)
            {
                item.ListDetails();
            }
            foreach (var item in RiderApparelComponents)
            {
                item.ListDetails();
            }
            foreach (var item in AccessoriesComponents)
            {
                item.ListDetails();
            }

            Console.WriteLine("... Done.Dona.Done!!!.");
        }

        
    }

    class program
    {
        public static List<Bicycle> AllBicycles = new List<Bicycle>();
        public static List<Component> AllComponents = new List<Component>();
        public static void Main()
        {
            Console.Clear();

            Manufacturer hero = new Manufacturer("hero", "India", "City");
            Manufacturer firefox = new Manufacturer("firefox", "India", "MTB");
            Manufacturer trek = new Manufacturer("trek", "USA", "Race");
            Manufacturer SantaCruz = new Manufacturer("SantaCruz", "USA", "Mountain Bike");

            MechComponent CleatPedal = new MechComponent("CleatPedal", 50.0f, "Iron");
            MechComponent FreeWheel = new MechComponent("FreeWheel", 80.0f, "Stainless Steel");
            MechComponent GearShifter = new MechComponent("GearShifter", 130.0f, "Stainless Steel");

            ElecComponent FrontLight = new ElecComponent("FrontLight", 30.0f, "30 lux");
            ElecComponent ElectronicHorn = new ElecComponent("ElectricHorn", 22.0f, "90 decible");
            ElecComponent FrontSafetyLed = new ElecComponent("FrontSafetyLed", 39.0f, "60 lux");
            ElecComponent ElectricMotor = new ElecComponent("Motor", 100.0f, "50KW");

            AccessoriesComponent Lock = new AccessoriesComponent("Lock", 55.0f, "Safety");
            AccessoriesComponent BicycleMirror = new AccessoriesComponent("BicycleMirror", 67.0f, "Road Vision");
            AccessoriesComponent StorageBag = new AccessoriesComponent("StorageBag", 80.0f, "Storage");

            RiderApparelComponent RiderJacket = new RiderApparelComponent("RiderJacket", 99.0f, "Protection");
            RiderApparelComponent BicycleHelmet = new RiderApparelComponent("BicycleHelmet", 49.0f, "SafetyGear");
            RiderApparelComponent BicycleGloves = new RiderApparelComponent("BicycleGloves", 79.0f, "Protection");

            Bicycle bonfire = new Bicycle("Bonfire", 12299.00f, hero);
            Bicycle fusion = new Bicycle("Fusion", 22699.0f, firefox);
            Bicycle madoneSLR = new Bicycle("Madone SLR", 53345.0f, trek);
            Bicycle TallBoy = new Bicycle("Tall Boy", 99989.0f, SantaCruz);

            UserInterface();

            Console.ReadKey();
        }

        private static void UserInterface()
        {
            Console.WriteLine("Namaste Mitra!!");
            bool exitcondition = false;
            while (!exitcondition)
            {
                Console.Write("What are you here for?\n List all Bicycles - List Bicycles\n List all Components - List Components\n Exit - Exit\n :");
                string? userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "List Bicycles" :
                    foreach (var item in AllBicycles)
                    {
                       item.ListComponents();
                       item.ListDetails();
                       Console.WriteLine(item.BicycleManufacturer.Country);
                    }
                    break;

                    case "List Components" :
                    foreach (var item in AllComponents)
                    {
                        item.ListDetails();
                    }
                    break;

                    case "Exit" :
                    exitcondition = true;
                    break;
                    default:
                    break;

                }
                
                
            }
            Console.WriteLine("Phir Milenge Chalte Chalte Mitra!!");
        }
        
    }
    
}