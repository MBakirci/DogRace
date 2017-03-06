using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternatief
{
    public class Dog
    {
        private int number;
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        private int score;
        public int Score 
        {
            get {
                return score;
            } 
            set {
                score = value; 
            } }

        public bool Run()
        {
            return true;
        }

        public void TakeStartingPosition()
        {

        }
    }
}
