using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Family
{
    public List<Person> members = new List<Person>();

    public void AddMember(Person member)
    {
        members.Add(member);
    }

    public Person GetOldestMember()
    {
        return members.OrderByDescending(p => p.age).First();
    }

    public List<Person> GetOverThirty()
    {
        return members
            .Where(p => p.age > 30)
            .OrderBy(p => p.name)
            .ToList();
    }
}

