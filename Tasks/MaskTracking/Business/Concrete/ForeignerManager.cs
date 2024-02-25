using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;


public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {

    }

    public List<Person> GetList()
    {
        return null;
    }

    public bool CheckPerson(Person person)
    {
        return true;
    }
}