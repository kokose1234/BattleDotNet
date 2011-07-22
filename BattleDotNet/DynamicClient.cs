using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet
{
    public class DynamicClient : Client
    {
        public DynamicClient(string path, ClientRegion? region = null, string publicKey = null, string signature = null)
            : base(path, region, publicKey, signature)
        {
        }

        public dynamic Get(string path, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            return base.Get<dynamic>(path);
        }

        // TODO : Add dynamic member invocation support
        //public override bool TryInvokeMember(System.Dynamic.InvokeMemberBinder binder, object[] args, out object result)
        //{
        //    string methodName = binder.Name;
        //    var info = binder.CallInfo;

        //    if (methodName == "Get" && args.Count() > 0 && (args[0] as string != null))
        //    {
        //        string path = args[0] as string;

        //        IDictionary<string, string> extraParameters = new Dictionary<string, string>();
        //        for (int i = 1; i < args.Length; i++)
        //            extraParameters.Add(info.ArgumentNames[i - 1], args[i].ToString());

        //        dynamic dynamicResult = Get<dynamic>(path, extraParameters);
        //        result = dynamicResult;
        //        return true;
        //    }

        //    return base.TryInvokeMember(binder, args, out result);
        //}
    }
}
