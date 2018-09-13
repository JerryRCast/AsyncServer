using System.Net.Sockets;

namespace ServerMultiThread
{
    public class ClientState
    {
        public TcpClient client;
        public byte[] buffer;
    }
}