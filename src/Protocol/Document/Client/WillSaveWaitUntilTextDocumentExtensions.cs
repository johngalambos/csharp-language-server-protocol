using System.Threading.Tasks;
using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;

// ReSharper disable CheckNamespace

namespace OmniSharp.Extensions.LanguageServer.Protocol.Client
{
    public static class WillSaveWaitUntilTextDocumentExtensions
    {
        public static Task WillSaveWaitUntilTextDocument(this ILanguageClientDocument mediator, WillSaveTextDocumentParams @params)
        {
            return mediator.SendRequest(DocumentNames.WillSaveWaitUntil, @params);
        }
    }
}