using BraintreeHttp;
using PayPal.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Tai.Models.CaptureIntent
{
    public class PayPalClient
    {
        public static PayPalEnvironment environment()
        {
            return new SandboxEnvironment(
                 "AU197baVlXQbmrQ7G7mkjPyFa1XFm983K4mOZCm-BGskv5E_kjhjIBbcWTRCPqGyUJRCgY_x_DD3H6YX",
                "ECaYk6w0kJASKQWfSUcEmWf1TzseAmb2_Zjv_8V7tkg477I9ZXT276VxCHWevYbAM0Z1QOaU4AxLTDS2");
        }
        public static HttpClient client()
        {
            return new PayPalHttpClient(environment());
        }
        public static String ObjectToJSONString(Object serializableObject)
        {
            MemoryStream memoryStream = new MemoryStream();
            var writer = JsonReaderWriterFactory.CreateJsonWriter(
                        memoryStream, Encoding.UTF8, true, true, "  ");
            DataContractJsonSerializer ser = new DataContractJsonSerializer(serializableObject.GetType(), new DataContractJsonSerializerSettings { UseSimpleDictionaryFormat = true });
            ser.WriteObject(writer, serializableObject);
            memoryStream.Position = 0;
            StreamReader sr = new StreamReader(memoryStream);
            return sr.ReadToEnd();
        }
    }
}
