public class Doctor
{
    private static int _carCounter = 0;  // Counter for Cardiology
    private static int _neuCounter = 0;  // Counter for Neurology
    private static int _oncCounter = 0;  // Counter for Oncology
    private static int _othCounter = 0;  // Counter for Other (default department)

    public readonly string Id;
    public string Name { get; }
    public string Department { get; }
    public readonly List<Patient> AssignedPatients = new List<Patient>();
    public readonly List<Doctor> Supervisees = new List<Doctor>();
    public string SupervisorId { get; set; }

    public const string DefaultSupervisorId = "OTH001"; // Default supervisor ID

    public Doctor(string name, string department)
    {
        // Ensure the department is not null or empty, otherwise set it to "Other"
        Department = string.IsNullOrEmpty(department) ? "Other" : department;
        Name = name;
        Id = GenerateDoctorId();
        SupervisorId = DefaultSupervisorId; // Set default supervisor ID
    }

    private string GenerateDoctorId()
    {
        string prefix;
        int currentCount;

        // Determine the department and its respective counter
        switch (Department.ToLower())
        {
            case "cardiology":
                prefix = "CAR";
                currentCount = ++_carCounter;  // Increment counter for Cardiology
                break;

            case "neurology":
                prefix = "NEU";
                currentCount = ++_neuCounter;  // Increment counter for Neurology
                break;

            case "oncology":
                prefix = "ONC";
                currentCount = ++_oncCounter;  // Increment counter for Oncology
                break;

            default:
                prefix = "OTH";
                currentCount = ++_othCounter;  // Increment counter for Other department
                break;
        }

        // Format the ID with a zero-padded counter (e.g., CAR001, NEU001, etc.)
        return $"{prefix}{currentCount:D3}";  // The :D3 ensures the number is always 3 digits, e.g., 001, 002
    }
}
