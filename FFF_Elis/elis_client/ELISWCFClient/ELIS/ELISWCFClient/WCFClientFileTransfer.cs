// Decompiled with JetBrains decompiler
// Type: ELIS.ELISWCFClient.WCFClientFileTransfer
// Assembly: ELISWCFClient, Version=3.3.7468.42015, Culture=neutral, PublicKeyToken=null
// MVID: 932EE77D-FA6F-4D6F-BCDB-361823ADB197
// Assembly location: C:\Users\Haunschmied.Bastian\Documents\GitHub\Feuerwehr-Tools\FFF_Elis\FFF_Elis\libs\ELISWCFClient.dll

using ELIS.ELISWCF;
// using ELIS.LogBase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.ServiceModel;

#nullable disable
namespace ELIS.ELISWCFClient
{
  public class WCFClientFileTransfer
  {
    //private static Logfile log;
    private string wcfIp;
    private string wcfPort;

    public WCFClientFileTransfer(/*Logfile logFile,*/ string wcfIp, string wcfPort)
    {
      this.wcfIp = wcfIp;
      this.wcfPort = wcfPort;
      //log = logFile;
    }

    public bool FileUpload(string filePath, string fileName, WCFFileTyp ft, Guid TicketID)
    {
      try
      {
        int count = 1;
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          using (FileStream fileStream = File.OpenRead(filePath))
          {
            byte[] numArray = new byte[count];
            List<byte> byteList = new List<byte>();
            while (fileStream.Read(numArray, 0, count) > 0)
              byteList.AddRange((IEnumerable<byte>) numArray);
            byte[] array = byteList.ToArray();
            channel.FileUpload(fileName, array, ft, TicketID);
          }
          return true;
        }
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a compiler-generated type
        // TODO: Custom Logging
        // WCFClientFileTransfer.log.writelogfile(EventLogEntryType.Error, (LogCategory) 110, ex.Message);
        return false;
      }
    }

    public bool FileDownload(string filePath, string fileName, WCFFileTyp ft, Guid TicketID)
    {
      try
      {
        using (ChannelFactory<IELISWCFService> wcfService = new ELISWCFClientFunctions(this.wcfIp, this.wcfPort).GetWCFService())
        {
          IELISWCFService channel = wcfService.CreateChannel();
          FileInfo fileInfo = new FileInfo(filePath);
          if (fileInfo.Exists)
          {
            DateTime lastWriteTime = fileInfo.LastWriteTime;
            DateTime? modificationDate = channel.FileGetLastModificationDate(fileName, ft, TicketID);
            if (modificationDate.HasValue)
            {
              DateTime dateTime = lastWriteTime;
              DateTime? nullable = modificationDate;
              if ((nullable.HasValue ? (dateTime > nullable.GetValueOrDefault() ? 1 : 0) : 0) != 0)
                return true;
            }
          }
          if (!channel.FileCheckExists(fileName, ft, TicketID))
            return false;
          using (Stream readStream = channel.FileDownload(fileName, ft, TicketID))
          {
            using (FileStream writeStream = File.Create(filePath))
              WCFClientFileTransfer.ReadWriteStream(readStream, (Stream) writeStream);
          }
        }
        return true;
      }
      catch (Exception ex)
      {
        // TODO: Custom Logging
        // WCFClientFileTransfer.log.writelogfile(EventLogEntryType.Error, (LogCategory) 111, ex.Message);
        return false;
      }
    }

    private static void ReadWriteStream(Stream readStream, Stream writeStream)
    {
      int count1 = 1024;
      byte[] buffer = new byte[count1];
      for (int count2 = readStream.Read(buffer, 0, count1); count2 > 0; count2 = readStream.Read(buffer, 0, count1))
        writeStream.Write(buffer, 0, count2);
    }
  }
}
