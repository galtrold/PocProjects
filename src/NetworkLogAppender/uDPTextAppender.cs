using System.Net.Sockets;
using System.Text;
using log4net.Appender;
using log4net.Core;

namespace NetworkLogAppender
{
    public class UdpTextAppender : AppenderSkeleton
    {
       
        public UdpTextAppender()
        {

        }

        protected override void Append(LoggingEvent loggingEvent)
        {
            //var udpClient = new TcpClient("localhost", 9080);

            //var writer = new StreamWriter(udpClient.GetStream());

            //writer.Write("Custom tcp appender calling!");

            //writer.Close();
            //udpClient.Close();

            var logMessage = RenderLoggingEvent(loggingEvent);

            var udpClient = new UdpClient();
            var message = Encoding.ASCII.GetBytes(logMessage);
            udpClient.Send(message, message.Length, "localhost", 8085);
            udpClient.Close();
        }
    }
}