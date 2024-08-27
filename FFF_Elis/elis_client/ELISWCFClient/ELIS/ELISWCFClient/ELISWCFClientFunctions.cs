// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCFClient.ELISWCFClientFunctions
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISWCF;
using System;
using System.Net.Security;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;

#nullable disable
namespace ELIS.ELISWCFClient
{
  public class ELISWCFClientFunctions
  {
    private string wcfIP;
    private string wcfPort;

    public ELISWCFClientFunctions(string wcfIP, string wcfPort)
    {
      this.wcfIP = wcfIP;
      this.wcfPort = wcfPort;
    }

    internal ChannelFactory<IELISWCFService> GetWCFService()
    {
      try
      {
        new ELISWCFServiceClient((System.ServiceModel.Channels.Binding) this.Binding, this.Endpoint).ConnectedELIS();
        return new ChannelFactory<IELISWCFService>((System.ServiceModel.Channels.Binding) this.Binding, this.Endpoint);
      }
      catch (ProtocolException ex)
      {
        return (ChannelFactory<IELISWCFService>) null;
      }
    }

    public ELISWCFServiceClient getWCFServiceClient(ref bool isSecured)
    {
      isSecured = false;
      ELISWCFServiceClient wcfServiceClient = (ELISWCFServiceClient) null;
      if (wcfServiceClient == null)
      {
        ELISWCFClientFunctions eliswcfClientFunctions = new ELISWCFClientFunctions(this.wcfIP, this.wcfPort);
        try
        {
          wcfServiceClient = new ELISWCFServiceClient((System.ServiceModel.Channels.Binding) eliswcfClientFunctions.Binding, eliswcfClientFunctions.Endpoint);
          wcfServiceClient.ConnectedELIS();
        }
        catch (ProtocolException ex)
        {
          throw ex;
        }
      }
      return wcfServiceClient;
    }

    public WCFTicket getTicket(string userName, string password)
    {
      using (ChannelFactory<IELISWCFService> wcfService = this.GetWCFService())
      {
        IELISWCFService channel = wcfService.CreateChannel();
        try
        {
          return channel.CreateTicket(userName, ELISWCFClientFunctions.CreatePasswordHash(password));
        }
        catch (FaultException<WCFException> ex1)
        {
          try
          {
            return channel.CreateTicket(userName, password);
          }
          catch (FaultException<WCFException> ex2)
          {
            throw ex2;
          }
          catch (Exception ex3)
          {
            throw ex3;
          }
        }
        catch (Exception ex)
        {
          throw ex;
        }
      }
    }

    private static string CreatePasswordHash(string str)
    {
      try
      {
        SHA1 shA1 = SHA1.Create();
        shA1.ComputeHash(new ASCIIEncoding().GetBytes(str));
        string passwordHash = "";
        foreach (byte num in shA1.Hash)
          passwordHash += num.ToString("x2");
        return passwordHash;
      }
      catch (Exception ex)
      {
        string str1 = "Error in HashCode : " + ex.Message;
      }
      return "";
    }

    private NetTcpBinding Binding => this.GetBinding(SecurityMode.None);

    private NetTcpBinding GetBinding(SecurityMode mode)
    {
      NetTcpBinding binding = new NetTcpBinding();
      try
      {
        // TODO: Workaround
        return new NetTcpBinding(SecurityMode.Transport);
        // return new NetTcpBinding("ELISWCFTcpBindingCustom");
      }
      catch (Exception ex)
      {
      }
      binding.Name = "ELISWCFTcpBinding";
      binding.CloseTimeout = new TimeSpan(0, 1, 0);
      binding.OpenTimeout = new TimeSpan(0, 1, 0);
      binding.ReceiveTimeout = new TimeSpan(0, 10, 0);
      binding.SendTimeout = new TimeSpan(0, 1, 0);
      binding.MaxBufferPoolSize = 62914560L;
      binding.MaxBufferSize = 62914560;
      binding.MaxConnections = 10;
      binding.MaxReceivedMessageSize = 62914560L;
      binding.ReaderQuotas.MaxArrayLength = 62914560;
      binding.ReaderQuotas.MaxBytesPerRead = 32768;
      binding.ReaderQuotas.MaxDepth = 32;
      binding.ReaderQuotas.MaxNameTableCharCount = 32768;
      binding.ReaderQuotas.MaxStringContentLength = 62914560;
      binding.ReliableSession.Enabled = false;
      binding.ReliableSession.InactivityTimeout = new TimeSpan(0, 10, 0);
      binding.ReliableSession.Ordered = true;
      binding.Security.Mode = mode;
      binding.Security.Transport.ProtectionLevel = ProtectionLevel.EncryptAndSign;
      binding.TransferMode = TransferMode.Streamed;
      return binding;
    }

    private EndpointAddress Endpoint => new("net.tcp://" + this.wcfIP + ":" + this.wcfPort + "/ELISWCFService");
  }
}
