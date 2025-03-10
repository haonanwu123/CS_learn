public static class Hospital
{
    public const string Name = "Erasmus MC";
    public static readonly List<Doctor> Doctors = new List<Doctor>();
    public static readonly List<Patient> UnassignedPatients = new List<Patient>();
    public static readonly string[] Departments = new string[] { "Cardiology", "Neurology", "Oncology" };

    public static void AddDoctor(Doctor doctor)
    {
        if (Doctors.Exists(d => d.Id == doctor.Id))
        {
            Console.WriteLine($"Doctor {doctor.Id} already works in the hospital");
        }
        else
        {
            Doctors.Add(doctor);
            Console.WriteLine($"Doctor {doctor.Id} has been added");
        }
    }

    // Static method to remove a doctor from the hospital
    public static void RemoveDoctor(string id)
    {
        Doctor? doctor = Doctors.Find(d => d.Id == id);
        if (doctor != null)
        {
            Doctors.Remove(doctor);
            Console.WriteLine($"Doctor {doctor.Id} has been removed");
        }
        else
        {
            Console.WriteLine($"Doctor with ID {id} not found");
        }
    }

    // Static method to add a patient to the hospital
    public static void AddPatient(Patient patient)
    {
        if (UnassignedPatients.Exists(p => p.Id == patient.Id))
        {
            Console.WriteLine($"Patient {patient.Id} is already registered in the hospital");
        }
        else
        {
            UnassignedPatients.Add(patient);
            Console.WriteLine($"Patient {patient.Id} registered in the hospital");
        }
    }

    // Static method to remove a patient from the hospital
    public static void RemovePatient(string id)
    {
        Patient? patient = UnassignedPatients.Find(p => p.Id == id);
        if (patient != null)
        {
            UnassignedPatients.Remove(patient);
            Console.WriteLine($"Patient {patient.Id} has been removed");
        }
        else
        {
            Console.WriteLine($"Patient with ID {id} not found");
        }
    }

    // Static method to assign a doctor to a patient
    public static void AssignDoctorToPatient(string doctorId, string patientId)
    {
        Doctor? doctor = Doctors.Find(d => d.Id == doctorId);
        Patient? patient = UnassignedPatients.Find(p => p.Id == patientId);

        if (doctor == null)
        {
            Console.WriteLine($"Doctor with ID {doctorId} not found");
            return;
        }

        if (patient == null)
        {
            Console.WriteLine($"Patient with ID {patientId} not found");
            return;
        }

        // Check if the doctor has already assigned this patient
        if (doctor.AssignedPatients.Exists(p => p.Id == patientId))
        {
            Console.WriteLine($"Patient {patient.Id} is already assigned to doctor {doctor.Id}");
        }
        else
        {
            doctor.AssignedPatients.Add(patient);
            Console.WriteLine($"Patient {patient.Id} is assigned to doctor {doctor.Id}");
        }
    }


    // Static method to assign a supervisee to a supervisor
    public static void AssignSuperviseeToSupervisor(string superviseeId, string supervisorId)
    {
        Doctor? supervisee = Doctors.Find(d => d.Id == superviseeId);
        Doctor? supervisor = Doctors.Find(d => d.Id == supervisorId);

        if (supervisee == null || supervisor == null)
        {
            Console.WriteLine($"Doctor(s) not found:");
            if (supervisee == null) Console.WriteLine($" - {superviseeId}");
            if (supervisor == null) Console.WriteLine($" - {supervisorId}");
            return;
        }

        if (!supervisor.Supervisees.Exists(d => d.Id == superviseeId))
        {
            supervisor.Supervisees.Add(supervisee);
            supervisee.SupervisorId = supervisor.Id;
            Console.WriteLine($"Added {supervisee.Id} to supervisor {supervisor.Id}");
        }
        else
        {
            Console.WriteLine($"{supervisee.Id} is already a supervisee of {supervisor.Id}");
        }
    }
}
