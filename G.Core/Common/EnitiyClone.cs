using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace G.Core.Common
{
    public static class EnityClone
    {
        public static T Clone<T>(this T t)
        {
            //return (T)CloneObject(t);
            return Force.DeepCloner.DeepClonerExtensions.DeepClone<T>(t);
        }

        private static object CloneObject(object obj)
        {
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter(null, new StreamingContext(StreamingContextStates.Clone));
                binaryFormatter.Serialize(memStream, obj);
                memStream.Seek(0, SeekOrigin.Begin);
                return binaryFormatter.Deserialize(memStream);
            }
        }
    }
}
