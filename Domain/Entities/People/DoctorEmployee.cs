using System.Collections.Generic;
namespace Domain.Entities.People;

[Serializable]
public class DoctorEmployee : User
{
    public Qualifications Category { get; set; }
    public List<Client> Patients { get; set; }
    public List<string> Speciality { get; set; }



    public DoctorEmployee() : base()
    {
        Category = Qualifications.FirstCategory;
        Speciality = new List<string>();
        Patients = new List<Client>();
    }
    public DoctorEmployee(string name, string surname,  string login, string password, Qualifications category, List<string> speciality, List<Client> clients)
    : base(name, surname, login, password)
    {
        Category = category;
        Speciality = new List<string>(speciality);
        Patients = new List<Client>(clients);
    }
}