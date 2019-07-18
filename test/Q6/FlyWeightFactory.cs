using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public static class FlyWeightFactory
    {

        private static Dictionary<char, VeryHeavyObject> respository = new Dictionary<char, VeryHeavyObject>();
        private static object key = new object();
        public static VeryHeavyObject GetHeavyObjects(char typeOfObject)
        {
            if (respository.TryGetValue(typeOfObject, out VeryHeavyObject result))
            {
                return result;
            }

            lock (key)
            {

                if (respository.TryGetValue(typeOfObject, out VeryHeavyObject resultAgain))
                {
                    return resultAgain;
                }

                VeryHeavyObject newObject = null;

                switch (typeOfObject)
                {
                    case 'A':
                        newObject = new VeryHeavyObject();
                        break;
                    case 'N':
                        newObject = new VeryHeavyObject();
                        break;
                    case 'O':
                        newObject = new VeryHeavyObject();
                        break;
                }

                respository[typeOfObject] = newObject;

                return newObject;
            }
            
        }
    }
}
