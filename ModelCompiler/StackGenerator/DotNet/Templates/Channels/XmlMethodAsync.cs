using System;

class Placeholder
{
// ***START***
#if (!OPCUA_EXCLUDE__NAME_)
/// <summary>
/// The client side implementation of the _NAME_ service contract.
/// </summary>
public _NAME_ResponseMessage _NAME_(_NAME_Message request)
{
    try
    {
        IAsyncResult result = null;

        lock (this.Channel)
        {
            result = this.Channel.Begin_NAME_(request, null, null);
        }

        return this.Channel.End_NAME_(result);
    }
    catch (FaultException<ServiceFault> e)
    {
        throw HandleSoapFault(e);
    }
}

/// <summary>
/// The client side implementation of the Begin_NAME_ service contract.
/// </summary>
public IAsyncResult Begin_NAME_(_NAME_Message request, AsyncCallback callback, object asyncState)
{
    WcfChannelAsyncResult asyncResult = new WcfChannelAsyncResult(Channel, callback, asyncState);

    lock (asyncResult.Lock)
    {
        asyncResult.InnerResult = asyncResult.Channel.Begin_NAME_(request, asyncResult.OnOperationCompleted, null);
    }

    return asyncResult;
}

/// <summary>
/// The client side implementation of the End_NAME_ service contract.
/// </summary>
public _NAME_ResponseMessage End_NAME_(IAsyncResult result)
{
    try
    {
        WcfChannelAsyncResult asyncResult = WcfChannelAsyncResult.WaitForComplete(result);
        return asyncResult.Channel.End_NAME_(asyncResult.InnerResult);
    }
    catch (FaultException<ServiceFault> e)
    {
        throw HandleSoapFault(e);
    }
}
#endif
// ***END***
}
