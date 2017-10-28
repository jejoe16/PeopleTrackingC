﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTrackingC.Workers
{
    public class User
    {
        public User(Boolean capt, String poss)
        {
            captain = capt;
            possition = poss;
        }
        // indicates wheter or not this specific user should go down with his ship
        private Boolean captain;
        private String possition;

        public bool Captain { get => captain; }

        public string GetPossition()
        {
            return possition;
        }

        public void SetPossition(string poss)
        {
            this.possition = poss;
        }

    }
}