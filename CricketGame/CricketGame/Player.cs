using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketGame
{
    public class Player : Team
    {

        public Player() { }


        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        string _role;

        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
        int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        string _experience;

        public string Experience
        {
            get { return _experience; }
            set { _experience = value; }
        }
        string _style;

        public string Style
        {
            get { return _style; }
            set { _style = value; }
        }
        int _pRecord;

        public int PRecord
        {
            get { return _pRecord; }
            set { _pRecord = value; }
        }




        public Player(string name, string role)
        {
            _name = name;
            _role = role;

        }


        public virtual string Display()
        {

            return Name + "-------------" + Role;
        }



    }
}
