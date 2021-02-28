namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Family
    {
        private List<Person> family;

        public Family()
        {
            this.family = new List<Person>();
        }

        public List<Person> Member
        {
            get { return this.family; }
            set { this.family = value; }
        }

        public void AddMemeber(Person member)
        {
            this.family.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.family.OrderByDescending(x => x.Age).FirstOrDefault();
        }
    }
}
