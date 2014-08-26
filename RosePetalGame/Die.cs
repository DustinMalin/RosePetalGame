using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;




namespace RosePetalGame
{
    class Die
    {

        private int faceValue;
        private int petalCount;
        

        public Die()
        {
            //no args constructor
        }

        public int Roll()
        {
            Random dieRollGenerator = new Random();
                        
            Thread.Sleep(30);

            Random dieRoll = new Random();

            FaceValue = dieRoll.Next(1,7);
            
            switch(FaceValue)
            {
                case 1: PetalCount = 0;
                    break;
                case 2: PetalCount = 0;
                    break;
                case 3: PetalCount = 2;
                    break;
                case 4: PetalCount = 0;
                    break;
                case 5: PetalCount = 4;
                    break;
                case 6: PetalCount = 0;
                    break;
            }

            

            return FaceValue;
        }


   
        

        #region Accessors and Mutators


        public int FaceValue
        {
            get
            {
                return faceValue;
            }
            set
            {
                faceValue = value;
            }
        }

        public int PetalCount
        {
            get
            {
                return petalCount;
            }
            set
            {
                petalCount = value;
            }
        }

        
        #endregion
    }
}
