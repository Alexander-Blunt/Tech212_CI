using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariGameApp
{
    public class Person : IMovable
    {
        //fields
        private string _firstName = "";
        private string _lastName = "";

        //property
        public string FirstName 
        {
            get
            {
                return _firstName;
            }
            init
            {
                _firstName = value; 
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            init
            {
                _lastName = value;
            }
        }

        //method
        public virtual string FullName()
        {
            return _firstName + " " + _lastName;

        }

        //constructor
        public Person(string firstName, string lastName)
        {
            _firstName= firstName;
            _lastName= lastName;

        }

        //empty 
        public Person() { }

        public override string ToString()
        {
            return $"{base.ToString()} {FirstName} {LastName}";
        }

        public int Position { get; set; }

        public int Speed { get; init; }

        public virtual string Move()
        {
            Position += Speed;
            return "You move in closer";
        }

        public virtual string Back()
        {
            Position -= Speed;
            return "You back away";
        }

        int IMovable.Move()
        {
            Position += Speed;
            return Position;
        }

        int IMovable.Move(int times)
        {
            Position += times * Speed;
            return times;
        }

        int PlayerPosition()
        {
            return Position;
        }        
    }
}